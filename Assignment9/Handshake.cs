using System;

public class Handshake
{
    public static void print()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int maxHandshakes = CalculateHandshakes(numberOfStudents);

        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxHandshakes}");
    }

    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}
