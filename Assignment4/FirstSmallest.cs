using System;

class FirstSmallest
{
    public static void isSmallest()
    {
        Console.Write("Enter the number 1: ");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the number 2: ");
		int number2=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the number 3: ");
		int number3=Convert.ToInt32(Console.ReadLine());
		
		Console.Write($"Is the first number the smallest?: ");
		if(number1 < number2){
			if(number1<number3)
				Console.Write(" True ");
		}else{
			Console.Write(" False ");
		}

    }
}
