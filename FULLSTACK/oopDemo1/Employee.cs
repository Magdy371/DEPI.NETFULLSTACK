namespace oopDemo1
{
    /// <summary>
    /// Represents an employee with ID, Name, Job, Salary, and Title.
    /// </summary>
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public double Salary { get; set; }
        public string? Title { get; set; }

        //Default Constructor
        public Employee()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        /// <param name="id">The employee ID.</param>
        /// <param name="name">The employee name.</param>
        /// <param name="job">The employee job.</param>
        /// <param name="salary">The employee salary.</param>
        /// <param name="title">The employee title.</param>
        public Employee(int id, string? name, string? job, double salary, string? title)
        {
            Id = id;
            Name = name;
            Job = job;
            Salary = salary;
            Title = title;
        }

        /// <summary>
        /// Displays the employee information.
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Job: {Job}, Salary: {Salary}, Title: {Title}");
        }
    }
}