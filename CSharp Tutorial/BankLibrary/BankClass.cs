using System;

namespace BankLibrary
{
    public class BankClass
    {
        public static void Bank()
        {
            var account = new BankAccount("Warbucks", 6174);
            Console.WriteLine($"\nAccount for {account.Owner} created with Account #{account.Number}");
            account.MakeWithdrawal(100, DateTime.Now, "Withdrawing $100");
            account.MakeWithdrawal(100, DateTime.Now, "Withdrawing $100");
            account.MakeWithdrawal(250, DateTime.Now, "Withdrawing $100");
            account.MakeWithdrawal(100, DateTime.Now, "Withdrawing $100");
            account.MakeWithdrawal(100, DateTime.Now, "Withdrawing $100");

            Console.WriteLine(account.GetAccountHistory());

            //// Test that the initial balances must be positive. Commented and left in for refreence
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            account.MakeWithdrawal(50, DateTime.Now, "small withdrawal");
            Console.WriteLine(account.GetAccountHistory());

            AccountType noAccount = new AccountType("nothing");

            Savings savings = new Savings("Savings");
            Checking checking = new Checking("Checking");

            Console.WriteLine(noAccount.greeting());
            Console.WriteLine(savings.greeting());
            Console.WriteLine(checking.greeting());
        }

    }

}
