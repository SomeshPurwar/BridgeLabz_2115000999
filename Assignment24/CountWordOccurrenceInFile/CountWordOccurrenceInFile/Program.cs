using System;
using System.IO;

class WordCounter
{
    static int CountWordOccurrences(string filePath, string targetWord)
    {
        int count = 0;

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Equals(targetWord, StringComparison.OrdinalIgnoreCase))                         {
                            count++;
                        }
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }

        return count;
    }

    static void Main()
    {
        string filePath = "D:\\Dotnet Framework\\Assignment24\\CountWordOccurrenceInFile\\CountWordOccurrenceInFile\\file.txt"; 
        string targetWord = "C#"; 

        int occurrences = CountWordOccurrences(filePath, targetWord);
        Console.WriteLine($"The word \"{targetWord}\" appears {occurrences} times in the file.");
    }
}
