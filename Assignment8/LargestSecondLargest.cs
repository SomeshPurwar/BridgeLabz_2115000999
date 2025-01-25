using System;

public class LargestSecondLargest
{
    public static void print()
    {
        Console.WriteLine("Enter a number:");
        long number =Convert.ToInt64 (Console.ReadLine());
        int maxDigit = 10; 
        int[] digits = new int[maxDigit];
        int index = 0;

        while (number > 0)
        {
            if (index == maxDigit) 
            {
                maxDigit += 10; 
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length); 
                digits = temp;
            }

            digits[index] =(int)number % 10;
            number /= 10;
            index++;
        }

        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}