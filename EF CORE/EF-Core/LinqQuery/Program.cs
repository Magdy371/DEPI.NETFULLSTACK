namespace LinqQuery
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Linq is language IntegratedQuery
             * Linq provide intellisense and compile time error checking
             * Linq Query Types:
             *  1- Object Collection=>(Array , list)
             *  2- Linq to dataset (Ado.net =>used for dealing with database)
             *  3- Linq to XML (XML Documents) => xml used to describe data
             *      XML IS Media Data Source
             *  4- Linq to Entities EF CORE (ORM)
             *  5- Linq to SQL depricated
             *  6- Linq to IQueryable (other data sources)
             */
            List<string> names = new List<string>();
            names.Add("Ahmed");
            names.Add("Sayed");
            names.Add("magdy");

            //Select name that stars with m
            foreach(var name in names)
            {
                if(name.StartsWith("m"))
                {
                    Console.WriteLine(name);
                }
            }
            //Select name that stars with m with linq
            //Linq to object
            var nameM = names.Where(names => names.StartsWith("m")).First();
            Console.WriteLine(nameM);

            //how to intialize object
            //cannot be done without default constructor
            Info inf = new Info() { name = "Ahmed", description = "Senior developer" };

            List<Info> infos = new List<Info>();
            infos.Add(inf);
            infos.Add(new Info() { name = "Rady", description = "director" });
            infos.Add(new Info("Magdy", "Senior Developer"));
            infos.Add(new Info("Menna", "Jonior Developer"));

            List<Info> oInfos = new List<Info> 
            { 
                inf,
                new Info() { name = "Ahmed", description = "Senior developer" },
                new Info() { name = "Magdy", description = "CEO" }
            };

            Console.WriteLine($"INDEX NUMBER 2 IN THE LIST IS {infos[2].name} --> {infos[2].description}");
            foreach (var info in infos)
            {
                Console.WriteLine($"{info.name} --> {info.description}");
            }

        }
    }
    class Info
    {
        public Info()
        {
            
        }
        public Info(string name , string title)
        {
            this.name = name;
            description = title;
        }
        public string? name { get; set; }
        public string? description { get; set; }
    }
}