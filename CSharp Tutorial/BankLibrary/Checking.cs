using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    class Checking : AccountType // derived from AccountType
    {
        public Checking(string type) : base("Checking") // constructor calling super for savings
        {
        }
        public override string greeting()
        {
            return "Used for active transactions";
        }
    }
}
