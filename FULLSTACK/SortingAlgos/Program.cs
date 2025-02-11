namespace SortingAlgos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sorting");
            int[] array = { 5, 3, 8, 4, 2, 7, 1, 6 };
            MergeSort.Sort(array);
            Console.WriteLine($"Sorted numbers {string.Join("||", array)}");

            string[] names = { "John", "Doe", "Jane", "Smith", "Alice", "Brown" };
            MergeSort.Sort(names);
            Console.WriteLine($"Sorted names {string.Join("^^", names)}");
        }
    }
}
