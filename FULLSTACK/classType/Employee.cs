namespace classType
{
    #nullable disable
    public class Employee : Person
    {
        private double _salary;
        private string _name;
        private int _age;

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value;
        }
       public override double Income(double salary)
       {
            this.Salary = salary;
            return salary;
       }
       public override void getInfo(string Name , int age)
       {
           this.Name = Name;
           this.Age = age;
           System.Console.WriteLine($"Employee's name is {Name} and age is {age}");
       }
    }
}