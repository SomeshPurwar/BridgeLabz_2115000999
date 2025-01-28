using System;

public class SumUsingFormulaAndRecursion
{
	public static void print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (!IsNaturalNumber(number))
        {
            Console.WriteLine("The number is not a natural number.");
            return;
        }

        int recursiveSum = SumUsingRecursion(number);
        int formulaSum = SumUsingFormula(number);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("The results match. Computation is correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. Check the methods.");
        }
    }
	
    public static bool IsNaturalNumber(int number)
    {
        return number > 0;
    }

    public static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1;
        return n + SumUsingRecursion(n - 1);
    }

    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    
}
