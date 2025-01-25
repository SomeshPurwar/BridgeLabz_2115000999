using System;

public class StudentGrades
{
    public static void print()
    {
        Console.WriteLine("Enter the number of students:");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        char[] grades = new char[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1) + ":");

            do
            {
                Console.Write("Enter Physics marks: ");
                physicsMarks[i] = Convert.ToInt32(Console.ReadLine());
            } while (physicsMarks[i] < 0);

            do
            {
                Console.Write("Enter Chemistry marks: ");
                chemistryMarks[i] = Convert.ToInt32(Console.ReadLine());
            } while (chemistryMarks[i] < 0);

            do
            {
                Console.Write("Enter Maths marks: ");
                mathsMarks[i] = Convert.ToInt32(Console.ReadLine());
            } while (mathsMarks[i] < 0);

            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3.0;

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