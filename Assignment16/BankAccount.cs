// Problem 3: Bank Account Management
// Create a BankAccount class with:
// accountNumber (public)
// accountHolder (protected)
// balance (private)
// Implement methods to:
// Access and modify balance using public methods.
// Create a subclass SavingsAccount to demonstrate access to accountNumber and accountHolder.

using System;
class Test12{
    public static void Print(){
        Console.WriteLine("Enter Account Number:");
        int accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Account Holder Name:");
        string accountHolder = Console.ReadLine();

        Console.WriteLine("Enter Initial Balance:");
        double balance = Convert.ToDouble(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber, accountHolder, balance);

        Console.WriteLine("\nBank Account Details:");
        account.DisplayAccountDetails();
        Console.ReadKey();

        Console.WriteLine("Enter Interest on Saving Account:");
        int interestRate=Convert.ToInt16(Console.ReadLine());
        SavingsAccount savings = new SavingsAccount(accountNumber, accountHolder, balance, interestRate);
        Console.WriteLine("\nSavings Account Details:");
        savings.DisplaySavingsDetails();
        Console.ReadKey();

        Console.WriteLine("Enter Amount to Deposit:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        account.Deposit(depositAmount);
        Console.ReadKey();

        Console.WriteLine("\nEnter Amount to Withdraw:");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
        account.Withdraw(withdrawAmount);

        Console.ReadKey();
        Console.WriteLine("\nUpdated Bank Details:");
        account.DisplayAccountDetails();
    }
}

public class BankAccount{
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    public BankAccount(int accountNumber, string accountHolder, double balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    public double GetBalance(){
        return balance;
    }
    public void Deposit(double amount){
        balance += amount;
        Console.WriteLine($"Deposited: INR "+amount);
    }

    public void Withdraw(double amount){
        if (amount <= balance){
            balance -= amount;
            Console.WriteLine("Withdrawn: INR "+amount);
        }else{
            Console.WriteLine("Low balance");
        }
    }

    public void DisplayAccountDetails(){
        Console.WriteLine("Account Number: "+accountNumber);
        Console.WriteLine("Account Holder: "+accountHolder);
        Console.WriteLine("Balance: INR "+balance);
    }
}

public class SavingsAccount : BankAccount{
    private double interestRate;
    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance){
        this.interestRate = interestRate;
    }

    public void DisplaySavingsDetails(){
        Console.WriteLine("Account Number: "+accountNumber);
        Console.WriteLine("Account Holder: "+accountHolder);
        Console.WriteLine("Interest Rate: "+interestRate+" %");
        Console.WriteLine("Balance: INR "+GetBalance());
    }
}
