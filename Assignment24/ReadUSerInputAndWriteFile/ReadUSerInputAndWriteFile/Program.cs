using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "user_input.txt";

        Console.WriteLine("Enter text to save to file (type 'exit' to finish):");

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                        break;

                    writer.WriteLine(input);
                }
            }

            Console.WriteLine($"User input saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to file: " + ex.Message);
        }
    }
}
