using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamadosLM.Forms;

namespace ChamadosLM.Classes
{
    public class Chamado
    {
        public int ID { get; set; }
        public int IDUsuarioCriacaoChamado { get; set; }
        public string DescricaoChamado { get; set; }
        public string ResolucaoChamado { get; set; }
        public string DataCriacaoChamado { get; set; }
        public string DataFechamentoChamado { get; set; }
        public string StatusChamado { get; set; }

        public Chamado()
        {
            this.StatusChamado = "Aberto";
            this.DataCriacaoChamado = DateTime.Now.ToString();
        }

    }
}
