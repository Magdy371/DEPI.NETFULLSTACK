using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class PrimeNumbers
    {
        public static string isPrime(int number)
        {
            if (number <= 1)
                return "false: not prime number";
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return "false: not prime number";
            }
            return "true: its is a prime number";
        }
    }
}
