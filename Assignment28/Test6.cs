using System;
using System.IO;

class Test6 {
    public static void Print() {
        string inputFilePath = "source.txt";
        string outputFilePath = "output.txt";

        try {
            ConvertUppercaseToLowercase(inputFilePath, outputFilePath);
            Console.WriteLine("File successfully converted to lowercase and written to output file.");
        } catch (Exception ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    private static void ConvertUppercaseToLowercase(string inputFilePath, string outputFilePath) {
        if (!File.Exists(inputFilePath)) {
            throw new FileNotFoundException("File not found: " + inputFilePath);
        }

        using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedInput = new BufferedStream(inputStream))
        using (StreamReader reader = new StreamReader(bufferedInput))
        using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedOutput = new BufferedStream(outputStream))
        using (StreamWriter writer = new StreamWriter(bufferedOutput)) {
            while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                writer.WriteLine(line.ToLower());
            }
        }
    }
}