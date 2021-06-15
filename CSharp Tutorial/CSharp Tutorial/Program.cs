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
            //string name = "shane";
            //string caps = StringManipulation.CapitalizeWord(name);
            //Console.WriteLine(caps);
            string[] methodText = { "tHiS", "iS", "a", "nice", "method", "namE" };
            string[] variableText = { "tHiS", "iS", "a", "nice", "variable", "namE" };
            string methodName = StringManipulation.ToPascalCase(methodText);
            string variableName = StringManipulation.ToCamelCase(variableText);
            Console.WriteLine($"Here is your method name {methodName}");
            Console.WriteLine($"Here is your varible name {variableName}");
            Console.ReadKey();
        }
    }
}
