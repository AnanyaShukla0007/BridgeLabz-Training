using NUnit.Framework;
using System;

namespace BankAccountTest
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new Exception("Deposit amount cannot be negative");
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient funds.");
            Balance -= amount;
        }
    }

    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void Test_Deposit_ValidAmount()
        {
            var account = new BankAccount(2000m);
            account.Deposit(500m);
            Assert.That(account.Balance, Is.EqualTo(2500m));
        }

        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            var account = new BankAccount(2000m);
            var ex = Assert.Throws<Exception>(() => account.Deposit(-500m));
            Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));
        }

        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            var account = new BankAccount(2000m);
            account.Withdraw(500m);
            Assert.That(account.Balance, Is.EqualTo(1500m));
        }

        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            var account = new BankAccount(2000m);
            var ex = Assert.Throws<Exception>(() => account.Withdraw(3000m));
            Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
        }
    }
}
