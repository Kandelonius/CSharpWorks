using System;

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
    }
}
