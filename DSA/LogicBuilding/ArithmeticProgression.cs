using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    internal class ArithmeticProgression
    {
        /*
         * A sequence of numbers is called an Arithmetic progression if the 
         * difference between any two consecutive terms is always the same.
         * Notation in Arithmetic Progression
         *In AP, there are some main terms that are generally used, which are denoted as:
         *Initial term (a): In an arithmetic progression, the first number in the series is called the initial term.
         *Common difference (d): The value by which consecutive terms increase or decrease is called the common difference. The behavior of the arithmetic progression depends on the common difference d. If the common difference is: positive, then the members (terms) will grow towards positive infinity or negative, then the members (terms) will grow towards negative infinity.
         *nth Term (an): The nth term of the AP series
         *Sum of the first n terms (Sn): The sum of the first n terms of the AP series.
         *
         *a(n) = a(1) + (n-1) * d 
         * S(n) = n/2[2a + (n - 1) * d]
         */
        public static string progressionCheck(int[] arr , int n)
        {
            if(n == 1)
                return "true";
            Array.Sort(arr);
            int d = arr[1] - arr[0];
            for (int i = 2; i < n; i++)
                if (arr[i] - arr[i - 1] != d)
                    return "not Arithmatic progression";

            return "Arithmatic progression";
        }
    }
}
