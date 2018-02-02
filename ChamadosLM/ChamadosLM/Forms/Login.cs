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
            Usuarios usuarioParaValidacao = new Usuarios();
            Usuarios usuarioValidado = new Usuarios();
            usuarioParaValidacao.NomeUsuario = txtUsuario.Text.ToUpper();
            usuarioParaValidacao.Senha = txtSenha.Text;
            ConectaDB db = new ConectaDB();
            usuarioValidado = db.VerificaUsuario("select * from Usuarios where NomeUsuario ='" + usuarioParaValidacao.NomeUsuario + "'" + "and Senha = '" + usuarioParaValidacao.Senha + "'");
            if (usuarioValidado.ID != 0)
            {
                this.Hide();
                Home home = new Home(usuarioValidado);
                home.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
