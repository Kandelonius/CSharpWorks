﻿using System;
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
            string[] methodText = { "tHiS", "iS", "a", "nice", "method", "namE", "from", "an", "array" };
            string[] variableText = { "tHiS", "iS", "a", "nice", "variable", "namE" };
            string a = "aPplE", b = "baNana", c = "cherry";
            string methodName = StringManipulation.ToPascalCase(methodText);
            string variableName = StringManipulation.ToCamelCase(variableText);
            string fruitMethodName = StringManipulation.ToPascalCase(a, b);
            string fruitVariableName = StringManipulation.ToCamelCase(a, b, c);
            Console.WriteLine($"Here is your method name {methodName}");
            Console.WriteLine($"Here is your varible name {variableName}");
            Console.WriteLine($"Here is your varible name {fruitMethodName}");
            Console.WriteLine($"Here is your varible name {fruitVariableName}");
            Console.ReadKey();
        }
    }
}
