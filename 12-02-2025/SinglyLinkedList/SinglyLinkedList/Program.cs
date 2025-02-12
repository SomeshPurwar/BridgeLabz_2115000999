using System.ComponentModel.DataAnnotations;

public class Node
{
    public int data;
    public Node Next;
    public Node(int data)
    {
        this.data = data;
        this.Next = null;
    }
}

public class SinglyLinkedList
{
    public static Node InsertAtBeginning(Node head, int data)
    {
        Node newNode = new Node(data);
        if (head == null) { return newNode; }
        newNode.Next = head;
        head = newNode;
        return head ;
    }

    public static Node InsertAtEnd(Node head, int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            return newNode;
        }

        Node curr = head;
        while(curr.Next != null) 

        {
            curr= curr.Next;
            
        }
        curr.Next = newNode;
        return head;
    }

    public static Node InsertAtAnyPosition(Node head, int data, int pos)
    {
        if (pos < 1)
        {
            Console.WriteLine("Invalid Position");
            return head;
        }

        if (pos == 1)
        {
            return InsertAtBeginning(head, data);
        }

        Node curr = head;
        for(int i = 1; i < pos - 1 && curr!=null; i++)
        {
            curr= curr.Next;
        }
        if (curr == null)
        {
            Console.WriteLine("Invalid Position");
            return head;
        }
        Node newNode = new Node(data);
        newNode.Next = curr.Next;
        curr.Next= newNode;
        return head;
    }

    static Node DeleteFromBeginning(Node head)
    {
        if (head == null) { return null; }
        head = head.Next;
        return head;
    }

    static Node DeleteFromEnd(Node head)
    {
        if (head == null || head.Next==null )
        {
            return null;
        }
        Node curr = head;
        while (curr.Next.Next != null)
        {
            curr = curr.Next;
        }
        curr.Next = null;
        return head;

    }

    static Node DeleteFromAnyPosition(Node head, int pos)
    {
        if (pos < 1)
        {
            Console.WriteLine("Invalid Position");
            return head;
        }

        if (pos == 1)
        {            
            head = head.Next;           
            return head;
        }

        Node curr = head;
        for(int i = 1; i < pos - 1&& curr.Next!=null; i++)
        {
            curr = curr.Next;
        }
        if (curr == null || curr.Next==null) { Console.WriteLine("Invalid"); return head; }

        curr.Next = curr.Next.Next;
        return head;

    }



    public static void Display(Node head)
    {
        Node curr = head;
        while (curr != null) 
        {
            Console.WriteLine(curr.data);
            curr = curr.Next;        
        }
    }


    static void Main()
    {
        Node head=null;

        head = InsertAtBeginning(head, 1);
        head = InsertAtBeginning(head, 2);
        head = InsertAtBeginning(head, 5);
        head = InsertAtEnd(head, 3);
        head = InsertAtAnyPosition(head, 4, 2);
        head = DeleteFromBeginning(head);
        head = DeleteFromEnd(head);
        head = DeleteFromAnyPosition(head, 1);

        Display(head);

    }
}

