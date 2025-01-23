using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class SumDigits
    {
        //using recursion
        public static int sumOfDigits(int number)
        {
            if (number == 0)
                return 0;
            return number % 10 + sumOfDigits(number / 10);
        }
        // using iterative approach
        public static int sumOfDigitsIterative(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
