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

            AccessModifiers obj = new AccessModifiers();
            obj.publicProperty = "Public Property Accessed";
            /*
            other access modifeirs cannot be accessed because
            1- Internal is out from the namespace
            2-Private is not in the same class
            3-private protected is not in the same calss or in heritance
            4-internal protected as it is not in the same name  space or inherited
            */
        }
        /*class access modifiers can not be other than public or internal*/
    }
}