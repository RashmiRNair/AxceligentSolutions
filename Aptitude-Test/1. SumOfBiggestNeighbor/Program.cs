using SumOfBiggestNumber;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] input =new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            // int[] input = new int[] { 1, 6, 1, 2, -6, 1, -6, -6 };
            //int[] input = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            //int[] input = new int[] { 6, 8 };
            //int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            CalculateSum cs = new CalculateSum();
            int total = cs.Challenge(input);
            Console.WriteLine(total);
            Console.ReadLine();
            
        }
    }
}
