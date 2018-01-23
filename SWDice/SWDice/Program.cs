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
            dice.DefineQuantidadeDeDados(comando);
            dice.Sides = dice.DefineFaceDosDados(comando);

            int[] resultado = dice.DefineParametrosDaRolagem(comando);


            Console.WriteLine(dice.DefineQuantidadeDeDados(comando));
            Console.WriteLine(dice.Sides);

            foreach (var item in resultado)
            {
                Console.Write(item +" ");
            }




            Console.Read();
        }
    }
}
