namespace conditionLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new();
            int rol1 = dice.Next(1, 7);
            int rol2 = dice.Next(1, 7);
            int rol3 = dice.Next(1, 7);
            int total = rol1 + rol2 + rol3;
            Console.WriteLine($"Dice roll: {rol1} + {rol2} + {rol3} = {total}");
            if ((rol1 == rol2) || (rol2 == rol3) || (rol1 == rol3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
            else if ((rol1 == rol2) && (rol2 == rol3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("No bonus today!:(");
            }


            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }

            string message = "The quick brown fox jumps over the lazy dog.";
            bool result = message.Contains("quick");
            if (result)
            {
                Console.WriteLine("the message contains the word quick");
            }
            else
            {
                Console.WriteLine("the message does not contain the word quick");
            }
        }
    }
}