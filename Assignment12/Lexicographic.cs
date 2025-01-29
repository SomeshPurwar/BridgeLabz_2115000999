using System;

public class Lexicographic
{
    public static void print()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        string result = CompareStringsLexicographically(str1, str2);

        Console.WriteLine(result);
    }

    static string CompareStringsLexicographically(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                return $"\"{str1}\" comes before \"{str2}\" in lexicographical order";
            }
            else if (str1[i] > str2[i])
            {
                return $"\"{str1}\" comes after \"{str2}\" in lexicographical order";
            }
        }

        if (str1.Length < str2.Length)
        {
            return $"\"{str1}\" comes before \"{str2}\" in lexicographical order";
        }
        else if (str1.Length > str2.Length)
        {
            return $"\"{str1}\" comes after \"{str2}\" in lexicographical order";
        }
        else
        {
            return $"\"{str1}\" is equal to \"{str2}\"";
        }
    }
}
