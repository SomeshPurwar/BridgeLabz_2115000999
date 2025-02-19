using System;
using System.Collections.Generic;

class InvertDictionary
{
    static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> inputMap)
    {
        Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

        foreach (var entry in inputMap)
        {
            string key = entry.Key;
            int value = entry.Value;

            if (!invertedMap.ContainsKey(value))
            {
                invertedMap[value] = new List<string>();
            }

            invertedMap[value].Add(key);
        }

        return invertedMap;
    }

    static void Main()
    {
      
        Dictionary<string, int> inputMap = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        
        Dictionary<int, List<string>> invertedMap = InvertMap(inputMap);

        
        foreach (var entry in invertedMap)
        {
            Console.WriteLine($"{entry.Key}=[{string.Join(", ", entry.Value)}]");
        }
    }
}
