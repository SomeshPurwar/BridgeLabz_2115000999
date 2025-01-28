using System;

public class SpringSeason
{
    public static void print()
    {
        Console.Write("Enter the month (as an integer 1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day (as an integer): ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }

    static bool IsSpringSeason(int month, int day)
    {
        if (month == 3 && day >= 20 && day <= 31)
            return true;
        if (month == 4 && day >= 1 && day <= 30)
            return true;
        if (month == 5 && day >= 1 && day <= 31)
            return true;
        if (month == 6 && day >= 1 && day <= 20)
            return true;

        return false;
    }
}
