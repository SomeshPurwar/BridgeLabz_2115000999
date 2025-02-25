using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class FileProcessor
    {
        public static void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public static string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new IOException("File not found.");
            }
            return File.ReadAllText(filename);
        }
    }
}
