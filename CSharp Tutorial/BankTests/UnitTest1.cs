using BankLibrary;
using System;
using Xunit;

namespace BankTests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Warbucks", 6173);

            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw")
            );

        }
        [Fact]
        public void Test3()
        {
            // Test that the initial balances must be positive.
            BankAccount invalidAccount;

            Assert.Throws<ArgumentOutOfRangeException>(
                () => invalidAccount = new BankAccount("invalid", -55)
            );
        }
    }
}
