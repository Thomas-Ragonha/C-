using System;
using System.Windows.Forms;
using ChamadosLM.Classes;

namespace ChamadosLM.Forms
{
    public partial class Home : Form
    {
        private Usuarios usuarioLogado { get; set; }

        public Home(Usuarios usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            ConectaDB db = new ConectaDB();
            gridChamados.DataSource = db.GetChamadosPorUsuario(usuarioLogado.ID);
        }

        private void btnNovoChamado_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarChamado criarChamado = new CriarChamado(usuarioLogado);
            criarChamado.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            //Botão Ver Chamado
            if (senderGrid.Columns[e.ColumnIndex].Index == 6 && e.RowIndex >= 0)
            {
                ConectaDB db = new ConectaDB();
                Chamado chamado = db.GetChamadoById(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].EditedFormattedValue));
                VerChamado verChamado = new VerChamado(chamado);
                verChamado.ShowDialog();
            }
            //Botão Excluir Chamado
            if (senderGrid.Columns[e.ColumnIndex].Index == 7 && e.RowIndex >=0)
            {
                ConectaDB db = new ConectaDB();
                Chamado chamado = db.GetChamadoById(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].EditedFormattedValue));
                if (chamado.StatusChamado != "Aberto")
                {
                    MessageBox.Show("IMPOSSÍVEL EXCLUIR CHAMADO QUE ESTÁ EM ATENDIMENTO OU CONCLUIDO!");
                }
                else
                {
                    db.ExcluirChamado(chamado.ID);
                    gridChamados.DataSource = db.GetChamadosPorUsuario(usuarioLogado.ID);
                }
            }
            //Botão Atender
            if (senderGrid.Columns[e.ColumnIndex].Index == 8 && e.RowIndex >= 0)
            {
                ConectaDB db = new ConectaDB();
                Chamado chamado = db.GetChamadoById(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].EditedFormattedValue));
                db.AtualizaStatusChamado(chamado.ID);
                gridChamados.DataSource = db.GetChamadosPorUsuario(usuarioLogado.ID);
            }
            //Botão Adicionar Resolução
            if (senderGrid.Columns[e.ColumnIndex].Index == 9 && e.RowIndex >= 0)
            {
                ConectaDB db = new ConectaDB();
                Chamado chamado = db.GetChamadoById(Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells[0].EditedFormattedValue));
                IncluirResolucaoChamado resolucao = new IncluirResolucaoChamado(chamado);
                resolucao.ShowDialog();
                gridChamados.DataSource = db.GetChamadosPorUsuario(usuarioLogado.ID);
            }
        }
    }
}
