using System;
class Matrix{
	public static void print(){
	
		Console.WriteLine("Enter the number of rows:");
		int rows=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number of columns:");
		int cols=Convert.ToInt32(Console.ReadLine());
		int[,] matrix=new int[rows,cols];
		
		for(int i=0;i<rows;i++){
			for(int j=0;j<cols;j++){
				Console.WriteLine($"Enter the matrix [ {i} , {j} ]:");
				int n= Convert.ToInt32(Console.ReadLine());
				matrix[i,j]=n;
			}
		}
		Console.WriteLine("Matrix is:");
		printMatrix(matrix);
		
		int[,] transposeMatrix=transpose(matrix);
		Console.WriteLine("Transpose of matrix is:");
		printMatrix(transposeMatrix);
		Console.WriteLine();
		diagonal(matrix);
		
		
		
		
			
				
	}
	
	public static void printMatrix(int[,] matrix){
		int rows=matrix.GetLength(0);
		int cols=matrix.GetLength(1);
		for(int i=0;i<rows;i++){
			for(int j=0;j<cols;j++){
				Console.Write($"{matrix[i,j]} ");
		
			}
			Console.WriteLine();
		}
	}
	
	public static int[,] transpose(int[,] matrix){
		int rows=matrix.GetLength(0);
		int cols=matrix.GetLength(1);
		int[,] trans=new int[rows,cols];
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                trans[i,j]=matrix[j,i];
            }
        }
        return trans;
	}
	public static void diagonal(int[,] matrix){
		int rows=matrix.GetLength(0);
		int cols=matrix.GetLength(1);
		
		for(int i=0;i<rows;i++){
			Console.WriteLine(matrix[i,i]);
		}
		
		for(int i=0;i<rows;i++){
			Console.WriteLine(matrix[i,rows-i-1]);
		}
		
	}

}