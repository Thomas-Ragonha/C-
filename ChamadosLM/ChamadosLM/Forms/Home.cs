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
    }
}
