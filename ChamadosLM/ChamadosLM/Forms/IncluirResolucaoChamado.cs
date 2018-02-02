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
    public partial class IncluirResolucaoChamado : Form
    {
        private Chamado chamadoEdicao;
        public IncluirResolucaoChamado(Chamado chamado)
        {
            chamadoEdicao = chamado;
            InitializeComponent();
        }

        private void btnAdicionarResolucao_Click(object sender, EventArgs e)
        {
            chamadoEdicao.ResolucaoChamado = rtxtResolucaoChamado.Text;
            chamadoEdicao.StatusChamado = "Atendido";
            chamadoEdicao.DataFechamentoChamado = DateTime.Now.ToString();

            ConectaDB db = new ConectaDB();
            db.ResolucaoChamado(chamadoEdicao);
            this.Close();
        }
    }
}
