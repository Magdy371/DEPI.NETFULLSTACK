using System.Reflection.Metadata.Ecma335;

namespace LinqPrequsits
{
    class Program
    {
        static void Main(string[] arg)
        {

            #region implicit typed variable
            var variable1 = 5; // it becomes int
            Console.WriteLine($"type of variable1: {variable1.GetType()}");
            //this will throw an ERROR
            //variable1 = "Magdy";// CannotUnloadAppDomainException convert int to string
            object variable2 = 5; // it becomes int
            Console.WriteLine($"type of variable2: {variable2.GetType()}");
            variable2 = "Magdy";
            Console.WriteLine($"type of variable2: {variable2.GetType()}");
            #endregion

            #region anonymousType
            Employee emp1 = new() { Id = 1, Name = "Magdy Elshrief", Salary = 45000.443f };
            // anonymous type is a class that is created by the compiler at compile time, and it has no name.
            //  It is used to create objects that have a set of properties without having to define a class for them.
            var e2 = new { Id = 2, Name = "Ahmed", Salary = 50000.443f };
            Console.WriteLine($"type of e2: {e2.GetType()}");
            Console.WriteLine($"e2: {e2.Id}, {e2.Name}, {e2.Salary}");
            /**
                *  Note: Anonymous types are immutable, meaning that their properties cannot be changed after they are created.
                *  This is because the compiler generates a class for the anonymous type with read-only properties.
                *  If you need to create an object with mutable properties, you should define a class for it instead of using an anonymous type.
            */
            //this example will throw an ERROR
            //e2.Id = 3; // CannotUnloadAppDomainException
            //C# compiler generates a class for the anonymous type with read-only properties.
            // Anonymous types override the Equals and GetHashCode methods to provide value-based equality comparison.
            var e3 = new { Id = 2, Name = "Ahmed", Salary = 50000.443f };
            Console.WriteLine($"e2.Equals(e3): {e2.Equals(e3)}"); // true
            Console.WriteLine($"e2.GetHashCode(): {e2.GetHashCode()}");
            Console.WriteLine($"e3.GetHashCode(): {e3.GetHashCode()}");
            #endregion

            #region extension methods
            /*
             * Extension methods are a way to add new methods to existing types
             * without modifying the original type or creating a new derived type.
             * They are defined as static methods in a static class, and they use the "this" keyword
            */
            Console.WriteLine($"Add(5, 10): {MyMath.Add(5, 10)}");
            //Extention Example
            int x = 1235;
            int y = 10;
            Console.WriteLine($"x.Add(y): {x.Add(y)}");
            Console.WriteLine($"x.Mirror(): {x.Mirror()}");
            #endregion

            #region deligtes
            //Deligates are a type that represents references to methods with a specific parameter list and return type.
            //Action deligate used to have address no return type method with no parameters
            Action a1 = ()=>{Console.WriteLine("Hello from Action delegate");};
            a1(); // or a1.Invoke();
            //Action<T> deligate used to have address no return type method with parameters and reach to 16 parameters
            Action<int> a2 = (r)=>  Console.WriteLine($"Hello from Action<int> delegate with parameter: {r}");
            a2(5); // or a2.Invoke(5);
            Action<int, int> a3 = (r1, r2)=>  Console.WriteLine($"Hello from Action<int, int> delegate with parameters: {r1}, {r2}");
            a3(5, 10); // or a3.Invoke(5, 10)

            //Create Your own deligates method when the function retirn data
            //1- there is no input parameter
            //Func<int>
            //2-There is input and output parameter always the last type is the type of output parameter
            // Can be used to 16 input parameter
            Func<int, float, double> f1 = (a, b)=> { 
                double s = a * b;
                return s;
            };
            Console.WriteLine($"f1(5, 10): {f1(5, 10)}");
            //3- Predicate deligate used to have address boolean method with one parameter
            Predicate<int> p1 = (a)=> { return a > 0; };
            Console.WriteLine($"p1(5): {p1(5)}");
            Console.WriteLine($"p1(-5): {p1(-5)}");
            #endregion
        }
    }
}