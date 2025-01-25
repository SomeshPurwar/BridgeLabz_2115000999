using System;

public class MultiplicationTableRange
{
    public static void print()
    {
        Console.WriteLine("Enter a number :");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] multiplicationResult = new int[4]; 

        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i; 
        }

        Console.WriteLine($"\nMultiplication Table of {number} (from 6 to 9):");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}
