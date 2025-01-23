using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuilding
{
    internal class IsEven
    {
        public string isEvenReminder(int n)
        {
            if (n % 2 == 0)
                return "Even";
            return "odd";
        }
        public string isEvenBitwise(int n)
        {
            if ((n & 1) == 0)
                return "Even number";
            return "odd number";
        }


    }
}
