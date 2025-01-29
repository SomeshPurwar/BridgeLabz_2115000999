using System;

public class Anagram
{
    public static void print()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (areAnagrams(str1, str2))
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }

    static bool areAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        int[] charCounts = new int[256];

        foreach (char c in str1)
            charCounts[c]++;

        foreach (char c in str2)
        {
            charCounts[c]--;
            if (charCounts[c] < 0)
                return false;
        }

        return true;
    }
}
