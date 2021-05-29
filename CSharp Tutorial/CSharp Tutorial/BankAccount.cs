using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    public class BankAccount
    {
        public string Number { get; }

        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890; // starting account number for new users

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Adding the initial balance to the account");
            // this appears to no longer be needed because the value is handled by the getter
            //this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++; // we increment the seeded number
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
            Console.WriteLine($"Added {amount} to account #{this.Number}\nnew balance is {this.Balance}");
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            Console.WriteLine($"Withdrew {amount} to account #{this.Number}\nnew balance is {this.Balance}");
        }

    }
}
