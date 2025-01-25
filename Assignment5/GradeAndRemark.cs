using System;

public class GradeAndRemark
{
    public static void print()
    {
        Console.WriteLine("Enter marks for Physics:");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for Chemistry:");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks for Maths:");
        int maths = Convert.ToInt32(Console.ReadLine());

        double totalMarks = physics + chemistry + maths;
        double percentage = (totalMarks / 300) * 100;

        string grade;

        if (percentage >= 80)
        {
            grade = "A";
        }
        else if (percentage >= 70)
        {
            grade = "B";
        }
        else if (percentage >= 60)
        {
            grade = "C";
        }
        else if (percentage >= 50)
        {
            grade = "D";
        }
        else if (percentage >= 40)
        {
            grade = "E";
        }
        else
        {
            grade = "R";
        }

        Console.WriteLine("\nAverage Mark: " + percentage.ToString("0.00") + "%");
        Console.WriteLine("Grade: " + grade);

        switch (grade)
        {
            case "A":
                Console.WriteLine("Remarks: Level 4, above agency-normalized standards");
                break;
            case "B":
                Console.WriteLine("Remarks: Level 3, at agency-normalized standards");
                break;
            case "C":
                Console.WriteLine("Remarks: Level 2, below, but approaching agency-normalized standards");
                break;
            case "D":
                Console.WriteLine("Remarks: Level 1, well below agency-normalized standards");
                break;
            case "E":
                Console.WriteLine("Remarks: Level 1-, too below agency-normalized standards");
                break;
            case "R":
                Console.WriteLine("Remarks: Remedial standards");
                break;
        }
    }
}