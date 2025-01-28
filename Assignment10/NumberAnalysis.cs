using System;

public class NumberAnalysis
{
	public static void print()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nNumber Analysis:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.WriteLine($"Number {numbers[i]} is Positive and {(IsEven(numbers[i]) ? "Even" : "Odd")}");
            }
            else
            {
                Console.WriteLine($"Number {numbers[i]} is Negative");
            }
        }

        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
        Console.Write("\nComparison of the first and last numbers: ");
        if (comparisonResult == 1)
        {
            Console.WriteLine("First number is greater than the last number.");
        }
        else if (comparisonResult == 0)
        {
            Console.WriteLine("First number is equal to the last number.");
        }
        else
        {
            Console.WriteLine("First number is less than the last number.");
        }
    }
	
    public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int Compare(int number1, int number2)
    {
        if (number1 > number2) return 1;
        if (number1 == number2) return 0;
        return -1;
    }

    
}
