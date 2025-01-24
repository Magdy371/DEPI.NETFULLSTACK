namespace BasicProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits.sumOfDigits(123));
            Console.WriteLine(SumDigits.sumOfDigitsIterative(123));
            Console.WriteLine(SumDigits.sumOfDigits("123"));
            Console.WriteLine("--------------Prime Number checking--------------");
            Console.WriteLine(PrimeNumbers.isPrime(5));
        }
    }
}
