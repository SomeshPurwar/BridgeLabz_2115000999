using System;

public class MatrixOperations
{
    public static void print()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrixA = GenerateMatrix(rows, cols);
        int[,] matrixB = GenerateMatrix(rows, cols);

        Console.WriteLine("\nMatrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(matrixB);

        Console.WriteLine("\nAddition of Matrices:");
        DisplayMatrix(AddMatrices(matrixA, matrixB));

        Console.WriteLine("\nSubtraction of Matrices:");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB));
		
		Console.WriteLine("Multiplication of A and B:");
        DisplayMatrix(MultiplyMatrices(matrixA, matrixB));

        if (rows == cols)
        {
            Console.WriteLine("\nTranspose of Matrix A:");
            DisplayMatrix(TransposeMatrix(matrixA));

            if (rows == 2)
            {
                Console.WriteLine($"\nDeterminant of Matrix A: {Determinant2x2(matrixA)}");
                Console.WriteLine("\nInverse of Matrix A:");
                DisplayMatrix(Inverse2x2(matrixA));
            }
            else if (rows == 3)
            {
                Console.WriteLine($"\nDeterminant of Matrix A: {Determinant3x3(matrixA)}");
                Console.WriteLine("\nInverse of Matrix A:");
                DisplayMatrix(Inverse3x3(matrixA));
            }
        }
    }

    static int[,] GenerateMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = random.Next(1, 10);

        return matrix;
    }

    static int[,] AddMatrices(int[,] A, int[,] B)
    {
        int rows = A.GetLength(0), cols = A.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] + B[i, j];

        return result;
    }

    static int[,] SubtractMatrices(int[,] A, int[,] B)
    {
        int rows = A.GetLength(0), cols = A.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] - B[i, j];

        return result;
    }
	
	static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0), colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0), colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
            throw new InvalidOperationException("Matrix multiplication not possible!");

        int[,] result = new int[rowsA, colsB];
        for (int i = 0; i < rowsA; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += matrixA[i, k] * matrixB[k, j];

        return result;
    }


    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transpose[j, i] = matrix[i, j];

        return transpose;
    }

    static int Determinant2x2(int[,] matrix)
    {
        return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
    }

    static int Determinant3x3(int[,] matrix)
    {
        return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
             - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
             + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
    }

    static double[,] Inverse2x2(int[,] matrix)
    {
        int det = Determinant2x2(matrix);
        if (det == 0) throw new InvalidOperationException("Matrix has no inverse.");

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / (double)det;
        inverse[0, 1] = -matrix[0, 1] / (double)det;
        inverse[1, 0] = -matrix[1, 0] / (double)det;
        inverse[1, 1] = matrix[0, 0] / (double)det;

        return inverse;
    }

    static double[,] Inverse3x3(int[,] matrix)
    {
        int det = Determinant3x3(matrix);
        if (det == 0) Console.Error.WriteLine("Matrix has no inverse.");

        double[,] inverse = new double[3, 3];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                int[,] minor = new int[2, 2];
                int r = 0, c = 0;

                for (int row = 0; row < 3; row++)
                {
                    if (row == i) continue;
                    c = 0;
                    for (int col = 0; col < 3; col++)
                    {
                        if (col == j) continue;
                        minor[r, c] = matrix[row, col];
                        c++;
                    }
                    r++;
                }

                inverse[j, i] = Math.Round((Math.Pow(-1, i + j) * Determinant2x2(minor)) / det, 2);
            }

        return inverse;
    }

    static void DisplayMatrix<T>(T[,] matrix)
    {
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }
}
