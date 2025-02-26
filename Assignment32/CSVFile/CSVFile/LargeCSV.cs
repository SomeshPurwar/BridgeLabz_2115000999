using System;
using System.IO;

class LargeCSVReader
{
    public static void Print()
    {
        string filePath = "large_data.csv";
        int batchSize = 100;
        int totalRecordsProcessed = 0;

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string header = reader.ReadLine(); 
            string line;
            int batchCount = 0;

            while ((line = reader.ReadLine()) != null)
            {
                batchCount++;
                totalRecordsProcessed++;

                // Simulate processing (printing first record of each batch)
                if (batchCount == 1)
                    Console.WriteLine($"Processing: {line}");

                // Process in chunks of batchSize
                if (batchCount == batchSize)
                {
                    Console.WriteLine($"Processed {totalRecordsProcessed} records so far...");
                    batchCount = 0; // Reset batch count
                }
            }
        }

        Console.WriteLine($"Total records processed: {totalRecordsProcessed}");
    }
}

//class GenerateLargeCSV
//{
//    // Creating file
//    public static void Print()
//    {
//        string filePath = "large_data.csv";
//        int totalRecords = 5_000_000; // Adjust this number to increase file size
//        Random random = new Random();

//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            // Write header
//            writer.WriteLine("ID,Name,Age,Salary");

//            // Generate and write data
//            for (int i = 1; i <= totalRecords; i++)
//            {
//                string name = $"User{i}";
//                int age = random.Next(18, 65);
//                int salary = random.Next(30_000, 200_000);

//                writer.WriteLine($"{i},{name},{age},{salary}");

//                // Show progress every 500,000 records
//                if (i % 500_000 == 0)
//                {
//                    Console.WriteLine($"{i} records written...");
//                }
//            }
//        }

//        Console.WriteLine($"Large CSV file generated: {filePath}");
//    }
//}
