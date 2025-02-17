using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "sample.bin";

        // Create a binary file with some text content
        WriteBinaryFile(filePath);

        // Read the binary file and print as characters
        ReadBinaryFile(filePath);
    }

    static void WriteBinaryFile(string filePath)
    {
        string text = "Hello, this is a test file!";
        byte[] data = Encoding.UTF8.GetBytes(text);

        // Write to binary file
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            fs.Write(data, 0, data.Length);
        }

        Console.WriteLine("Binary file created successfully.");
    }

    static void ReadBinaryFile(string filePath)
    {
        try
        {
            // Open binary file
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
