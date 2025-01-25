using System;

public class MultiDimensionalArray
{
    public static void print()
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns]; 
        int[] array = new int[rows * columns];
        int index = 0;

        Console.WriteLine("\nEnter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element at [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }
        Console.WriteLine("\nThe 2D Array (Matrix) is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThe 1D Array is:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
