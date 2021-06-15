using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    static class StringManipulation
    {
        public static string CapitalizeWord(string input)
        {
            string output = "";
            output = input.Substring(0, 1).ToUpper() + input.Substring(1, input.Length - 1).ToLower();
            return output;
        }
    }
}
