using System;

public class FibonacciSeries
{
	public static void print()
    {
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        PrintFibonacci(terms);
    }

    static void PrintFibonacci(int terms)
    {
        int first = 0, second = 1, next;

        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
    }
}
