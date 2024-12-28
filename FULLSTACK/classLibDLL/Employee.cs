namespace classLibDLL
{
    public class Employee
    {
        public Employee()
        {
            AcceesModifeirs obj = new AcceesModifeirs();
            obj.publicProperty = "Public Property Accessed";
            obj.internalProperty = "Internal Property Accessed";
            obj.InternalProtectedProperty = "Internal Protected Property Accessed";
            // obj.privateProperty = "Private Property Accessed"; // Error
            // obj.protectedProperty = "Protected Property Accessed"; // Error("require inheritance")
        }

        public double sum(double a, double b)
        {
            return a + b;
        }
        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }

    }
#nullable disable
    public class AcceesModifeirs
    {
        public string publicProperty { get; set; }
        private string privateProperty { get; set; }
        protected string protectedProperty { get; set; }
        internal string internalProperty { get; set; }
        internal protected string InternalProtectedProperty { get; set; }
        private protected string PrivateProtectedProperty { get; set; }

    }
    public class SubClass : AcceesModifeirs
    {
        public SubClass()
        {
            publicProperty = "Public Property Accessed";
            InternalProtectedProperty = "Internal Protected Property Accessed";
            PrivateProtectedProperty = "Private Protected Property Accessed";
            internalProperty = "Internal Property Accessed";
            protectedProperty = "Protected Property Accessed"; 
            //privateProperty = "Private Property Accessed"; // Error
        }
    }
}