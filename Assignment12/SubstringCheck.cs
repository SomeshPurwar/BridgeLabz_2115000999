using System;

public class SubstringCheck
{
    public static void print()
    {
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        Console.WriteLine("Enter the substring to search for:");
        string substring = Console.ReadLine();

        int count = CountSubstringOccurrences(mainString, substring);

        Console.WriteLine($"The substring '{substring}' appears {count} times in the main string.");
    }

    static int CountSubstringOccurrences(string mainString, string substring)
    {
        int count = 0;
        int index = 0;

        while ((index = mainString.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length; 
        }

        return count;
    }
}
