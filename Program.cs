using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsPractice
{

    class Program
    {
        public static ulong OddCount(ulong n)
        {
            // ulong number = n;
            List<ulong> lessThanN = new List<ulong>();
            for (ulong index = 0; index < n; index++)
            {
                lessThanN.Add(index);
            }
            var count = lessThanN.Count(number => number % 2 != 0);
            var ulongCount = Convert.ToUInt64(count);
            return ulongCount;
        }
        static void Main(string[] args)
        {


            var result = OddCount(15);
            Console.WriteLine($"The Count is {result}");



        }
    }
}
