namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int[] ints = { 1, 2, 3 ,4,5,6,7,8,9,10};
            (int sumEven , int sumOdd) check = SumOddAndEven(ints);

            Console.WriteLine("Cut ededlerin cemi : "  + check.sumEven);
            Console.WriteLine("Tek ededlerin cemi : "  + check.sumOdd);


        }

        static (int,int) SumOddAndEven(int[] ints)
        {
            int SumOdd = 0;
            int SumEven = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    SumEven += ints[i];
                }
                else
                {
                    SumOdd += ints[i];
                }
            }
            return (SumEven,SumOdd);
        } 
    }
}