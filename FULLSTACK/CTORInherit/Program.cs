namespace CTORInherit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human("Saratoby Doe", 30);
            human.Speak();
            Employee employee = new Employee("John Doe", 30, 10000);
            employee.Speak();
            System.Console.WriteLine(human.Name);
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine("Human constructor called");
        }

        public void Speak()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
    public class Employee : Human
    {
        public int Salary { get; set; }

        public Employee(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }
}