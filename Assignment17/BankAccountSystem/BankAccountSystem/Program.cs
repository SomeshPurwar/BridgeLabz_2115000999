using BankAccountSystem;

class Program
{
    static BankAccount[] accounts = new BankAccount[10];
    static int accountCount = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Display Account Details");
            Console.WriteLine("3. Display Total Accounts");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddAccount();
                    break;
                case 2:
                    DisplayAccount();
                    break;
                case 3:
                    Console.WriteLine("Total Accounts: " + BankAccount.GetTotalAccounts());
                    break;
                case 4:
                    Console.WriteLine("Exiting... Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void AddAccount()
    {
        if (accountCount >= accounts.Length)
        {
            Console.WriteLine("Cannot add more accounts. Account limit reached.");
            return;
        }
        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Initial Deposit: ");
        double initialDeposit = double.Parse(Console.ReadLine());

        BankAccount newAccount = new BankAccount(name, accountNumber, initialDeposit);
        accounts[accountCount] = newAccount;
        accountCount++;

        Console.WriteLine("Account added successfully!");
    }
    // Method to display account details with 'is' operator check
    static void DisplayAccount()
    {
        Console.Write("Enter Account Number to display details: ");
        int accountNumber = int.Parse(Console.ReadLine());

        // Search for the account with the matching account number
        BankAccount account = null;
        foreach (var acc in accounts)
        {
            // Using 'is' operator to check if acc is of type BankAccount and is not null
            if (acc is BankAccount accountTemp && accountTemp.AccountNumber == accountNumber)
            {
                account = accountTemp;
                break;
            }
        }

        if (account == null)
        {
            Console.WriteLine("Account not found.");
        }
        else
        {
            Console.WriteLine(account.GetAccountDetails());
        }
    }


}
