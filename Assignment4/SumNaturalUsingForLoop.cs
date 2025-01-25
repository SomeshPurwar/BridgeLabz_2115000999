using System;

class SumNaturalUsingForLoop
{
    public static void print()
    {
        Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		double resUsingFormula=number*(number+1)/2.0;
		double res=0.0;
		if(number>=0){
			for(int i=number;i>0;i--){
			res+=i;
					
		
		}
			if(resUsingFormula==res){
				Console.Write($"Correct and result is {res}");
			
			}else{
				Console.Write("Incorect ");
			
			}
			
		}else{
			Console.Write("Not natural number ");
		}
			
		
		

    }
	
}
