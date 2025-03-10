namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Person1 = new Person { Id = 1, Name = "Magdy", Age = 25 };
            var Person2 = new Person { Id = 2, Name = "Mohamed", Age = 22 };
            Console.WriteLine($"Person1: Name->{Person1.Name} Age->{Person1.Age}");
            Console.WriteLine($"Person2: Name->{Person2.Name} Age->{Person2.Age}");
            Swap(ref Person1, ref Person2);
            Console.WriteLine($"S.Person1: Name->{Person1.Name} Age->{Person1.Age}");
            Console.WriteLine($"S.Person2: Name->{Person2.Name} Age->{Person2.Age}");


            int x = 10, y = 70;
            Console.WriteLine("Before Swapping x = {0} and y = {1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("After Swapping x = {0} and y = {1}", x, y);

            //Object Serialize
            string jsonPerson = @"{
            ""Id"":0 , 
            ""Name"":""Matt"",
            ""Age"":50
            }";
            Console.WriteLine("Desacralizing jsonPerson");
            var PJ = System.Text.Json.JsonSerializer.Deserialize<Person>(jsonPerson);
            Console.WriteLine($" {PJ?.Name} , {PJ?.Age}");

            Console.WriteLine("Generic example");
            Nullable<int> n = new Nullable<int>(5);
            Console.WriteLine($"n value: {n.GetValueOrDefault()}");

            Console.WriteLine("=====Mapper=====");
            var customer  = new Customer { Id = 1, Name = "Magdy", Age = 25 };
            var mapper = new CustomerToPersonMapper();
            var person = mapper.Map(customer);
            Console.WriteLine($"after Mapping Id:{person.Id}, Name: {person.Name}, Age: {person.Age}");
        }
        public static void Swap<T>(ref T ele1 , ref T ele2)
        {
            T temp = ele2;
            ele2 = ele1;
            ele1 = temp;
        }
    }
}
