using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    static class StringManipulation
    {
        public static string CapitalizeWord(string input)
        {
            string output = "";
            if (input.Length > 1)
            {
                output = input.Substring(0, 1).ToUpper() + input.Substring(1, input.Length - 1).ToLower();
            }
            else
            {
                output = input.ToUpper();
            }
            return output;
        }

        public static string ToCamelCase(params string[] alphaText)
        {
            string result = "";
            int count = 0;
            foreach (string item in alphaText)
            {
                if (count == 0)
                {
                    result = item.ToLower();
                    count++;
                }
                else
                {
                    result += CapitalizeWord(item);
                }
            }
            return result;
        }

        public static string ToPascalCase(params string[] alphaText)
        {
            string result = "";
            foreach (string item in alphaText)
            {
                result += CapitalizeWord(item);
            }
            return result;
        }

        public static void CheckDuplicates()
        {
            Console.WriteLine("Please enter a string to be checked");
            var dict = new Dictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]] += 1;
                }
                else
                {
                    dict.Add(input[i], 1);
                }
            }
            foreach (var l in input)
            {
                if (dict[l] > 1)
                {
                    Console.WriteLine($"{l} occurs more than once in your input");
                }
            }
        }
    }
}
