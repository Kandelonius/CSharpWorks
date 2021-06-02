using System;
using Humanizer;

namespace BankLibrary
{
    public class Transaction
    {
        public decimal Amount { get; }

        public string ReadableAmount
        {
            get
            {
                return ((int)Amount).ToWords();
            }
        }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
