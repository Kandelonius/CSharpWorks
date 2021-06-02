using BankLibrary;
using System;
using Xunit;

namespace BankTests
{
    public class UnitTests
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CannotOverdraw()
        {
            var account = new BankAccount("Warbucks", 6173);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw")
            );

        }
        [Fact]
        public void CanWithdrawValid()
        {
            var account = new BankAccount("Warbucks", 6173);
            account.MakeWithdrawal(1000, DateTime.Now, "Attempt to withdraw");
            Assert.True(account.Balance == 5173);
        }
        [Fact]
        public void CannotStartNegativeAccount()
        {
            // Test that the initial balances must be positive.
            BankAccount invalidAccount;

            Assert.Throws<ArgumentOutOfRangeException>(
                () => invalidAccount = new BankAccount("invalid", -55)
            );
        }
    }
}
