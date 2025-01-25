using System;

class NaturalNumber
{
    public static void print()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		
		if(number>=0){
			double res=number*(number+1)/2.0;
			Console.WriteLine($"The sum of {number} natural numbers is {res} ");
			
			
		}else{
			Console.WriteLine($"The number {number} is not a natural number");
		}

    }
	
}
