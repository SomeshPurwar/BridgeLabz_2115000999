using System;

public class RemoveCharacter
{
    public static void print()
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string modifiedString = removeCharacter(input, charToRemove);
        Console.WriteLine($"Modified String: {modifiedString}");
    }

    static string removeCharacter(string str, char ch)
    {
        string result = "";
        foreach (char c in str)
        {
            if (c != ch)
            {
                result += c;
            }
        }
        return result;
    }
}
