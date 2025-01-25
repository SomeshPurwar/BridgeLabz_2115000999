using System;

class CheckNumber
{
    public static void print()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		if(number>0){
			Console.WriteLine($"The number {number} is positive.");
			
			
		}else if(number==0){
			Console.WriteLine($"The number {number} is zero.");
		}else{
			Console.WriteLine($"The number {number} is negative.");
		}

    }
	
}
