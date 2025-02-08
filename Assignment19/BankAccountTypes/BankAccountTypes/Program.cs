using System;
namespace BankAccountTypes
{
    class BankAccount
    {
        public string accountNumber;
        public double balance;

        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("General Bank Account");
        }
    }

    class SavingsAccount : BankAccount
    {
        public double interestRate;

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }
    class CheckingAccount : BankAccount
    {
        public double withdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        public int depositTerm;

        public FixedDepositAccount(string accountNumber, double balance, int depositTerm)
            : base(accountNumber, balance)
        {
            this.depositTerm = depositTerm;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }
    }

    class Program
    {
        static void Main()
        {
            BankAccount savings = new SavingsAccount("S12345", 5000.0, 3.5);
            BankAccount checking = new CheckingAccount("C765443", 2000.0, 1000.0);
            BankAccount fixedDeposit = new FixedDepositAccount("c76543", 10000.0, 12);

            savings.DisplayAccountType();
            checking.DisplayAccountType();
            fixedDeposit.DisplayAccountType();
        }
    }
}