using System;
using System.Collections.Generic;

class ReverseListExample
{
    // Reverse a List<int>
    static void ReverseList(List<int> list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
          
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    // Reverse a LinkedList<int>
    static void ReverseLinkedList(LinkedList<int> list)
    {
        LinkedListNode<int> start = list.First;
        LinkedListNode<int> end = list.Last;

        int left = 0, right = list.Count - 1;

        while (left < right)
        {
         
            int temp = start.Value;
            start.Value = end.Value;
            end.Value = temp;

           
            start = start.Next;
            end = end.Previous;

            left++;
            right--;
        }
    }

    static void Main()
    {
  
        List<int> arrayList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original List: " + string.Join(", ", arrayList));
        ReverseList(arrayList);
        Console.WriteLine("Reversed List: " + string.Join(", ", arrayList));

        
        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("\nOriginal LinkedList: " + string.Join(", ", linkedList));
        ReverseLinkedList(linkedList);
        Console.WriteLine("Reversed LinkedList: " + string.Join(", ", linkedList));
    }
}
