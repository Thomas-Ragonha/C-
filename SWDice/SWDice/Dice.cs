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
    }
}
