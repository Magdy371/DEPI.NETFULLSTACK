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
            Manager m = new Manager();
            m.age = 1;
            m.name = "Test";
            m.getInfos();
            Outer outer = new Outer();
            Outer.Inner inner = new Outer.Inner();
            inner.Print();
            outer.Print();


        }
    }
}