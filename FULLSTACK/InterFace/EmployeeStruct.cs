namespace InterFace
{
    public struct EmployeeStruct
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public void EmployeeInfos()
        {
            System.Console.WriteLine($"you full infos are: {FirstName} {LastName} {Address} {City}");
        }
        //pass by value vs pass by reference
    }
}