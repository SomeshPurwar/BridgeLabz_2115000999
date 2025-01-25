using System;

public class StudentGrades2DArray
{
    public static void print()
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        int[,] marks = new int[numStudents, 3]; // 2D array to store marks (students x subjects)
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1) + ":");

            do
            {
                Console.Write("Enter Physics marks: ");
                marks[i, 0] = Convert.ToInt32(Console.ReadLine());
            } while (marks[i, 0] < 0);

            do
            {
                Console.Write("Enter Chemistry marks: ");
                marks[i, 1] = Convert.ToInt32(Console.ReadLine());
            } while (marks[i, 1] < 0);

            do
            {
                Console.Write("Enter Maths marks: ");
                marks[i, 2] = Convert.ToInt32(Console.ReadLine());
            } while (marks[i, 2] < 0);

            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            if (percentages[i] >= 80)
            {
                grades[i] = 'A';
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = 'B';
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = 'C';
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = 'D';
            }
            else if (percentages[i] >= 40)
            {
                grades[i] = 'E';
            }
            else
            {
                grades[i] = 'R';
            }
			Console.WriteLine($"Student {i + 1}: Percentage: {percentages[i]:F2}, Grade: {grades[i]}");
        }

        
    }
}