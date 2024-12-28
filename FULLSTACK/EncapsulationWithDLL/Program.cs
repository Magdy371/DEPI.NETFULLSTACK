using classLibDLL;
namespace EncapsulationWithDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            Employee em = new Employee();
            System.Console.WriteLine(em.sum(a,b));
            System.Console.WriteLine(em.subtract(a,b));
            System.Console.WriteLine(em.multiply(a,b));
            System.Console.WriteLine(em.divide(a,b));

        }
    }
}