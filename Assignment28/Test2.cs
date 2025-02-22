using System;
using System.IO;
using System.Diagnostics;

class Test2 {
    public static void Print() {
        string sourceFilePath = "source.txt";
        string destinationBufferedFilePath = "destination_buffered.txt";
        string destinationUnbufferedFilePath = "destination_unbuffered.txt";

        try {
            if (!File.Exists(sourceFilePath)) {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
        
            stopwatch.Start();
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationBufferedFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream, 4096))
            using (BufferedStream bufferedDestination = new BufferedStream(destinationStream, 4096))
            {
                bufferedSource.CopyTo(bufferedDestination);
            }
            stopwatch.Stop();
            Console.WriteLine($"Buffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationUnbufferedFilePath, FileMode.Create, FileAccess.Write))
            {
                sourceStream.CopyTo(destinationStream);
            }
            stopwatch.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");

        } catch (IOException ex) {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
