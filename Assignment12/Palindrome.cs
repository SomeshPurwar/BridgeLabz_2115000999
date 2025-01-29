using System;


public class Palindrome
{
    public static void print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
		
		if (IsPalindrome(input))
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
		
    }
	

    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (char.ToLower(str[left]) != char.ToLower(str[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}
