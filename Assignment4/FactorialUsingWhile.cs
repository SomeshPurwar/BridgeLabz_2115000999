using System;

class FactorialUsingWhile
{
    public static void print()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		int res=1;
		int temp=number;
		if(temp==0){Console.Write($"Factorial of {number} is {res}");}
		else if(temp>=0){
			while(temp>0){
				res*=temp;
				temp--;
			}
			
			Console.Write($"Factorial of {number} is {res}");
			
			
			
		}else{
			Console.Write("Not natural number ");
		}
			
		
		

    }
	
}
