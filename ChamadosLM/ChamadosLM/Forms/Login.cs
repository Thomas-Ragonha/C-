using ChamadosLM.Forms;
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

namespace ChamadosLM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NomeUsuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            ConectaDB db = new ConectaDB();
            db.VerificaUsuario("select * from Usuarios where NomeUsuario ='" + usuario.NomeUsuario + "'" + "and Senha = '" + usuario.Senha + "'");

            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
