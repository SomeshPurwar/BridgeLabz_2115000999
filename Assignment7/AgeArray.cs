using System;

public class AgeArray
{
    public static void print()
    {
		int[] ageArray=new int[10];
        for(int i=0;i<ageArray.Length;i++){
			Console.WriteLine($"Enter the age of Student {i+1}:");
			int age=Convert.ToInt32(Console.ReadLine());
			if (age < 0)
			{
				Console.Error.WriteLine("Invalid Age.");
				Environment.Exit(0);
			}
			ageArray[i]=age;
		}
		for(int j=0;j<ageArray.Length;j++){
			
			if(ageArray[j] >= 18){
				Console.WriteLine($"The student {j+1} with the age {ageArray[j]} can vote");
			}
			else{
				Console.WriteLine($"The student {j+1} with the age {ageArray[j]} cannot vote");
			}

		}
		
    }
}