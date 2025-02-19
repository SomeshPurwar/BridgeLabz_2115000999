using System;
using System.Collections.Generic;

class FrequencyCounter
{
    static Dictionary<string, int> CountFrequency(List<string> words)
    {
        Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequencyMap.ContainsKey(word))
                frequencyMap[word]++;
            else
                frequencyMap[word] = 1;
        }

        return frequencyMap;
    }

    static void Main()
    {
        List<string> words = new List<string> { "apple", "banana", "apple", "orange" };

        Dictionary<string, int> frequency = CountFrequency(words);

        Console.WriteLine("Frequency of elements:");
        foreach (var item in frequency)
        {
            Console.WriteLine($"\"{item.Key}\": {item.Value}");
        }
    }
}
