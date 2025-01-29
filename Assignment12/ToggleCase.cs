using System;

public class ToggleCase
{
    public static void print()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string toggledString = toggleCase(input);

        Console.WriteLine("Toggled string: " + toggledString);
    }

    static string toggleCase(string input)
    {
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (Char.IsUpper(currentChar))
            {
                result += Char.ToLower(currentChar);
            }
            else if (Char.IsLower(currentChar))
            {
                result += Char.ToUpper(currentChar);
            }
            else
            {
                result += currentChar;
            }
        }

        return result;
    }
}
