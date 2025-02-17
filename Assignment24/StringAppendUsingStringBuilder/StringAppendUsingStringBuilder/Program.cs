using System;
using System.Text;

class StringConcatenation
{
    static string ConcatenateStrings(string[] words)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string word in words)
        {
            sb.Append(word);
        }

        return sb.ToString();
    }

    static void Main()
    {
        string[] words = { "Hello", " ", "World", "!", " Welcome", " to", " C#." };
        string result = ConcatenateStrings(words);

        Console.WriteLine("Concatenated String: " + result);
    }
}
