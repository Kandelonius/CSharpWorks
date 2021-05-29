using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    class BankClass
    {
        public static void Bank()
        {
            var account = new BankAccount("Warbucks", 6173);
            Console.WriteLine($"\nAccount for {account.Owner} created with Account #{account.Number}");
            account.MakeWithdrawal(100, DateTime.Now, "Withdrawing $100");
        }

    }

}
