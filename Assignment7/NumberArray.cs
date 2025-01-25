using System;

public class NumberArray
{
    public static void print()
    {
		int[] numberArray=new int[5];
        for(int i=0;i<numberArray.Length;i++){
			Console.WriteLine($"Enter the Number {i+1}:");
			int n=Convert.ToInt32(Console.ReadLine());
			numberArray[i]=n;
		}
		for(int j=0;j<numberArray.Length;j++){
			
			if(numberArray[j] >0){
				if(numberArray[j]%2==0){
					Console.WriteLine($"The number {numberArray[j]} is even");
					
				}
				else{
					Console.WriteLine($"The number {numberArray[j]} is odd");
				}
			}
			else if(numberArray[j]==0){
				Console.WriteLine($"The number {numberArray[j]} is zero");
			}
			else{
				Console.WriteLine($"The number {numberArray[j]} is negative");;
			}

		}
		if(numberArray[0]>numberArray[numberArray.Length-1]){
			Console.WriteLine("Greater");
		}
		else if(numberArray[0]<numberArray[numberArray.Length-1]){
			Console.WriteLine("Smaller");
		}
		else{
			Console.WriteLine("Equal");
		}
		
		
    }
}