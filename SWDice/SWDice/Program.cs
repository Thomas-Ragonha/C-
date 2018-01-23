using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dadoDoJogador = new Dice();
            Dice dadoSelvagem = new Dice();
            string comando = Console.ReadLine().ToLower();
            Random rng = new Random();
            int[] d6 = new int[] { 1, 6 };

            List<string> resultadoRolagem = dadoDoJogador.Rolar(dadoDoJogador.DefineParametrosDaRolagem(comando), rng);
            List<string> resultadoRolagemDadoSelvagem = dadoSelvagem.Rolar(d6, rng);

            foreach (var x in resultadoRolagem)
            {
                Console.Write(x + " ");
            }

            Console.Write("\n");

            foreach (var x in resultadoRolagemDadoSelvagem)
            {
                Console.Write(x + " ");
            }

            Console.Read();
        }
    }
}
