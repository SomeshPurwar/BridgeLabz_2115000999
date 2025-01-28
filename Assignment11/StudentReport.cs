using System;

public class StudentReport
{
    public static void print()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int[,] scores = GenerateScores(numberOfStudents);
        double[,] results = CalculateResults(scores);
        DisplayScorecard(scores, results);
    }

    static int[,] GenerateScores(int numberOfStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numberOfStudents, 3];

        for (int i = 0; i < numberOfStudents; i++)
        {
            scores[i, 0] = random.Next(40, 100); // Physics
            scores[i, 1] = random.Next(40, 100); // Chemistry
            scores[i, 2] = random.Next(40, 100); // Maths
        }
        return scores;
    }

    static double[,] CalculateResults(int[,] scores)
    {
        int numberOfStudents = scores.GetLength(0);
        double[,] results = new double[numberOfStudents, 3];

        for (int i = 0; i < numberOfStudents; i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }
        return results;
    }

    static void DisplayScorecard(int[,] scores, double[,] results)
    {
        Console.WriteLine("Student\t\tPhysics\t\tChemistry\t\tMaths\t\tTotal\t\tAverage\t\tPercentage");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine($"  {i + 1}\t\t  {scores[i, 0]}\t\t  {scores[i, 1]}\t\t\t {scores[i, 2]}\t\t  {results[i, 0]}\t\t {results[i, 1]}\t\t {results[i, 2]}%");
        }
    }
}
