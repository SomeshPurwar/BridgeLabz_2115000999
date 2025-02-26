using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSON
{
    public class MergeJSONFiles
    {
        public static void Print()
        {
            
            string file1Path = "D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\file1.json";
            string file2Path = "D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\file2.json";

            
            string json1 = File.ReadAllText(file1Path);
            string json2 = File.ReadAllText(file2Path);

            
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            
            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union // Ensures array values are combined
            });

            
            string mergedJson = obj1.ToString();

            
            Console.WriteLine("Merged JSON:");
            Console.WriteLine(mergedJson);

            
            File.WriteAllText("D:\\Dotnet Framework\\Assignment33\\JSON\\JSON\\merged.json", mergedJson);
        }
    }
}
