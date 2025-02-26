using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace JSON
{
    public class CSVtoJSON
    {
        public static void Print()
        {
            
            string csvFilePath = "D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\sample.csv";

            // Read CSV and convert to JSON
            string json = ConvertCsvToJson(csvFilePath);

           
            Console.WriteLine("Converted JSON:");
            Console.WriteLine(json);
        }

        public static string ConvertCsvToJson(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
               
                var records = csv.GetRecords<dynamic>();

                
                return JsonConvert.SerializeObject(records, Formatting.Indented);
            }
        }
    }
}
