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
    int sz;

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
        sz++;
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

// Queue using two custom stacks
class QueueUsingCustomStacks
{
    private CustomStack stack1;
    private CustomStack stack2;

    public QueueUsingCustomStacks()
    {
        stack1 = new CustomStack();
        stack2 = new CustomStack();
    }

    // Enqueue operation
    public void Enqueue(int item)
    {
        stack1.Push(item);
    }

    // Dequeue operation 
    public int Dequeue()
    {
        if (IsEmpty()) return -1;  

        if (stack2.IsEmpty())
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Pop();
    }

    // Peek operation 
    public int Peek()
    {
        if (IsEmpty()) return -1;  

        if (stack2.IsEmpty())
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Peek();
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return stack1.IsEmpty() && stack2.IsEmpty();
    }

    // Size operation
    public int Size()
    {
        return stack1.Size() + stack2.Size();
    }
}

// Main program to test the queue
class Program
{
    static void Main()
    {
        QueueUsingCustomStacks queue = new QueueUsingCustomStacks();

        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Peek());    

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Console.WriteLine(queue.Size());

        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Peek());    
        Console.WriteLine(queue.Dequeue()); 

        queue.Enqueue(40);
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Size());
    }
}
