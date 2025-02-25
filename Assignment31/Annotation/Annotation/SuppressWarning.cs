using System;
using System.Collections;

public class SuppressWarning
{
    public static void Print()
    {
#pragma warning disable CS8600 // Suppress warnings related to type safety
        ArrayList list = new ArrayList();

        // Adding different types of data
        list.Add(10);   // int
        list.Add("Hello"); // string
        list.Add(3.14); // double

#pragma warning restore CS8600 // Re-enable warnings after the unchecked section

        // Displaying the contents of the ArrayList
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
