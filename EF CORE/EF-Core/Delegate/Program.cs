using System;

namespace Delegate
{
    internal class Program
    {
        // Generic delegate to say hello
        public delegate void SayHelloHandler<T>(T item);

        // Delegate for checking predicate
        public delegate void CheckPredicate<T>(Func<T, bool> predicate, T[] items);

        // Reference type which can be a data type
        public delegate bool MyDelegate<T>(T item);

        static void Main(string[] args)
        {
            // Creating and invoking the SayHello delegate
            SayHelloHandler<string> say = new SayHelloHandler<string>(SayHello);
            say("Ahmed");

            #region CheckNumbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Even Numbers:");
            CheckPredicate<int> check = new CheckPredicate<int>(CheckItems);
            check(x => x % 2 == 0, numbers);

            Console.WriteLine("Numbers > 5:");
            check(x => x > 5, numbers);

            CheckPredicate<string> check2 = new CheckPredicate<string>(CheckItems);
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };
            Console.WriteLine("Names with length greater than 3:");
            check2(name => name.Length > 3, names);
            #endregion

            #region Numbers
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Even numbers:");
            FilterItems<int>(n => n % 2 == 0, arr);

            Console.WriteLine("Odd numbers:");
            FilterItems<int>(n => n % 2 != 0, arr);
            #endregion
        }

        // Generic method to filter items based on a predicate
        private static void CheckItems<T>(Func<T, bool> predicate, T[] items)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Generic method to filter items using a custom delegate
        public static void FilterItems<T>(MyDelegate<T> check, T[] items)
        {
            foreach (var item in items)
            {
                if (check(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Method to print a greeting message
        private static void SayHello<T>(T item)
        {
            Console.WriteLine($"Hello {item}");
        }
    }
}
