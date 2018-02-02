using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChamadosLM.Classes;

namespace ChamadosLM.Forms
{
    public partial class CriarChamado : Form
    {
        private Usuarios usuarioLogado;

        public CriarChamado(Usuarios usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }

        private void btnAdicionarChamado_Click(object sender, EventArgs e)
        {
            if (rtxtDescricaoChamado!= null)
            {
                Chamado chamado = new Chamado();
                chamado.DescricaoChamado = rtxtDescricaoChamado.Text;
                ConectaDB db = new ConectaDB();
                db.ExecuteQuery("INSERT INTO Chamado (DescricaoChamado, DataCriacaoChamado, StatusChamado, IDUsuarioCriacaoChamado) VALUES (" + "'" + chamado.DescricaoChamado+ "'" +"," +"'"+ chamado.DataCriacaoChamado + "'" + "," + "'" + chamado.StatusChamado+"',"+usuarioLogado.ID +")");
                this.Hide();
                Home home = new Home(usuarioLogado);
                home.ShowDialog();
                this.Close();
            }
            
        }
    }
}
