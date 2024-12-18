using System.Text;

namespace Module1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region lesson1
            #region DataTypeCasting
            var price = 50;
            Console.WriteLine($"price is {price}");
            price = 100;
            Console.WriteLine($"price is {price}");
            //IMPLICIT CASTING
            int a = 10;
            long b = 1000000;
            b = a;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            //EXPLICIT CASTING
            int c = 10;
            long d = 1000000;
            c = (int)d;
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(c);
            #endregion

            //Converting types
            #region usingSystem.ConvertClass
            string possibleInt = "123";
            int count = int.Parse(possibleInt);
            long numberConverted = Convert.ToInt64(possibleInt);
            Console.WriteLine("The String converted by int.Parse " + count + " Its type is " + count.GetType());
            Console.WriteLine("The String converted by Convert.ToInt64 " + numberConverted + " Its type is " + numberConverted.GetType());
            //Using TryParse
            int number = 0;
            string StringNumber = "453466636";
            if (int.TryParse(StringNumber, out number))
            {
                Console.WriteLine("Conversion succeeded");
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
            Console.WriteLine($"The new value of number is {number}");
            #endregion

            //String manipulation
            #region StringManipulation
            /*
             * Concatenating multiple strings in Visual C# is 
             * simple to achieve by using the + operator. 
             * However, this is considered bad coding practice 
             * because strings are immutable. This means that 
             * every time you concatenate a string, you create a 
             * new string in memory and the old string is 
             * discarded.
             */

            string address = "23";
            address = address + ", Main Street";
            address = address + ", Buffalo";
            Console.WriteLine($"The final address result {address}");

            //The best practice is to use string builder class

            StringBuilder addrss = new StringBuilder();
            addrss.Append("23");
            addrss.Append(", Main Street SanPaolo");
            addrss.Append(", Northania Santana");
            Console.WriteLine($"the new address is {addrss}");
            #endregion
            #endregion

            #region lesson2



            #endregion
        }
    }
}
