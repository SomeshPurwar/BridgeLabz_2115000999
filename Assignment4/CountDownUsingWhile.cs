using System;

class CountDownUsingWhile
{
    public static void print()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		while(number>0){
			Console.WriteLine(number);
			number--;
		}

    }
	
}
