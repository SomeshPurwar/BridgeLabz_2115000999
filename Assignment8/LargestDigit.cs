using System;

class LargestDigit
{
    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigits = 10;
        int[] digits = new int[maxDigits];
        int index = 0;
		if (number <= 0)
        {
            Console.Error.WriteLine("No digits to process.");
            return;
        }
        while (number != 0 && index < maxDigits)
        {
            digits[index] = number % 10; 
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

        Console.WriteLine($"The largest digit is: {largest}");
        Console.WriteLine($"The second largest digit is: {secondLargest}");
    }
}
