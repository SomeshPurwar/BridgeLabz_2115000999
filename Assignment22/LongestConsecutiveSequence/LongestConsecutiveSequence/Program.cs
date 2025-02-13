using System;

// Node class for key-value pair in linked list
class Node
{
    public int Key;
    public int Value;
    public Node Next;

    public Node(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

// Custom HashMap Implementation
class CustomHashMap
{
    private const int SIZE = 100; // Hash table size
    private Node[] table;

    public CustomHashMap()
    {
        table = new Node[SIZE];
    }

    // Hash function
    private int GetHash(int key)
    {
        return key % SIZE;
    }

    // Insert or update key-value pair
    public void Put(int key, int value)
    {
        int index = GetHash(key);
        Node head = table[index];

        // If bucket is empty, insert new node
        if (head == null)
        {
            table[index] = new Node(key, value);
            return;
        }

        // Traverse linked list to find key or last node
        Node current = head;
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }
            if (current.Next == null) break;
            current = current.Next;
        }

        // Insert new node at end of list (separate chaining)
        current.Next = new Node(key, value);
    }

    // Get value associated with a key
    public int Get(int key)
    {
        int index = GetHash(key);
        Node current = table[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;
            current = current.Next;
        }

        return -1;
    }

    // Remove a key from the hash map
    public void Remove(int key)
    {
        int index = GetHash(key);
        Node current = table[index];
        Node prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                    table[index] = current.Next;
                else
                    prev.Next = current.Next;

                return;
            }
            prev = current;
            current = current.Next;
        }
    }

    // Check if key exists in hash map
    public bool ContainsKey(int key)
    {
        return Get(key) != -1;
    }
}

class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        CustomHashMap map = new CustomHashMap();

        
        foreach (int num in nums)
        {
            map.Put(num, 1);
        }

        int longest = 0;

        foreach (int num in nums)
        {
           
            if (!map.ContainsKey(num - 1))
            {
                int currentNum = num;
                int streak = 1;

       
                while (map.ContainsKey(currentNum + 1))
                {
                    currentNum++;
                    streak++;
                }

                longest = Math.Max(longest, streak);
            }
        }

        return longest;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2, 5, 6 };
        Console.WriteLine("Longest Consecutive Sequence Length: " + FindLongestConsecutiveSequence(arr));
    }
}