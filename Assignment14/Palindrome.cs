using System;

public class Palindrome
{
    public static void print()
    {
        string input = GetInput();
        bool isPalindrome = CheckPalindrome(input);
        DisplayResult(input, isPalindrome);
    }

    static string GetInput()
    {
        Console.Write("Enter a string to check if it's a palindrome: ");
        return Console.ReadLine();
    }

    static bool CheckPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static void DisplayResult(string input, bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine($"\"{input}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is not a palindrome.");
        }
    }
}