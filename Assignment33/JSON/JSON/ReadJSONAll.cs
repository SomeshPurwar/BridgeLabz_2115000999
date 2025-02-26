using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSON
{
    public class ReadJSONAll
    {
        public static void Print()
        {

            string filePath = "D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\three.json";
            string jsonContent = File.ReadAllText(filePath);

            
            JToken json = JToken.Parse(jsonContent);


            PrintJson(json, "");
        }

        
        public static void PrintJson(JToken token, string indent)
        {
            if (token is JObject obj)
            {
                foreach (var property in obj.Properties())
                {
                    Console.WriteLine($"{indent}{property.Name}:");
                    PrintJson(property.Value, indent + "  ");
                }
            }
            else if (token is JArray array)
            {
                int index = 0;
                foreach (var item in array)
                {
                    Console.WriteLine($"{indent}[{index}]:");
                    PrintJson(item, indent + "  ");
                    index++;
                }
            }
            else
            {
                Console.WriteLine($"{indent}{token}");
            }
        }
    }
}
