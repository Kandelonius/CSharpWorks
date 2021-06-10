using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    class SollersAssignments
    {
        public static void Reverse()
        {
            Console.WriteLine("Please enter some text to be reversed");
            string input = Console.ReadLine();
            string reverseWhile = "";
            string reverseDoWhile = "";
            int index = 0;

            while (index < input.Length)
            {
                reverseWhile = input[index] + reverseWhile;
                index++;
            }
            Console.WriteLine($"reverse using while is {reverseWhile} and the original input is {input}");

            do
            {
                reverseDoWhile = reverseDoWhile + input[index - 1];
                index--;
            } while (index >= 1);
            Console.WriteLine($"reverse using do while is {reverseDoWhile} and the original input is {input}");
        }

        public static void ValidNumber()
        {

        }
        
    }
}
