using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for (int i = 0; i < 18; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }



            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
