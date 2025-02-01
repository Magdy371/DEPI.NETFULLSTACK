namespace LINQSub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new List<Products>
            {
                new Products { Name = "Laptop", Price = 1000 },
                new Products { Name = "Mobile", Price = 500 },
                new Products { Name = "Tablet", Price = 700 },
                new Products { Name = "Smart Watch", Price = 300 },
                new Products { Name = "Headphone", Price = 200 }
            };
            Console.WriteLine("-----Result Query-----");
            //Query Syntax Sugar
            var queryResult = from p in product
                              where p.Price > 500
                              select p;
            foreach (var item in queryResult)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
            Console.WriteLine("-----Syntax Query-----");

            //method syntax Lambda Expression
            var methodResult = product.Where(p => p.Price < 500);
            foreach (var item in methodResult)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
        }
    }
}
