namespace ENUMS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Enums are strongly typed constants. 
            //They are implicitly convertible to int. 
            //In this example, we have a list of days of the week.
            //We can use enums to represent the days of the week.
            #region Enums
            Days day = Days.Monday;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
            #endregion

            Employee empl = new Employee();
            empl.Name = "John";
            empl.Age = 30;
            empl.salary = SalaryType.FullTime;
            empl.role = EmployeeType.Director;
            System.Console.WriteLine($"Employee Infos: {empl.getInfos()}");
            empl.netSalary();
        }
    }
    public enum Days
    {
        Monday = 1,
        Tuesday ,
        Wednesday ,
        Thursday ,
        Friday ,
        Saturday ,
        Sunday 
    }
    public enum SalaryType{
        FullTime = 0,
        PartTime,
        Freelance,
        Contract
    }
    public enum EmployeeType{
        Employee = 0,
        Manager,
        Director,
    }
    public class Employee{
        public string? Name { get; set; }
        public int Age { get; set; }
        public SalaryType salary { get; set; }
        public EmployeeType role { get; set; }

        public string getInfos(){
            return $"Name: {Name}, Age: {Age}, Salary Type: {salary}, Employee Type: {role}";
        }
        public void netSalary()
        {
            switch (role)
            {
                case EmployeeType.Employee:
                    System.Console.WriteLine("between 1000 and 2000");
                    break;
                case EmployeeType.Manager:
                    System.Console.WriteLine("between 2000 and 3000");
                    break;
                case EmployeeType.Director:
                    System.Console.WriteLine("between 3000 and 4000");
                    break;
                default:
                    break;
            }
        }
    }

}