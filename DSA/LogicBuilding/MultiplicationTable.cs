namespace LogicBuilding
{
    internal class MultiplicationTable
    {
        //this is overloading
        public static void itsTable(int n)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }

        public static void itsTable(int n , int i)
        {
            if (i == 11 )
                return;
            Console.WriteLine(n + " * " + i + " = " + n * i);
            i++;
            itsTable(n, i);
        }
    }
}
