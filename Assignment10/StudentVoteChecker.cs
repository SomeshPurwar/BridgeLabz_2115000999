using System;

public class StudentVoteChecker
{
	public static void print()
    {
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nVoting Eligibility:");
        for (int i = 0; i < 10; i++)
        {
            bool canVote = CanStudentVote(ages[i]);
            if (ages[i] < 0)
            {
                Console.WriteLine($"Student {i + 1}: Invalid age (Cannot vote)");
            }
            else
            {
                Console.WriteLine($"Student {i + 1}: {(canVote ? "Can vote" : "Cannot vote")}");
            }
        }
    }

    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }
        return age >= 18;
    }

    
}
