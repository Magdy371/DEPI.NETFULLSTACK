namespace InterFace
{
    internal class Program{
        /*
        interface is a reference type that is similar to a class. 
        It is a collection of abstract methods. 
        A class implements an interface, thereby inheriting the abstract methods of the interface.
        a class can multiple inherit from interfaces.
        a class can't inherit from multiple classes or abstracts.
        */
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Create();
            employee.Read();
            employee.Update();
            employee.Delete();
            employee.getName();
            employee.getAge();
            employee.name = "John";
            employee.age = 30;
            employee.getInfos();
        }
    }
}