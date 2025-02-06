using System;
using System.Collections.Generic;

namespace BankandAccountHoldersAssociation
{
    class Customer
    {
        public string name;
        private Bank bank;
        public double balance;

        public Customer(string name, Bank bank, double initialDeposit)
        {
            this.name = name;
            this.bank = bank;
            balance=initialDeposit;              

        }

        public void viewBalance()
        {
            Console.WriteLine($"Balance for {name} in {bank.name}: {balance} Rs.");
        }
    }

}
