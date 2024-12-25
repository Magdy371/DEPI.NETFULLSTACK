namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                catch (System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                System.Console.WriteLine("Do you want to continue? y/n");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "y");
        }

        private static int GetNumberFromUser(string prompt)
        {
            int number;
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please try again.");
                }
            }
            return number;
        }
    }
}
