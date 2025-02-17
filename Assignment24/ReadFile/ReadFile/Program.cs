using System;
using System.IO;

class ReadFileExample
{
    static void Main()
    {
        string filePath = "D:\\Dotnet Framework\\Assignment24\\ReadFile\\ReadFile\\file.txt";

        try
        {
            
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
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
    }
}
