using System;
using System.IO;

class Test9 {
    public static void Print() {
        string filePath = "largefile.txt";
        GenerateLargeFile(filePath);
        ReadLargeFile(filePath);
    }

    private static void GenerateLargeFile(string filePath) {
        try {
            using (StreamWriter writer = new StreamWriter(filePath)) {
                long targetSize = 500L * 1024 * 1024; // 500MB
                long currentSize = 0;
                string line;
                while (currentSize < targetSize) {
                    line = "This is a normal line.";
                    if (currentSize % (1024 * 10) == 0) {
                        line = "This is an error line.";
                    }
                    writer.WriteLine(line);
                    currentSize += line.Length + Environment.NewLine.Length;
                }
            }
            Console.WriteLine("Large file generated successfully.");
        } catch (IOException ex) {
            Console.WriteLine("File write error: " + ex.Message);
        }
    }

    private static void ReadLargeFile(string filePath) {
        try {
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0) {
                        Console.WriteLine(line);
                    }
                }
            }
        } catch (IOException ex) {
            Console.WriteLine("File read error: " + ex.Message);
        }
    }
}
