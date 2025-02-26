using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSON
{
    public class ReadJson
    {
        public static void Print()
        {
            string filePath = "D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\three.json"; 

            try
            {
                
                string jsonData = File.ReadAllText(filePath);

                
                JObject jsonObject = JObject.Parse(jsonData);

                
                string name = jsonObject["Name"]?.ToString();
                string age = jsonObject["Age"]?.ToString();

               
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading JSON: {ex.Message}");
            }
        }
    }
}
