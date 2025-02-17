using System;
using System.Text;
using System.Diagnostics;

class StringPerformanceComparison
{
    static void Main()
    {
        int iterations = 100000; 

        // Measure time taken for string concatenation using '+'
        Stopwatch sw1 = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "A"; 
        }
        sw1.Stop();
        Console.WriteLine("String Concatenation Time: " + sw1.ElapsedMilliseconds + " ms");

        // Measure time taken for StringBuilder
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("A");
        }
        string finalResult = sb.ToString(); 
        sw2.Stop();
        Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
    }
}
