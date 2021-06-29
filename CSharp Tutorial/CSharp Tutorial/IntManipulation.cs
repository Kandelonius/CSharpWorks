using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    class IntManipulation
    {

        public static void MultiplyNumber()
        {
            Console.WriteLine("Please enter a number");
            int num = 0;
            string input;
            bool check = false;
            input = Console.ReadLine();
            if (int.TryParse(input, out num))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num * (i)}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {input} is not in a correct format");
            }
        }


    }
}
