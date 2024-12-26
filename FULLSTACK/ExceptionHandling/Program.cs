namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try Catch
            string answer;
            do
            {
            try
            {
                int i = GetNumberFromUser("Enter a number: ");
                int j = GetNumberFromUser("Enter another number: ");
                int result = i / j;
                Console.WriteLine($"{i} divided by {j} is {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in a correct format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block is always executed.");
            }
            Console.WriteLine("Do you want to continue? y/n");
            answer = Console.ReadLine();
            } while (answer.ToLower() == "y");
            #endregion
           
            #region Raise Exception
            try
            {
                Console.WriteLine("Enter your first name: ");
                string? firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                string? lastName = Console.ReadLine();
                Console.WriteLine($"Your full name is {FullName(firstName, lastName)}");
            }
            catch (Exception ex)
            {
                
                System.Console.WriteLine(ex.Message);
            }
            #endregion

        }

        private static int GetNumberFromUser(string prompt)
        {
            int number;
            while (true)
            {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.WriteLine($"'{input}' is not a valid number. Please try again.");
            }
            }
            return number;
        }

        private static string FullName(string? fn , string? ln)
        {
            if (string.IsNullOrWhiteSpace(fn) || string.IsNullOrWhiteSpace(ln))
            {
                throw new ArgumentException("First name and last name cannot be empty or whitespace.");
            }
            if (!fn.Any(char.IsLetter) || !ln.Any(char.IsLetter))
            {
                throw new ArgumentException("First name and last name must contain at least one letter.");
            }
            return $"{fn.Trim()} {ln.Trim()}";
        }
    }
}
