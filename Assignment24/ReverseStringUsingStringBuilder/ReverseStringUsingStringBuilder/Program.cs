using System;
using System.Text;

class Reverse
{
    static void Main()
    {
        string s = "Somesh";
        int len = s.Length;
        StringBuilder sb = new StringBuilder(len);
        for (int i = len - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        Console.WriteLine(sb.ToString());
    }

}
