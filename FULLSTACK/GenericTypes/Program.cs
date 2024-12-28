namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of the generic class
            ClassInApplication<int> obj = new ClassInApplication<int>();
            obj.saveMyVar(10);
            Console.WriteLine(obj.getVar());

            ClassInApplication<string> obj2 = new ClassInApplication<string>();
            obj2.saveMyVar("Hello");
            Console.WriteLine(obj2.getVar());

            ClassInApplication<Employee> obj3 = new ClassInApplication<Employee>();
            obj3.saveMyVar(new Employee(1, "John", "Developer"));
            Console.WriteLine(obj3.getVar());

            ClassInApplication<Employee> obj4 = new ClassInApplication<Employee>();
            obj4.saveMyVar(obj4.myVar = new Employee(2, "Jane", "Manager"));
            Console.WriteLine(obj4.getVar());
        }
    }

    //Generic class
    public class ClassInApplication<T>
    {
        //Generic property
        public T myVar { get; set; }

        //Generic method
        public T getVar()
        {
            return myVar;
        }

        public void saveMyVar(T myVar) //Generic parameter
        {
            this.myVar = myVar;
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(){ }
        public Employee(int id, string name, string position)
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Position: {Position}";
        }
    }
}