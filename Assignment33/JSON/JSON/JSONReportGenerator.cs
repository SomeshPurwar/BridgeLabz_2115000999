using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace JSON
{
    class JsonReportGenerator
    {
        public static void Print()
        {
            // Simulating database records as a list of objects
            List<Stud> students = new List<Stud>
            {
                new Stud { Id = 1, Name = "Somesh Purwar", Age = 21, Email = "somesh@example.com" },
                new Stud { Id = 2, Name = "Rahul Sharma", Age = 22, Email = "rahul@example.com" },
                new Stud { Id = 3, Name = "Priya Singh", Age = 20, Email = "priya@example.com" }
            };


            string jsonReport = JsonConvert.SerializeObject(students, Formatting.Indented);

            
            string filePath = "D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\StudentReport.json";
            File.WriteAllText(filePath, jsonReport);

            Console.WriteLine($"JSON Report generated successfully: {filePath}");
        }
    }

    
    public class Stud
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
