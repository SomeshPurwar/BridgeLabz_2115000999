using System;

class CountDownUsingFor
{
    public static void print()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		for(int i=number;i>0;i--){
			Console.WriteLine(i);
			
		}

    }
	
}
