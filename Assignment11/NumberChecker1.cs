using System;
using System.Linq;

public class NumberChecker1
{
    public static int CountDigits(int number)
    {
        int len = 0;
        number = Math.Abs(number);
        while (number > 0)
        {
            len++;
            number /= 10;
        }
        return len;
    }

    public static int[] GetDigitsArray(int number)
    {
        int len = CountDigits(number);
        int[] digits = new int[len];
        int i = len - 1;
        number = Math.Abs(number);
        while (number > 0)
        {
            digits[i--] = number % 10;
            number /= 10;
        }
        return digits;
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum=0;
		for(int i=0;i<digits.Length;i++){
			sum+=digits[i];
		}
		return sum;
    }

    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum=0;
		for(int i=0;i<digits.Length;i++){
			sum+= (int)Math.Pow(digits[i],2);
			
		}
		return sum;
    }

    public static bool IsHarshadNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    public static int[,] DigitFrequency(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }

    public static void DisplayDigitFrequency(int[,] frequency)
    {
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine($"Digit: {frequency[i, 0]}, Frequency: {frequency[i, 1]}");
            }
        }
    }

    public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {number}");

        int digitCount = CountDigits(number);
        Console.WriteLine($"Count of digits: {digitCount}");

        int[] digitsArray = GetDigitsArray(number);
        Console.WriteLine("Digits array: [" + string.Join(", ", digitsArray) + "]");

        int sumOfDigits = SumOfDigits(digitsArray);
        Console.WriteLine($"Sum of digits: {sumOfDigits}");

        int sumOfSquares = SumOfSquaresOfDigits(digitsArray);
        Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");

        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine($"Is Harshad Number: {isHarshad}");

        int[,] frequency = DigitFrequency(number);
        DisplayDigitFrequency(frequency);
    }
}
