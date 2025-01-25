using System;

class SumTillExit
{
    public static void print()
    {
		double total=0.0;
		double number;
		Console.WriteLine("--Enter numbers to add to the total. Enter 0 to stop--");
        
		
		do{
			Console.Write("Enter the number: ");
			number=Convert.ToDouble(Console.ReadLine());
			total+=number;
			
		}while (number!=0);
			
		Console.WriteLine($"The sum of all numbers you have entered is:{total}");

    }
	
}
