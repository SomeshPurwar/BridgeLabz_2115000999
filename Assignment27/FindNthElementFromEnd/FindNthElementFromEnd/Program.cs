using System;
using System.Collections.Generic;

class FindNthFromEnd
{
    static string FindNthFromEndElement(LinkedList<string> list, int n)
    {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        
        for (int i = 0; i < n; i++)
        {
            if (first == null) return null; 
            first = first.Next;
        }

       
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return second != null ? second.Value : null;
    }

    static void Main()
    {
        LinkedList<string> linkedList = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        int n = 2;

        string nthFromEnd = FindNthFromEndElement(linkedList, n);

        if (nthFromEnd != null)
            Console.WriteLine($"The {n}th element from the end is: {nthFromEnd}");
        else
            Console.WriteLine("Invalid input: N is greater than the list size.");
    }
}
