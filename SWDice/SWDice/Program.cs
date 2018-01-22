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
            int sides;
            if (int.TryParse(Console.ReadLine(), out sides))
            {
                Dice dice = new Dice(sides);
                Console.WriteLine(dice.Sides);
            }
            else
            {
                Console.WriteLine("Inválido!");
            }

            Console.Read();
        }
    }
}
