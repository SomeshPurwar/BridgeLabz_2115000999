using System;

public class DigitFrequency
{
    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int count = 0; 

        while (temp > 0)
        {
            temp /= 10;
            count++;
        }

        int[] digits = new int[count]; 
        temp = number;

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        int[] frequency = new int[10]; 
        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }

        Console.WriteLine($"Digit  Frequency");
		
        for (int i = 0; i < 10; i++)
        {
			if(frequency[i]!=0){
				Console.WriteLine($"{i}\t {frequency[i]}");
			
			}
            
        }
    }
}