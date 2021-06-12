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
        public static void NumberInRange()
        {
            Console.WriteLine("Please enter a whole number between 1 and 10 inclusive");
            string input = Console.ReadLine();
            int userNumber;
            if(ValidNumber(input))
            { 
                userNumber = Convert.ToInt32(input);
                if (userNumber > 0 && userNumber < 11)
                {
                    Console.WriteLine($"{userNumber} is valid");
                }
                else if (userNumber < 1)
                {
                    Console.WriteLine($"{userNumber} is too small");
                }
                else
                {
                    Console.WriteLine($"{userNumber} is too large");
                }
            }
        }

        /*
         * Write a program which takes three numbers from the console and displays the maximum of them.
         * My program allows the user to determine how many numbers will be compared.
         * I also have some validation to ensure the numbers being passed in are actually numbers.
         */
        public static void MaxNum()
        {
            Console.WriteLine("This program will compare numbers entered by a user and output the highest one.");
            Console.WriteLine("Please enter the amount of numbers you'd like to compare.");
            string input = Console.ReadLine();
            int arrSize = Convert.ToInt32(input);
            int[] nums = new int[arrSize];
            int count = 0;

            while(count < arrSize)
            {
                int temp;
                Console.WriteLine($"Please enter number #{count + 1}");
                string number = Console.ReadLine();
                if (ValidNumber(number))
                {
                    temp = Convert.ToInt32(number);
                    nums[count] = temp;
                    count++;
                }
                else
                {
                    Console.WriteLine($"Sorry {number} isn't a valid input, please try again.");
                }
            }

            count = 0;
            int max = nums[0];
            foreach (int num in nums)
            {
                if(nums[count] > max)
                {
                    max = nums[count];
                    count++;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine($"The highest number of the {arrSize} numbers you provided was {max}");
        }


        /*
         * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         * Display the count on the console.
         * Again I will leave the max value up to the user.
         */
        public static void SumDivisibleByThree()
        {
            Console.WriteLine("Please enter a maximum number greater than 2 and I will determine how many numbers" +
                " are divisible by 3 between 1 and the number you entered");
        }
        static Boolean ValidNumber(string usernum)
        {
            int userNumber;
            try
            {
                userNumber = Convert.ToInt32(usernum);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"That is not a valid input", usernum.GetType().Name, usernum);
            }
            return false;
        }
    }
}
