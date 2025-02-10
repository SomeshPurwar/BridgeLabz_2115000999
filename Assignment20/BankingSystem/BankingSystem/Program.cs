using System;
namespace BankingSystem
{

    // Abstract class BankAccount
    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public string AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        public double Balance { get { return balance; } protected set { balance = value; } }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C} into {accountNumber}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew Rs.{amount} from {accountNumber}. Remaining balance: Rs.{balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public abstract double CalculateInterest();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account: {accountNumber}, Holder: {holderName}, Balance: Rs.{balance}");
        }
    }

    // Interface ILoanable
    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    // SavingsAccount class
    class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04; // 4% interest

        public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan of Rs.{amount} applied for savings account {AccountNumber}.");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5; // Eligible for 5x balance loan
        }
    }

    // CurrentAccount class
    class CurrentAccount : BankAccount
    {
        private double interestRate = 0.02; // 2% interest

        public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
    }

    // Main class
    class Program
    {
        static void Main()
        {
            List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("S123", "Somesh", 5000),
            new CurrentAccount("C456", "Shubham", 10000)
        };

            foreach (var account in accounts)
            {
                account.DisplayDetails();
                double interest = account.CalculateInterest();
                Console.WriteLine($"Calculated Interest: Rs.{interest}");
                if (account is ILoanable loanable)
                {
                    Console.WriteLine($"Loan Eligibility: Rs.{loanable.CalculateLoanEligibility()}");
                    loanable.ApplyForLoan(2000);
                }
                Console.WriteLine();
            }
        }
    }

}
