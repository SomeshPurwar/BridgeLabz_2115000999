using System;

class ReverseNumber
{
    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = number;
        int digitCount = 0;
        while (temp != 0)
        {
            temp /= 10;
            digitCount++;
        }
        int[] digits = new int[digitCount];
        for (int i = 0; i < digitCount; i++)
        {
            digits[i] = number % 10; 
            number /= 10; 
        }

        Console.WriteLine("The number in reverse order is:");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]);
        }

        Console.WriteLine();
    }
}
