using System;
using System.Collections.Generic;
using System.IO;

class WordFrequencyCounter
{
    static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string text = File.ReadAllText(filePath).ToLower(); // Convert to lowercase

        string word = "";
        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))  // Build a word using only letters/numbers
            {
                word += c;
            }
            else if (word.Length > 0) // If non-alphabetic character appears, process the word
            {
                if (wordFrequency.ContainsKey(word))
                    wordFrequency[word]++;
                else
                    wordFrequency[word] = 1;

                word = ""; // Reset for next word
            }
        }

        // Add the last word if it exists
        if (word.Length > 0)
        {
            if (wordFrequency.ContainsKey(word))
                wordFrequency[word]++;
            else
                wordFrequency[word] = 1;
        }

        return wordFrequency;
    }

    static void Main()
    {
        string filePath = "D:\\Dotnet Framework\\Assignment27\\WordCountFromFile\\WordCountFromFile\\sample.txt"; 

        if (File.Exists(filePath))
        {
            Dictionary<string, int> wordCounts = CountWordFrequency(filePath);

          
            foreach (var entry in wordCounts)
            {
                Console.WriteLine($"'{entry.Key}': {entry.Value}");
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
