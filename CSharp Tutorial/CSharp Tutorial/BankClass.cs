using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    class BankClass
    {
        public static void Bank()
        {
            var account = new BankAccount("Warbuks", 6174);
            Console.WriteLine($"\nAccount for {account.Owner} created with a starting balance of ${account.Balance}");
        }

    }

}


