using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    internal class SumNaturalNumber
    {
        public static int seriesSum(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            Console.WriteLine("The all numbers sum is: ");
            return result;
        }
        //we can use induction formula (n*(n+1))/2
        public static int seriesSumInduction(int n)
        {
            return (n * (n + 1)) / 2;
        }
    }
}
