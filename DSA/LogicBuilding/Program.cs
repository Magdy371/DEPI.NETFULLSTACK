namespace LogicBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsEven even = new IsEven();
            Console.WriteLine(even.isEvenBitwise(56));
            Console.WriteLine("-----------Tabele  number iterative-------------------\n");
            MultiplicationTable.itsTable(6);
            Console.WriteLine("-----------Table number recursive -------------------\n");
            MultiplicationTable.itsTable(8, 0);
            Console.WriteLine("---------------Sum natural first numbers---------------\n");
            Console.WriteLine(SumNaturalNumber.seriesSum(20));
            Console.WriteLine("-------------sum natural first numbers using induction-----------------\n");
            Console.WriteLine(SumNaturalNumber.seriesSumInduction(20));
            Console.WriteLine("--------------Swapping 2 numbers----------------\n");
            Swapping.Swapp(30, 15);
            Swapping.SwappBitWise(30, 15);
            Console.WriteLine("--------------Find the closest number----------------\n");
            Console.WriteLine(FindClosestNumber.closestNumber(13,4));
            Console.WriteLine("--------------Dice OpositePhase Problem----------------\n");
            DiceOppositePhases.OppositeFaceOfDice(3);
        }
       
    }
}
