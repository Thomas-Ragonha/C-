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
    public partial class VerChamado : Form
    {
        public VerChamado(Chamado chamado)
        {
            InitializeComponent();
            this.rtxtDescricaoChamado.Text = chamado.DescricaoChamado + "\n-----------------------------------\nResolução: " + chamado.ResolucaoChamado;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
