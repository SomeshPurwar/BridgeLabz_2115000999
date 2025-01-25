using System;

class DivisibleBy5
{
    public static void isDivisible()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		Console.Write($"Is the {number} divisible by 5: ");
		if(number%5==0){
			Console.Write(" True ");
		}else{
			Console.Write(" False ");
		}

    }
}
