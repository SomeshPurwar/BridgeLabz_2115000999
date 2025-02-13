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
}

class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        CustomStack stack = new CustomStack();

        for (int i = 0; i < n; i++)
        {
            while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            span[i] = stack.IsEmpty() ? (i + 1) : (i - stack.Peek());

            stack.Push(i);
        }

        return span;
    }
}

class Program
{
    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = StockSpan.CalculateSpan(prices);

        Console.WriteLine("Stock Prices: " + string.Join(", ", prices));
        Console.WriteLine("Stock Span:   " + string.Join(", ", span));
    }
}