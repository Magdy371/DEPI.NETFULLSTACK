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
            Console.WriteLine("--------------Power Number checking--------------");
            Console.WriteLine(NumberPowerCheck.isPower(10, 1) ? "true" : "false");
            Console.WriteLine(NumberPowerCheck.isPower(1, 20) ? "true" : "false");
            Console.WriteLine(NumberPowerCheck.isPower(2, 128) ? "true" : "flase");
        }
    }
}
