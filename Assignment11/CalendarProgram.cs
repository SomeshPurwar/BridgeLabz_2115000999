using System;

public class CalendarProgram
{
    public static string GetMonthName(int month)
    {
        string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        return months[month];
    }

    public static int GetDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return daysInMonth[month];
    }

    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
        else
            return false;
    }

    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine($"      {monthName} {year}");
        Console.WriteLine(" Su Mo Tu We Th Fr Sa");

        int day = 1;
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (i == 0 && j < firstDay)
                {
                    Console.Write("   ");
                }
                else if (day <= daysInMonth)
                {
                    Console.Write($"{day,3}");
                    day++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }

    public static void print()
    {
        Console.Write("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
