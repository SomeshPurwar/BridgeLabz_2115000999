using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1,  4,  7,  11 },
            { 2,  5,  8,  12 },
            { 3,  6,  9,  16 },
            { 10, 13, 14, 17 }
        };

        Console.Write("Enter the target value to search: ");
        int target = int.Parse(Console.ReadLine());

        var result = SearchMatrix(matrix, target);

        if (result.Item1 != -1)
            Console.WriteLine($"Target {target} found at row {result.Item1}, column {result.Item2}.");
        else
            Console.WriteLine($"Target {target} not found in the matrix.");
    }

    static (int, int) SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

       
        int row = 0, col = cols - 1;

        while (row < rows && col >= 0)
        {
            if (matrix[row, col] == target)
                return (row, col); 

            if (matrix[row, col] > target)
                col--; 
            else
                row++; 
        }

        return (-1, -1); 
    }
}
