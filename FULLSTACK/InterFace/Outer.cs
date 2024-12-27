using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    public class Outer
    {
        public Outer() { }
        public void Print()
        {
            Console.WriteLine("you are in the outer class");
        }
        public class Inner
        {
            public Inner() { }
            public void Print()
            {
                Console.WriteLine("You are in inner class");
            }
        }
    }
}
