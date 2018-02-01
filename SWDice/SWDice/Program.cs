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
            //SWDice dadoDoJogador = new SWDice();
            //SWDice dadoSelvagem = new SWDice();
            string comando = Console.ReadLine().ToLower();
            Random rng = new Random();

            Dice dado = new Dice();
            var resultado = dado.Rolar(comando, rng);
            foreach(string x in resultado)
            {
                Console.Write(x + " ");
            }

            Console.Read();


            //int[] d6 = new int[] { 1, 6 };

            //List<string> resultadoRolagem = dadoDoJogador.Rolar(dadoDoJogador.DefineParametrosDaRolagem(comando), rng);
            //List<string> resultadoRolagemDadoSelvagem = dadoSelvagem.Rolar(d6, rng);

            //foreach (var x in resultadoRolagem)
            //{
            //    Console.Write(x + " ");
            //}

            //Console.Write("\n");

            //foreach (var x in resultadoRolagemDadoSelvagem)
            //{
            //    Console.Write(x + " ");
            //}

            //Console.Read();
        }
    }
}
