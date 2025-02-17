using System;
using System.Text;

class RemoveDuplicates
{
    static string RemoveDuplicate(string input)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            bool isDuplicate = false;

            for (int j = 0; j < sb.Length; j++)
            {
                if (sb[j] == currentChar)
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                sb.Append(currentChar);
            }
        }

        return sb.ToString();
    }

    static void Main()
    {
        string input = "ababcddefggh";
        string result = RemoveDuplicate(input);
        Console.WriteLine("Original: " + input);
        Console.WriteLine("Without Duplicates: " + result);
    }
}
