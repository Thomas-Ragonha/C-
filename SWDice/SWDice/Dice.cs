using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDice
{
    class Dice
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


        public int DefineQuantidadeDeDados(string comandoRolagem)
        {
            if (comandoRolagem[0] == '/' && comandoRolagem[1] == 'r')
            {
                string[] caracteresRolagem = comandoRolagem.Split();
                string[] ComposicaoRolagem = caracteresRolagem[1].Split('d');
                int numeroValidado;
                int quantidadeDeDados;
                if (int.TryParse(ComposicaoRolagem[0], out numeroValidado))
                {
                    quantidadeDeDados = int.Parse(ComposicaoRolagem[0]);
                    return quantidadeDeDados;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public int DefineFaceDosDados(string comandoRolagem)
        {
            if (comandoRolagem[0] == '/' && comandoRolagem[1] == 'r')
            {
                string[] caracteresRolagem = comandoRolagem.Split();
                string[] ComposicaoRolagem = caracteresRolagem[1].Split('d');
                int numeroValidado;
                int faces;
                if (int.TryParse(ComposicaoRolagem[1], out numeroValidado))
                {
                    faces = int.Parse(ComposicaoRolagem[1]);
                    return faces;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }


    }
}
