using System;
using System.Collections.Generic;
using System.Linq;
namespace gpaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentCourses = new HashSet<string> { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
            int[] creditHours = [3, 3, 4, 4, 3];
            float[] studentGrades = [4, 3, 3, 3, 4];
            var studentMaterialInfos = new Dictionary<string, int> { };
            for (int i2 = 0; i2 < creditHours.Length; i2++)
            {
                studentMaterialInfos.Add(studentCourses.ElementAt(i2), creditHours[i2]);
            }
            foreach (var keys in studentMaterialInfos)
            {
                Console.WriteLine($"{keys.Key} : {keys.Value}");
            }
            string studentName = "Marwa";
            Console.WriteLine($"Student Name: {studentName}");
            var studentGradeInfo = new Dictionary<string, float> { };
            int i = 0;
            foreach (var keys in studentMaterialInfos)
            {
                studentGradeInfo.Add($"{keys.Key} : {keys.Value}  ", studentGrades[i]);
                i++;
            }
            foreach (var keys in studentGradeInfo)
            {
                Console.WriteLine($"{keys.Key} :   {keys.Value}");
            }
            float totalGradePoints = creditHours.Zip(studentGrades, (credits, grade) => credits * grade).Sum();
            float totalCreditHours = creditHours.Sum();
            float gpa = totalGradePoints / totalCreditHours;
            Console.WriteLine($"GPA: {gpa:F2}");


        }
    }
}