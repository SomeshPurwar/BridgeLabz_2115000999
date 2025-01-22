using System;

class HandShake
{
    public static void count()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}");
    }
}
