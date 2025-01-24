using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class NumberPowerCheck
    {
        public static bool isPower(int x, int y)
        {
            double res1 = Math.Log(y) / Math.Log(x);

            // Note : this is double 
            double res2 = Math.Log(y) / Math.Log(x);
            return (res1 == res2);

        }
    }
}
