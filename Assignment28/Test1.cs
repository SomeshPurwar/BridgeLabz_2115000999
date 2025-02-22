using System;
using System.IO;
class Test1{
    public static void Print(){
        string sourceFilePath = "source.txt";
        string destinationFilePath = "destination.txt";
        try
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                sourceStream.CopyTo(destinationStream);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally { 
        
        Console.ReadKey();
        }
    }
}
