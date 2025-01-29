using System;

public class RemoveDuplicate
{
    public static void print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string result = RemoveDuplicates(input);
        Console.WriteLine($"String after removing duplicates: {result}");
    }

    static string RemoveDuplicates(string str)
    {
        string result = "";
        
        for (int i = 0; i < str.Length; i++)
        {
            if (result.IndexOf(str[i]) == -1)
            {
                result += str[i];
            }
        }
        
        return result;
    }
}