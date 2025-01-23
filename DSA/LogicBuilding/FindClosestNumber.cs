using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    internal class FindClosestNumber
    {
        /*
         * Math.Abs() is a method in C# which is used to return the absolute value of a number.
         * n represent the closest number to m
         * m represents the number to which we have to find the closest number (division)
         */
        public static int closestNumber(int n, int m)
        {
            int q = n / m;
            int n1 = m * q;
            int n2 = (n * m) > 0 ? (m * (q + 1)) : (m * (q - 1));
            if (Math.Abs(n - n1) < Math.Abs(n - n2))
                return n1;

            // else n2 is the required closest number
            return n2;
        }
    }
}
