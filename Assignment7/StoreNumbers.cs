using System;

public class StoreNumbers
{
    public static void print()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (true)
        {
            Console.WriteLine("Enter a number (0 or negative to stop):");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0 || index == 10)
            {
                break;
            }

            numbers[index] = input;
            index++;
        }

        Console.WriteLine("\nNumbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine($"\nTotal sum of numbers: {total}");
    }
}
