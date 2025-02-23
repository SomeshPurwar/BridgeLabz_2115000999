using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 }; // Initialized array

        try
        {
            Console.Write("Enter the index: ");
            int index = int.Parse(Console.ReadLine());

            if (numbers == null || numbers.Length == 0)
            {
                throw new NullReferenceException();
            }

            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
    }
}
