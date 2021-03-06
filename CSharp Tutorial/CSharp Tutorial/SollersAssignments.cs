using System;

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

            if(input.Length < 2)
            {
                Console.WriteLine($"You entered {input} which is not long enough to be meaninfully reversed");
                return;
            }

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
            int arrSize = Convert.ToInt32(input); // I am not checking this number prior to converting it.
            int[] nums = new int[arrSize];
            int count = 0;
            int max = 0;

            while (count < arrSize)
            {
                int temp;
                Console.WriteLine($"Please enter number #{count + 1}");
                string number = Console.ReadLine();
                if (ValidNumber(number))
                {
                    temp = Convert.ToInt32(number);
                    if (nums.Length == 0)
                    {
                        max = temp;
                    }
                    if (temp > max)
                    {
                        max = temp;
                    }
                    nums[count] = temp;
                    count++;
                }
                else
                {
                    Console.WriteLine($"Sorry {number} isn't a valid input, please try again.");
                }
            }
            Console.WriteLine($"The highest number of the {arrSize} numbers you provided was {max}");
        }


        /*
         * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         * Display the count on the console.
         * Again I will leave the max value up to the user.
         * I have also actually allowed the user to select the number to divide by.
         */
        public static void SumDivisibleByThree()
        {
            Console.WriteLine("This program will determine how many numbers are divisible by a number of your " +
                "choosing between 1 and the number you entered.");
            Console.WriteLine("Please enter the maximum number.");
            string input = Console.ReadLine();
            Console.WriteLine("Now please enter a number you'd like to use as a divisor.");
            string input2 = Console.ReadLine();
            int divisor = Convert.ToInt32(input2);
            int total = 0;
            int count = 0;
            if(ValidNumber(input))
            {
                int number = Convert.ToInt32(input);
                if(divisor > number)
                {
                    Console.WriteLine($"{divisor} is larger than {number} so there are no valid numbers in this set.");
                    return;
                }
                for(int i = 1; i <= number; i++)
                {
                    if(i % divisor == 0)
                    {
                        total += i;
                        count++;
                    }
                }
            }
            Console.Write($"The total of all numbers divisible by {divisor} from 0 to {input} is {total}, and there are {count}" +
                $" total numbers that are divisible by {divisor}.");
        }

        /*
         * Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
         * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        public static void FactorialCalculator()
        {
            Console.WriteLine($"Please enter a number that you would like to know the factorial value of.");
            string input = Console.ReadLine();
            int factorial = 1;
            if(ValidNumber(input))
            {
                int number = Convert.ToInt32(input);
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
            }
            Console.WriteLine($"{input}! is {factorial}");
        }

        /*
         * Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
         */
        public static void DrawRightAngle()
        {
            Console.WriteLine("This program will output a right angle built of astrisks, please enter the amount of lines " +
                "you would like it to have.");
            string input = Console.ReadLine();
            string angleLine = "";
            if(ValidNumber(input))
            {
                int lines = Convert.ToInt32(input);
                for(int i = 1; i <= lines; i++)
                {
                    angleLine += "*";
                    Console.WriteLine(angleLine);
                }
            }
        }

        public static Boolean PalindromeChecker(string text)
        {
            int start = 0;
            int end = text.Length - 1;

            if (text.Length <= 1)
            {
                Console.WriteLine($"You entered {text} which is only a single character.");
                return true;
            }

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[start] == text[end] && start <= end)
                {
                    start++;
                    end--;
                }
                else
                {
                    Console.WriteLine($"{text} is not a palindrome.");
                    return false;
                }
            }
            Console.WriteLine($"Yay {text} is a palindrome.");
            return true;
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
