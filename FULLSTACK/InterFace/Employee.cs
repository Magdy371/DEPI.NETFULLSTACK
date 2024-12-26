namespace InterFace
{
    public class Employee :Person, IOperationCRUD, IPerson
    {
        public string name { get; set; }
        public int age { get; set; }
        public void Create()
        {
            // Implementation for creating an employee
            Console.WriteLine("Employee created.");
        }

        public void Read()
        {
            // Implementation for reading an employee
            Console.WriteLine("Employee details.");
        }

        public void Update()
        {
            // Implementation for updating an employee
            Console.WriteLine("Employee updated.");
        }

        public void Delete()
        {
            // Implementation for deleting an employee
            Console.WriteLine("Employee deleted.");
        }
        public void getName()
        {
            // Implementation for getting name of an employee
            Console.WriteLine("Employee name.");
        }
        public void getAge()
        {
            // Implementation for getting age of an employee
            Console.WriteLine("Employee age.");
        }
        public override void getInfos()
        {
            System.Console.WriteLine("Employee name: {0}, Employee age: {1}", name, age);
        }
    }
}