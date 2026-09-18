namespace records;

public class Program
{
    //This record will create a class with two properties Name and Age,
    //and will create a constructor that takes two parameters Name and Age,
    // and will create a deconstructor that takes two parameters Name and Age, 
    // and will create a ToString method that returns the string representation of the object,
    // and will create an Equals method that compares two objects of the same type, 
    // and will create a GetHashCode method that returns the hash code of the object.
    public record Persona(string Name, int Age);
    //This is the same as above
    /**
    public record Person
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    */
    #region record class
    // Reference type Like persona record we created above
    public record Student(string Name, int Age);
    //1- Stored in the heap memory
    //2- Can be null
    //3- Can be inherited
    //4- Reference type
    //5- Value-based Equality
    #endregion

    #region record struct
    public record struct StudentStruct(string Name, int Age);
    //1- Stored in the stack memory
    //2- Cannot be null
    //3- Cannot be inherited
    //4- Value type
    //5- Value-based Equality
    #endregion
    public static void Main(string[] args)
    {
        Person p = new();
        int age = p.Age = 28;
        string name = p.Name = "Magdy";
        Console.WriteLine($"Name: {name}, Age: {age}");
        var p1 = new Person { Name = "John", Age = 25 };
        var p2 = new Person { Name = "John", Age = 25 };
        Console.WriteLine($"p1 == p2: {p1 == p2}"); // False
        var p0 = new Persona("John", 25);
        var p3 = new Persona("John", 25);
        Console.WriteLine($"p0 == p3: {p0 == p3}"); // True
        Console.WriteLine($"p0: {p0}"); // p0: Persona { Name = John, Age = 25 }
        Console.WriteLine($"p1: {p1}"); // p1: records.Person
        //Record With Expression
        var p4 = p0 with { Age = 30 };
        Console.WriteLine($"p4: {p4}"); // p4: Persona { Name = John, Age = 30 }

        #region Record Struct
        var s1 = new StudentStruct("Alice", 20);
        var s2 = s1 with { Age = 21 };
        Console.WriteLine($"s1: {s1}"); // s1: StudentStruct { Name = Alice, Age = 20 }
        Console.WriteLine($"s2: {s2}"); // s2: StudentStruct { Name = Alice, Age = 21 }
        #endregion

        #region Record Class
        //1- Can be null
        //Example: of can be null
        Student? student1 = null;
        Student student2 = new Student("Bob", 22);
        student1 = student2 with { Age = 23 }; // Create a new instance with modified Age
        Console.WriteLine($"student1: {student1}"); // student1: Student { Name = Bob, Age = 23 }
        Console.WriteLine($"student2: {student2}"); // student2: Student { Name = Bob, Age = 22 }

        #endregion
    }
}