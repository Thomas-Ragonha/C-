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
            Dice dice = new Dice();
            string comando = Console.ReadLine().ToLower();
            Random rng = new Random();

            int[] resultadoRolagem = dice.Rolar(dice.DefineParametrosDaRolagem(comando), rng);

            foreach (var x in resultadoRolagem)
            {
                Console.Write(x + " ");
            }

            Console.Read();
        }
    }
}
