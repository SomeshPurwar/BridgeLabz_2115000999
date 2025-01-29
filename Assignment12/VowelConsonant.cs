using System;

public class VowelConsonant
{
    public static void print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        
        int vowelCount = 0, consonantCount = 0;
        
        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                if ("aeiou".Contains(ch))
                    vowelCount++;
                else
                    consonantCount++;
            }
        }
        
        Console.WriteLine($"Vowels: {vowelCount}");
        Console.WriteLine($"Consonants: {consonantCount}");
    }
}
