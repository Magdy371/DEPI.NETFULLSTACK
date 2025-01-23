namespace LogicBuilding
{
    internal class Swapping
    {
        //1- Naive approach using third variable
        public static void Swapp(int n1 , int n2) 
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine($"n1: {n1}, n2: {n2}");
        }
        //we will use bitwise operator xor
        public static void SwappBitWise(int n1 , int n2)
        {
            n1 = n1 ^ n2;
            n2 = n1 ^ n2;
            n1 = n1 ^ n2;
            Console.WriteLine($"n1: {n1}, n2: {n2}");
        }
    }
}
