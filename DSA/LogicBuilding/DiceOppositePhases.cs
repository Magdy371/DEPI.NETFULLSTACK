using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    internal class DiceOppositePhases
    {
        public static void OppositeFaceOfDice(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(6);
            }
            else if (n == 2)
            {
                Console.WriteLine(5);
            }
            else if (n == 3)
            {
                Console.WriteLine(4);
            }
            else if (n == 4)
            {
                Console.WriteLine(3);
            }
            else if (n == 5)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
