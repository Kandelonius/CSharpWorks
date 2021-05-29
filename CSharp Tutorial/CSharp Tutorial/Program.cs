using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> start = new List<int> { 1, 1 };
            Fibonacci.forLoopFib(start);

            BankClass.Bank();
        }
    }
}
