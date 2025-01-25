using System;

class SpringSeason
{
    public static void print()
    {
        Console.Write("Enter the month: ");
		int month=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the day: ");
		int day=Convert.ToInt32(Console.ReadLine());
		
		if((month == 3 && day >= 20 && day <= 31) || 
            (month == 4 && day >= 1 && day <= 30) || 
            (month == 5 && day >= 1 && day <= 31) || 
            (month == 6 && day >= 1 && day <= 20)){
				Console.WriteLine(" Its a spring season ");
		}else{
			Console.WriteLine(" Not a spring season. ");
		}
		
		
    }
}
