using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON
{
    public class MergeJSON
    {
        public static void Print()
        {
            
            string json1 = @"{
                ""name"": ""Somesh Purwar"",
                ""email"": ""somesh.purwar20@gmail.com""
            }";

            
            string json2 = @"{
                ""age"": 21,
                ""address"": ""Jhansi""
            }";

            
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            // Merge obj2 into obj1
            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union 
            });

            
            string mergedJson = JsonConvert.SerializeObject(obj1, Formatting.Indented);

            
            Console.WriteLine(mergedJson);
        }
    }
}
