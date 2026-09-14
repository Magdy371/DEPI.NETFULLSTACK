namespace LinqPrequsits
{
    internal static class MyMath
    {
        public static int Add(this int x, int y) => x + y;
        public static int Mirror(this int x)
        {
            //123 -> 321
            //var r = x.ToString().Split().Reverse();
            //OR
            int result = 0;
            while (x > 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }
            return result;
        }
    }
}