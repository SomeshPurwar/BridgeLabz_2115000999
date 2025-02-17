using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadingComparison
{
    
    static void ReadWithStreamReader(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { } 
        }
    }

    
    static void ReadWithFileStream(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096]; 
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    
    static double MeasureExecutionTime(Action<string> method, string filePath)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        method(filePath);
        stopwatch.Stop();
        return (double)stopwatch.ElapsedTicks / Stopwatch.Frequency * 1000; 
    }

    static void Main()
    {
        string filePath = "largefile.bin"; 

        Console.WriteLine("File Size | StreamReader (ms) | FileStream (ms)");
        Console.WriteLine("----------------------------------------------");

        double streamReaderTime = MeasureExecutionTime(ReadWithStreamReader, filePath);
        double fileStreamTime = MeasureExecutionTime(ReadWithFileStream, filePath);

        Console.WriteLine($" 500MB    | {streamReaderTime,15:F4} | {fileStreamTime,12:F4}");
    }
}
//using System;
//using System.IO;

//class GenerateLargeFile
//{
//    static void Main()
//    {
//        string filePath = "largefile.bin";
//        long fileSize = 500 * 1024 * 1024; // 500MB

//        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
//        {
//            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
//            for (int i = 0; i < fileSize / buffer.Length; i++)
//            {
//                fs.Write(buffer, 0, buffer.Length);
//            }
//        }
//        Console.WriteLine("500MB file created successfully.");
//    }
//}
