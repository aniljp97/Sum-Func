using System;
using System.Linq;

namespace SumFunc
{
    class Program
    {
        static long Sum(int[] arr)
        {
            long sum = 0;
            foreach(int e in arr)
            {
                sum += e;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] { 1,2,3}) == 6);
            Console.WriteLine(Sum(new int[] { 6, 2, 2 }) == 10);
            Console.WriteLine(Sum(new int[] { 11, -2, -10 }) == -1);
            Console.WriteLine(Sum(new int[] { 1, -1, 0 }) == 0);
        }
    }
}
