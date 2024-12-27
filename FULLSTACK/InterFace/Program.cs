namespace InterFace
{
    internal class Program{
        /*
        interface is a reference type that is similar to a class. 
        It is a collection of abstract methods. 
        A class implements an interface, thereby inheriting the abstract methods of the interface.
        a class can multiple inherit from interfaces.
        a class can't inherit from multiple classes or abstracts.
        */
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Create();
            employee.Read();
            employee.Update();
            employee.Delete();
            employee.getName();
            employee.getAge();
            employee.name = "John";
            employee.age = 30;
            employee.getInfos();

            //pass by value vs pass by reference
            //pass by value: when you pass a value type as a parameter to a method, 
            //a new copy of the value is created.
            //pass by reference: when you pass a reference
            //type as a parameter to a method, a reference to the object is passed.
            #region pass by value vs pass by reference
            Employee emp2 = new Employee();
            emp2 = employee;
            emp2.name = "Doe";
            emp2.age = 40;
            employee.getInfos();

            EmployeeStruct empStruct = new EmployeeStruct();
            empStruct.FirstName = "John";
            empStruct.LastName = "Doe";
            empStruct.Address = "123 Main St";
            empStruct.City = "New York";
            empStruct.EmployeeInfos();

            EmployeeStruct empStruct2 = new EmployeeStruct();
            empStruct2 = empStruct;
            empStruct2.FirstName = "Jane";
            empStruct2.LastName = "Smith";
            empStruct2.Address = "456 Main St";
            empStruct2.City = "Los Angeles";
            empStruct.EmployeeInfos();
            #endregion
        }
    }
}