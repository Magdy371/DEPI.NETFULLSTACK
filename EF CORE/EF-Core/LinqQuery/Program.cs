using System.Collections;
using System.Collections.Generic;

namespace LinqQuery
{
#nullable enable
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * LINQ (Language Integrated Query)
             * LINQ provides IntelliSense and compile-time error checking.
             * LINQ Query Types:
             *  1- Object Collection (Array, List)
             *  2- LINQ to Dataset (ADO.NET - used for dealing with database)
             *  3- LINQ to XML (XML Documents) - XML is used to describe data
             *  4- LINQ to Entities (EF Core - ORM)
             *  5- LINQ to SQL (deprecated)
             *  6- LINQ to IQueryable (other data sources)
             */
            List<string> names = new List<string> { "Ahmed", "Sayed", "Magdy" };

            // Select names that start with 'm' using a foreach loop
            foreach (var name in names)
            {
                if (name.StartsWith("M", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(name);
                }
            }

            // Select name that starts with 'm' using LINQ
            var nameM = names.FirstOrDefault(n => n.StartsWith("M", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(nameM);

            // Initializing objects
            var inf = new Info { Name = "Ahmed", Description = "Senior Developer" };

            var infos = new List<Info>
            {
                inf,
                new Info { Name = "Rady", Description = "Director" },
                new Info("Magdy", "Senior Developer"),
                new Info("Menna", "Junior Developer")
            };

            var result = infos.FirstOrDefault(i => i.Name?.Contains("m", StringComparison.OrdinalIgnoreCase) == true);
            if (result != null)
            {
                Console.WriteLine($"Result is {result.Name}");
            }

            // LINQ query
            var fresult = from emp in infos
                          where emp.Name?.Contains("M", StringComparison.OrdinalIgnoreCase) == true
                          select emp; //Emp here for all properties

            foreach (var item in fresult)
            {
                Console.WriteLine($"Names containing 'M' letter are {item.Name}");
            }

            var oInfos = new List<Info>
            {
                inf,
                new Info { Name = "Ahmed", Description = "Senior Developer" },
                new Info { Name = "Magdy", Description = "CEO" }
            };

            Console.WriteLine($"INDEX NUMBER 2 IN THE LIST IS {infos[2].Name} --> {infos[2].Description}");
            foreach (var info in infos)
            {
                Console.WriteLine($"{info.Name} --> {info.Description}");
            }

            // Anonymous type does not require a blueprint (class)
            // Anonymous type is read-only
            //which means it cannot be assignned
            Console.WriteLine("Anonymus Type");
            var student = new {
                ID = 1, Name = "Magdy",
                Title = "Senior .NET Developer"
            };
            Console.WriteLine($"Student: ID = {student.ID}, Name = {student.Name}, Title = {student.Title}");

            var resultQuery2 = from emp in infos
                               where emp.Name?.Contains("M", StringComparison.OrdinalIgnoreCase) == true
                               select new { emp.Description, FullName = emp.Name };
            foreach (var item in resultQuery2)
            {
                Console.WriteLine($"Description of names contains m are {item.Description}-> {item.FullName}");
            }

            MineList<Product> querList = new MineList<Product>();
            querList.Add(new Product { Id = 1, name = "Imac" , unitprice = 30});
            querList.Add(new Product { Id = 2, name = "HMD", unitprice = 20 });
            querList.Add(new Product { Id = 3, name = "Motorola", unitprice = 25 });

            var mineListQuery = from ml in querList
                                where ml.unitprice < 30
                                select new { fPrice = ml.unitprice, pName = ml.name };
            foreach (var item in mineListQuery) 
            { 
                Console.WriteLine($"Product Name: {item.pName}, Price: {item.fPrice}"); 
            }
        }
    }

    class Info
    {
        public Info() { }

        public Info(string name, string title)
        {
            Name = name;
            Description = title;
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    /*
     * Each class introdice table
     * We using Object Relational Mapping
     */

    class Teacher
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? Description { get; set; } = string.Empty;
    }
    public class Product
    {
        public Product()
        {

        }
        public int Id { get; set; }
        public string? name { get; set; }
        public int unitprice { get; set; }
    }

    public class MineList <T> : IEnumerable<T>
    {

        List<T> t = new();
        public void Add(T r)
        {
           t.Add(r);
        }
        public IEnumerator<T> GetEnumerator() { return t.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return t.GetEnumerator(); }

    }
}
