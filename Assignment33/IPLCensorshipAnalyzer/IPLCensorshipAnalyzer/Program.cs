using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IPLCensorshipAnalyzer
{
    class Program
    {
        static void Main()
        {
            
            string jsonInputPath = "D:\\Dotnet Framework\\Assignment33\\IPLCensorshipAnalyzer\\IPLCensorshipAnalyzer\\IPLInput.json";
            string csvInputPath = "D:\\Dotnet Framework\\Assignment33\\IPLCensorshipAnalyzer\\IPLCensorshipAnalyzer\\IPLInput.csv";
            string jsonOutputPath = "D:\\Dotnet Framework\\Assignment33\\IPLCensorshipAnalyzer\\IPLCensorshipAnalyzer\\IPL_Censored.json";
            string csvOutputPath = "D:\\Dotnet Framework\\Assignment33\\IPLCensorshipAnalyzer\\IPLCensorshipAnalyzer\\IPL_Censored.csv";

            
            ProcessJson(jsonInputPath, jsonOutputPath);

            
            ProcessCsv(csvInputPath, csvOutputPath);

            Console.WriteLine("Censorship process completed successfully!");
        }

        // Function to process JSON file
        static void ProcessJson(string inputPath, string outputPath)
        {
            string jsonData = File.ReadAllText(inputPath);
            var matches = JsonConvert.DeserializeObject<List<Match>>(jsonData);

            foreach (var match in matches)
            {
                match.ApplyCensorship();
            }

            string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);
            File.WriteAllText(outputPath, censoredJson);
            Console.WriteLine($"Censored JSON saved to {outputPath}");
        }

        // Function to process CSV file
        static void ProcessCsv(string inputPath, string outputPath)
        {
            using (var reader = new StreamReader(inputPath))
            using (var csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var matches = new List<MatchCsv>();
                var records = csvReader.GetRecords<MatchCsv>();

                foreach (var match in records)
                {
                    match.ApplyCensorship();
                    matches.Add(match);
                }

                using (var writer = new StreamWriter(outputPath))
                using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csvWriter.WriteRecords(matches);
                }
                Console.WriteLine($"Censored CSV saved to {outputPath}");
            }
        }
    }

    // Match class for JSON processing
    public class Match
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public Dictionary<string, int> score { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }

        public void ApplyCensorship()
        {
            team1 = CensorTeamName(team1);
            team2 = CensorTeamName(team2);
            winner = CensorTeamName(winner);
            player_of_match = "REDACTED";

            // Censor team names inside the score dictionary
            var newScore = new Dictionary<string, int>();
            foreach (var entry in score)
            {
                newScore[CensorTeamName(entry.Key)] = entry.Value;
            }
            score = newScore;
        }

        private string CensorTeamName(string name)
        {
            var words = name.Split(' ');
            if (words.Length > 1)
                words[1] = "***";  // Replace second word with "***"
            return string.Join(" ", words);
        }
    }

    // MatchCsv class for CSV processing
    public class MatchCsv
    {
        public int match_id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public int score_team1 { get; set; }
        public int score_team2 { get; set; }
        public string winner { get; set; }
        public string player_of_match { get; set; }

        public void ApplyCensorship()
        {
            team1 = CensorTeamName(team1);
            team2 = CensorTeamName(team2);
            winner = CensorTeamName(winner);
            player_of_match = "REDACTED";
        }

        private string CensorTeamName(string name)
        {
            var words = name.Split(' ');
            if (words.Length > 1)
                words[1] = "***";  // Replace second word with "***"
            return string.Join(" ", words);
        }
    }
}
