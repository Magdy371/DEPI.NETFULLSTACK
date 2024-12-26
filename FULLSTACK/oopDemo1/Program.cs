// See https://aka.ms/new-console-template for more information
namespace oopDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            opp Concepts
            1-Class and Object is instance from the calss
            2-Encapsulation: is the process of wrapping code and data together into a single unit
            3-Inheritance: is a mechanism in which one object acquires all the properties and behaviors of a parent object
            4-Polymorphism: is the ability of an object to take on many forms
            5-Abstraction: is the concept of object-oriented programming that "shows" only essential attributes and "hides" unnecessary information
            */
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "Ahmed";
            emp1.Job = "Developer";
            emp1.Salary = 1000;
            emp1.Title = "Senior";
            emp1.DisplayEmployeeInfo();
        }
    }
}
