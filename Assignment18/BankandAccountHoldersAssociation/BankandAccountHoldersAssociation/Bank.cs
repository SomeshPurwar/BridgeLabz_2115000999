using System;
using System.Collections.Generic;

namespace BankandAccountHoldersAssociation
{
    class Bank
    {
        public string name;
        private List<Customer> customers;

        public Bank(string name)
        {
            this.name = name;
            customers = new List<Customer>();
        }

        public void openAccount(string customerName,double initialDeposit)
        {
            Customer customer = new Customer(customerName, this, initialDeposit);
            customers.Add(customer);
            Console.WriteLine($"Account opened for {customerName} with an initial deposit of {initialDeposit} Rs. in {name}.");
        }
            
    }
}
