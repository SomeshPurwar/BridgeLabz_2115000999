using System;

namespace BankAccountSystem
{
    public class BankAccount
    {
        // Static variable shared across all accounts
        public static string bankName = "SBI";
        private static int totalAccounts = 0;

        // Readonly variable for account number
        public readonly int AccountNumber;
        private string accountHolderName;
        private double balance;

        // Constructor using 'this' to resolve ambiguity
        public BankAccount(string AccountHolderName, int AccountNumber, double initialDeposit)
        {
            this.accountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            this.balance = initialDeposit;
            totalAccounts++;
        }

        // Static method to get total number of accounts
        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        // Method to get account details
        public string GetAccountDetails()
        {
            return $"Bank Name: {bankName}\nAccount Holder: {accountHolderName}\nAccount Number: {AccountNumber}\nBalance: {balance}";
        }

    
    }
}
