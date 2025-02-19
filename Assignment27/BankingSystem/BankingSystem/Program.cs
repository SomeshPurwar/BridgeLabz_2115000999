using System;
using System.Collections.Generic;
using System.Linq;

class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>(); // Account ID -> Balance
    private SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>(); // Sorted by Account ID
    private Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>(); // Holds withdrawal requests

    // Add an account
    public void AddAccount(int accountId, double balance)
    {
        if (!accountBalances.ContainsKey(accountId))
        {
            accountBalances[accountId] = balance;
            sortedAccounts[accountId] = balance;
        }
    }

    // Deposit money
    public void Deposit(int accountId, double amount)
    {
        if (accountBalances.ContainsKey(accountId))
        {
            accountBalances[accountId] += amount;
            sortedAccounts[accountId] += amount;
        }
        else
        {
            Console.WriteLine($"Account {accountId} not found!");
        }
    }

    // Request withdrawal (queued)
    public void RequestWithdrawal(int accountId, double amount)
    {
        if (accountBalances.ContainsKey(accountId) && accountBalances[accountId] >= amount)
        {
            withdrawalQueue.Enqueue(new Tuple<int, double>(accountId, amount));
        }
        else
        {
            Console.WriteLine($"Withdrawal request failed for Account {accountId}: Insufficient funds or account does not exist.");
        }
    }

    // Process withdrawals
    public void ProcessWithdrawals()
    {
        while (withdrawalQueue.Count > 0)
        {
            var request = withdrawalQueue.Dequeue();
            int accountId = request.Item1;
            double amount = request.Item2;

            if (accountBalances[accountId] >= amount)
            {
                accountBalances[accountId] -= amount;
                sortedAccounts[accountId] -= amount;
                Console.WriteLine($"Processed withdrawal of Rs.{amount} from Account {accountId}");
            }
            else
            {
                Console.WriteLine($"Withdrawal failed for Account {accountId}: Insufficient funds.");
            }
        }
    }

    // Display all accounts sorted by ID
    public void DisplaySortedAccounts()
    {
        Console.WriteLine("\nAccounts sorted by Account ID:");
        foreach (var entry in sortedAccounts)
        {
            Console.WriteLine($"Account {entry.Key}: Rs.{entry.Value}");
        }
    }

    // Display all accounts sorted by balance
    public void DisplayAccountsSortedByBalance()
    {
        Console.WriteLine("\nAccounts sorted by Balance:");
        foreach (var entry in accountBalances.OrderBy(a => a.Value))
        {
            Console.WriteLine($"Account {entry.Key}: Rs.{entry.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();

        // Adding accounts
        bank.AddAccount(101, 5000);
        bank.AddAccount(102, 7000);
        bank.AddAccount(103, 3000);

        // Depositing money
        bank.Deposit(101, 2000);
        bank.Deposit(103, 1000);

        // Requesting withdrawals
        bank.RequestWithdrawal(101, 4000);
        bank.RequestWithdrawal(102, 8000); // Should fail
        bank.RequestWithdrawal(103, 2000);

        // Processing withdrawals
        Console.WriteLine("\nProcessing Withdrawals...");
        bank.ProcessWithdrawals();

        // Displaying accounts
        bank.DisplaySortedAccounts();
        bank.DisplayAccountsSortedByBalance();
    }
}
