namespace oopDemo1
{

    public class Employee
    {
        // Static field to keep track of the last assigned ID
        private static int lastId = 0;

        // Fields
        private int id;
        private string? name;
        private string? job;
        private double salary;
        private string? title;


        // Properties: Encapsulation
        public int Id
        {
            get { return id; }
        }

        public string? Name
        {
            get => name;
            set => name = value;
        }

        public string? Job
        {
            get => job;
            set => job = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public string? Title
        {
            get => title;
            set => title = value;
        }

        // Default Constructor
        public Employee()
        {
            id = ++lastId;
        }

        public Employee(string? name, string? job, double salary, string? title)
        {
            id = ++lastId;
            Name = name;
            Job = job;
            Salary = salary;
            Title = title;
        }
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Job: {Job}, Salary: {Salary}, Title: {Title}");
        }
        public string NetSalary(double overtime, double tax)
        {
            double finalSalary = Salary + overtime - tax;
            return $"{Name}'s final salary is {finalSalary:C2}";
        }
    }
}
