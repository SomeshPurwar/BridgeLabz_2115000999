using System;


public class ReverseString
{
    public static void print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        string reversed = reverseString(input);
        
        Console.WriteLine($"Reversed String: {reversed}");
    }

    static string reverseString(string str)
    {
        char[] charArray = new char[str.Length];
        int i = 0;
        int j = str.Length - 1;
        
        while (j >= 0)
        {
            charArray[i] = str[j];
            i++;
            j--;
        }
        
        return new string(charArray);
    }
}
