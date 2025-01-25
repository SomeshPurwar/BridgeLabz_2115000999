using System;

class FindBonus
{
    public static void print()
    {
        Console.Write("Enter the year of service: ");
		int serviceYear=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the current salary: ");
		double salary=Convert.ToDouble(Console.ReadLine());
		double bonus;
		
		if(serviceYear>5){
			bonus=(salary*5)/100;
			Console.WriteLine($"Bonus is {bonus}");
			
			
		}else{
			Console.Write("No Bonus ");
		}	

    }
	
}
