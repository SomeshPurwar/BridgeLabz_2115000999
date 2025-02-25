﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTransaction
{
    public class BankAccount
    {
        private double _balance;

        public BankAccount(double initialBalance = 0)
        {
            _balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            _balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > _balance)
            {
                return false;
            }
            _balance -= amount;
            return true;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }

}
