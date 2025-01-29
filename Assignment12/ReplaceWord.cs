using System;

public class ReplaceWord
{
    public static void print()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = replaceWord(sentence, oldWord, newWord);
        Console.WriteLine($"Modified Sentence: {modifiedSentence}");
    }

    static string replaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        int i = 0, n = sentence.Length, oldLen = oldWord.Length;

        while (i < n)
        {
            bool match = true;
            if (i + oldLen <= n)
            {
                for (int j = 0; j < oldLen; j++)
                {
                    if (sentence[i + j] != oldWord[j])
                    {
                        match = false;
                        break;
                    }
                }
            }
            else
            {
                match = false;
            }

            if (match)
            {
                result += newWord;
                i += oldLen;
            }
            else
            {
                result += sentence[i];
                i++;
            }
        }

        return result;
    }
}
