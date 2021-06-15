using System;
using BankLibrary;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> start = new List<int> { 1, 1 }; // uncomment these lines to run the fibonacci class
            //Fibonacci.forLoopFib(start);

            //DataType.MyClass.Lecture();

            //BankClass.Bank();

            //SollersAssignments.Reverse();
            //SollersAssignments.NumberInRange();
            //SollersAssignments.MaxNum();
            //SollersAssignments.SumDivisibleByThree();
            //SollersAssignments.FactorialCalculator();
            //SollersAssignments.DrawRightAngle();
            string name = "shane";
            string caps = StringManipulation.CapitalizeWord(name);
            Console.WriteLine(caps);
            Console.ReadKey();
        }
    }
}
