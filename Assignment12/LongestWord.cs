using System;
public class LongestWord
{
	public static void print(){
		Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word is: " + longestWord);
		
	}
	
	static string FindLongestWord(string sentence)
    {
        string longestWord = "";
        string currentWord = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            char currentChar = sentence[i];

            if (Char.IsLetterOrDigit(currentChar))
            {
                currentWord += currentChar;
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }
}