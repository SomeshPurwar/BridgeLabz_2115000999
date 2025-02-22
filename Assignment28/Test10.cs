using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Test10 {
    public static void Print() {
        string filePath = "test.txt";
        CountWordsInFile(filePath);
    }

      private static void CountWordsInFile(string filePath) {
        try {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] words = line.ToLower()
                                         .Split(new char[] { ' ', '\t', '\n', '\r', ',', '.', ';', '!', '?', ':', '"', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words) {
                        if (wordCount.ContainsKey(word)) {
                            wordCount[word]++;
                        } else {
                            wordCount[word] = 1;
                        }
                    }
                }
            }
            var topWords = wordCount.OrderByDescending(kvp => kvp.Value).Take(5);
            Console.WriteLine("Top 5 most frequent words:");
            foreach (var kvp in topWords) {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        } catch (IOException ex) {
            Console.WriteLine("File read error: " + ex.Message);
        }
    }
}
