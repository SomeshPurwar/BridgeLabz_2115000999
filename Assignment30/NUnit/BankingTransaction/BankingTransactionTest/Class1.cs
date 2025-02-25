using BankingTransaction;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankingTransactionTest
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void SetUp()
        {
            _account = new BankAccount(100); // Initial balance set to 100 for testing
        }

        [TearDown]
        public void TearDown()
        {
            _account = null; // Cleanup after each test
        }

        // Test cases for Deposit method
        private static IEnumerable<TestCaseData> DepositTestCases()
        {
            yield return new TestCaseData(50, 150);
            yield return new TestCaseData(0, 100); // Edge case: Zero deposit
            yield return new TestCaseData(100, 200);
            yield return new TestCaseData(0.1, 100.1); // Floating-point precision check
        }

        [Test]
        [TestCaseSource(nameof(DepositTestCases))]
        public void Deposit_WhenValidAmount_UpdatesBalance(double amount, double expectedBalance)
        {
            _account.Deposit(amount);
            Assert.That(_account.GetBalance(), Is.EqualTo(expectedBalance).Within(0.0001));
        }

        [Test]
        public void Deposit_WhenNegativeAmount_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _account.Deposit(-50));
            Assert.That(ex!.Message, Is.EqualTo("Deposit amount must be positive."));
        }

        // Test cases for Withdraw method
        private static IEnumerable<TestCaseData> WithdrawTestCases()
        {
            yield return new TestCaseData(50, true, 50);
            yield return new TestCaseData(150, false, 100); // Insufficient funds case
            yield return new TestCaseData(100, true, 0); // Edge case: Withdraw full balance
            yield return new TestCaseData(0, true, 100); // Edge case: Zero withdrawal
        }

        [Test]
        [TestCaseSource(nameof(WithdrawTestCases))]
        public void Withdraw_WhenCalled_ReturnsExpectedResult(double amount, bool expectedResult, double expectedBalance)
        {
            bool result = _account.Withdraw(amount);
            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(_account.GetBalance(), Is.EqualTo(expectedBalance).Within(0.0001));
        }

        [Test]
        public void Withdraw_WhenNegativeAmount_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _account.Withdraw(-50));
            Assert.That(ex!.Message, Is.EqualTo("Withdrawal amount must be positive."));
        }
    }
}
