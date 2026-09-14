using System;
namespace numberOperation
{
    class Proogram
    {
        static void Main(String[] args)
        {
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            //
            double[] sophiaGrade = { 93, 87, 98, 95, 100 };
            double[] nicolasGrade = { 80, 83, 82, 88, 85 };
            double[] zahirahGrade = { 84, 96, 73, 85, 79 };
            double[] jeongGrade = { 90, 92, 98, 100, 97 };
            double sophiaGradeSum = sophiaGrade.Sum();
            double nicolasGradeSum = nicolasGrade.Sum();
            double zahirahGradeSum = zahirahGrade.Sum();
            double jeongGradeSum = jeongGrade.Sum();
            //Create dictionary
            var gradesMapper = new Dictionary<string, double>
            {
                {"Sophia", sophiaGradeSum},
                {"Nicolas",nicolasGradeSum},
                {"Zahirah",zahirahGradeSum},
                {"Jeong",jeongGradeSum},
            };
            //For Each loop
            foreach (var keys in gradesMapper)
            {
                Console.WriteLine($"{keys.Key}: {keys.Value}");
            }

            var assigneMentMapper = new Dictionary<string, int>
            {
                {"Sophia", sophiaGrade.Length},
                {"Nicolas",nicolasGrade.Length},
                {"Zahirah",zahirahGrade.Length},
                {"Jeong",jeongGrade.Length},
            };
            var gpaPercent = new Dictionary<string, char>{};
            foreach (var keys in gradesMapper)
            {
                char character = 'A';
                double gpaResult = keys.Value / assigneMentMapper[keys.Key];
                if(gpaResult >= 85)
                {
                    character = 'A';
                }else if(gpaResult >= 75 && gpaResult < 85)
                {
                    character = 'B';
                }else if(gpaResult >= 65 && gpaResult < 75)
                {
                    character = 'C';
                }else if(gpaResult >= 50 && gpaResult < 65)
                {
                    character = 'D';
                }else{
                    character = 'F';
                }
                gpaPercent.Add($"{keys.Key} : {gpaResult}",character);
            }
            foreach (var keys in gpaPercent)
            {
                Console.WriteLine($"{keys.Key}: {keys.Value}");
            }

            //
            //Random dice = new Random();//Correct one
            Random dice = new(); //Correct too
            int role = dice.Next(1,7);
            Console.WriteLine(role);
            // Find the largest between 2 numbers
            int firstValue = 40;
            int secondValue = 70;
            int largestValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largestValue);

        }
    }
}