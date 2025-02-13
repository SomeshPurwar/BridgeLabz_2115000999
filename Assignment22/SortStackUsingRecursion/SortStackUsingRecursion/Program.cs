using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

// Custom Stack Implementation
class CustomStack
{
    private Node top;
    private int sz;  

    public CustomStack()
    {
        top = null;
        sz = 0;  
    }

    // Push operation
    public void Push(int item)
    {
        Node newNode = new Node(item);
        newNode.Next = top;
        top = newNode;
        sz++;  // Increment size
    }

    // Pop operation 
    public int Pop()
    {
        if (IsEmpty()) return -1;

        int item = top.Data;
        top = top.Next;
        sz--;  
        return item;
    }

    // Peek operation 
    public int Peek()
    {
        if (IsEmpty()) return -1;

        return top.Data;
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == null;
    }

    // Size operation
    public int Size()
    {
        return sz;
    }

    // Insert element in sorted order
    private void SortedInsert(int element)
    {
        if (IsEmpty() || Peek() <= element)
        {
            Push(element);
            return;
        }

        int temp = Pop();
        SortedInsert(element);
        Push(temp);
    }

    // Sort stack using recursion
    public void SortStack()
    {
        if (!IsEmpty())
        {
            int temp = Pop();
            SortStack();
            SortedInsert(temp);
        }
    }

    // Print stack elements
    public void PrintStack()
    {
        Node current = top;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CustomStack stack = new CustomStack();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        stack.Push(5);

        Console.WriteLine("Original Stack:");
        stack.PrintStack();
        Console.WriteLine("Size: " + stack.Size());

        stack.SortStack();

        Console.WriteLine("Sorted Stack:");
        stack.PrintStack();
        Console.WriteLine("Size: " + stack.Size());
    }
}
