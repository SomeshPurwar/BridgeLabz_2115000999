using System;

class Program
{
    static void Main()
    {
        string[] sentences = {
            "The quick brown fox jumps over the lazy dog.",
            "Learning C# is fun and interesting.",
            "This is a sample sentence.",
            "Coding helps improve problem-solving skills.",
            "Practice makes perfect."
        };

        Console.Write("Enter a word to search for: ");
        string word = Console.ReadLine();

        string result = FindSentenceWithWord(sentences, word);

        if (result != null)
            Console.WriteLine($"First sentence containing '{word}':\n{result}");
        else
            Console.WriteLine($"No sentence found containing the word '{word}'.");
    }

    static string FindSentenceWithWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                return sentence;
        }

        return null;
    }
}
