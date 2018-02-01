using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDice
{
    public class Dice
    {
        //Fields
        private int sides;

        //Properties
        public int Sides
        {
            get
            {
                return sides;
            }

            set
            {

                sides = value;
            }
        }

        //Constructors

        public Dice(int sides)
        {
            this.Sides = sides;
        }

        public Dice()
        {

        }


        //Methods

        public int[] DefineParametrosDaRolagem(string comandoRolagem)
        {
            string[] caracteresRolagem = comandoRolagem.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);
            string[] ComposicaoRolagem = caracteresRolagem[1].Split('d');
            int numeroValidado;
            int quantidadeDeDados;
            int faces;
            int[] retorno = new int[] { 0, 0 };
            if (int.TryParse(ComposicaoRolagem[0], out numeroValidado))
            {
                retorno[0] = int.Parse(ComposicaoRolagem[0]);
            }
            if (int.TryParse(ComposicaoRolagem[1], out numeroValidado))
            {
                retorno[1] = int.Parse(ComposicaoRolagem[1]);
            }

            return retorno;
        }

        public List<Dice> CriarDados(string comando)
        {
            int[] parametros = DefineParametrosDaRolagem(comando);
            List<Dice> lista = new List<Dice>();            for (int i = 0; i < parametros[0]; i++)
            {
                Dice dado = new Dice();
                dado.sides = parametros[1];
                lista.Add(dado);
            }
            return lista;
        }

        public List<string> Rolar(string comando, Random rng)
        {
            List<Dice> lista = CriarDados(comando);
            List<string> resultado = new List<string>();
            foreach (Dice x in lista)
            {
                resultado.Add(rng.Next(1, x.sides+1).ToString());
            }

            return resultado;
        }

        public List<string> VerificaExplosao(string comando, List<string> listaDeResultado)
        {
            foreach (string x in listaDeResultado)
            {
                if(x == comando[1].ToString())
                {

                }
            }
        }

    }
}
