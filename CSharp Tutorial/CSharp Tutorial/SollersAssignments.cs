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

        /*
         * Write a program and ask the user to enter a number. The number should be between 1 and 10. 
         * If the user enters a valid number, display "Valid" on the console
         */
        public static void ValidNumber()
        {
            Console.WriteLine("Please enter a whole number between 1 and 10 inclusive");
            string input = Console.ReadLine();
            int userNumber;
            try
            {
                userNumber = Convert.ToInt32(input);
                if(userNumber > 0 && userNumber < 11)
                {
                    Console.WriteLine($"{userNumber} is valid");
                } else if(userNumber < 1)
                {
                    Console.WriteLine($"{userNumber} is too small");
                } else
                {
                    Console.WriteLine($"{userNumber} is too large");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"That is not a valid input", input.GetType().Name, input);
            }
        }
        
    }
}
