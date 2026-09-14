using System;
namespace literalDemos
{
    class Proogram
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World !");
            Console.WriteLine('b');
            //this will case an error because if it excapculated in character quotes
            //Console.WriteLine('Hello World!');

            Console.WriteLine(123);
            //Create a float literal by appending F as float
            Console.WriteLine(0.25F);
            //Create a decimal literal by appending m as decimal
            Console.WriteLine(12.39816m);

            //Boolean Literals
            Console.WriteLine(true);
            Console.WriteLine(false);

            //Declaring variable
            string firstName = "Magdy Mohamed Gaber Elshrief";
            Console.WriteLine($"My name is {firstName}");

            //Inferring variables must be intialzed
            var message = "Hello to dotnet operations";
            Console.WriteLine($"Operational messaage: {message}");

            // Combine strings using string interpolation
            Console.WriteLine($"{message} {firstName}");
            //Combine verbatim literals and string interpolation
            /**
             * In C#, a verbatim string literal is defined by prefixing the string with an @ symbol
             * (e.g., @"text").  This tells the compiler to interpret the content exactly as written,
             *  ignoring standard escape sequences like \n (newline) or \t (tab), which allows backslashes to be used literally.
             */
            string projectName = "firstProject";
            Console.WriteLine($@"C:\Output\{projectName}");
        }
    }
}