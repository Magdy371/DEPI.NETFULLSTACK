namespace classType
{
#nullable disable
    internal class Program
    {
        public static void Main(string[] args)
        {
            // AbstractClass abstractClass = new AbstractClass(); // Error: Cannot create an instance of the abstract class or interface 'AbstractClass'
            // abstractClass.AbstractMethod(); // Error: 'AbstractClass' does not contain a definition for 'AbstractMethod' and no accessible extension method 'AbstractMethod' accepting a first argument of type 'AbstractClass' could be found (are you missing a using directive or an assembly reference?)
            // #region abstract
            // Employee employee = new Employee();
            // int salary = 10000;
            // double income = employee.Income(salary);
            // System.Console.WriteLine($"Employee's income is {income}");
            // employee.Name = "John Doe";
            // employee.Age = 30;
            // employee.getInfo(employee.Name, employee.Age);
            // #endregion

            #region override
            Tster tster = new Tster();
            tster.Display();
            #endregion
        
            #region virtual

            /*
            * The virtual keyword is used to modify a method, property, indexer, or event declaration 
                and allow for it to be overridden in a derived class.
            * The virtual keyword is used to modify a method, property, indexer, or event declaration
            new keyword is used to hide a method, property, indexer, or event of a base class in a derived class.
            */
            Product product = new Product();
            System.Console.WriteLine($"Product price is {product.getPrice()}");
            Imac imac = new Imac();
            System.Console.WriteLine($"Imac price is {imac.getPrice()}");
            Macbook macbook = new Macbook();
            System.Console.WriteLine($"Macbook price is {macbook.getPrice()}");
            Iphone iphone = new Iphone();
            System.Console.WriteLine($"Iphone price is {iphone.getPrice()}");
            #endregion



        }
    }
    public class Tster : testOverride
    {
        public override void Display()
        {
            base.Display();
        }
    }

    public class Product
    {
        public virtual double getPrice()
        {
            return 1000;
        }
    }
    public class Imac : Product
    {
        public override double getPrice()
        {
            return base.getPrice() + 50000;
        }
    }
    public class Macbook : Imac
    {
        public new double getPrice()
        {
            return base.getPrice() + 30000;
        }
    }
    public class Iphone : Macbook
    {
        public new double getPrice()
        {
            return base.getPrice() + 20000;
        }
    }

}