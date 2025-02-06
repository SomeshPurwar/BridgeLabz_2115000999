using System;

using BankandAccountHoldersAssociation;

class Program
{
    static void Main()
    {
        Bank bank1 = new Bank("PNB");
        Bank bank2 = new Bank("SBI");

        bank1.openAccount("Somesh", 1000);


        Customer somesh = new Customer("Somesh", bank2, 1000);
        Customer krishna = new Customer("Krishna", bank1, 2000);

        somesh.viewBalance();
        krishna.viewBalance();

    }
}