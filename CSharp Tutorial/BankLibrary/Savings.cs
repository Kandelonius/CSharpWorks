using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    class Savings : AccountType // derived from AccountType
    {
        public Savings(string type) : base("Savings") // constructor calling super for savings
        {
        }
        public override string greeting()
        {
            return "Good day, you are wise to save your money";
        }
    }
}
