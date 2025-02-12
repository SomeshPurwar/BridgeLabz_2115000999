class Node
{
    public int data;
    public Node Next;
    public Node Prev;
    public Node(int data)
    {
        this.data = data;
        Next = Prev=null;
    }
}

class DoublyLinkedList
{

    static Node InsertAtBeginning(Node head, int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;

        if (head != null)
        {
            head.Prev= newNode;
        }
        return newNode;
    }

    static Node InsertAtEnd(Node head, int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            newNode.Prev = null;
            head = newNode;
            return head;

        }
        Node curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
        }
        curr.Next = newNode;
        newNode.Prev = curr;
        return head;
    }

    static Node InsertAtAnyPosition(Node head, int data, int pos)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            return newNode;
        }

        if (pos < 1) { Console.WriteLine("Invalid Position."); return head; }
        if (pos == 1)
        {
            return InsertAtBeginning(head, data);
        }

        Node curr = head;
        for (int i = 1; i < pos - 1 && curr != null; i++)
        {
            curr = curr.Next;
        }
        if (curr == null)
        {
            Console.WriteLine("Invalid Position");
            return head;
        }
        newNode.Prev = curr;
        newNode.Next = curr.Next;
        curr.Next = newNode;

        if (newNode.Next != null)
        {
            newNode.Next.Prev = newNode;
        }
        return head;
    }

    static Node DeleteFromBeginning(Node head) 
    {
        if (head == null) return null;
        if(head.Next==null) return null;
        else
        {
            head = head.Next;
            head.Prev = null;
            return head;
        }
    }

    static Node DeleteFromEnd(Node head)
    {
        if (head == null) return null;
        if (head.Next == null) return null;
        Node curr = head;
        while (curr.Next != null)
        {
            curr = curr.Next;
        }
        curr.Prev.Next = null;
        return head;
    }

    static Node DeleteFromAnyPosition(Node head, int pos)
    {
        if (head == null) return null;
        if (pos == 1) return DeleteFromBeginning(head);
        Node curr = head;
        for(int i=1;i<pos && curr != null; i++)
        {
            curr = curr.Next;
        }
        if (curr == null) return head;
        if (curr.Prev != null)
        {
            curr.Prev.Next = curr.Next;

        }
        if (curr.Next != null) curr.Next.Prev = curr.Prev;

        return head;
    }
    static void Display(Node head)
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
        Node head = null;
        head = InsertAtBeginning(head, 1);
        head = InsertAtBeginning(head, 2);
        head = InsertAtBeginning(head, 3);
        head= InsertAtEnd(head, 4);
        head = InsertAtAnyPosition(head, 5, 5);
        head=DeleteFromBeginning(head);
        head = DeleteFromEnd(head);
        head = DeleteFromAnyPosition(head, 3);


        Display(head);



    }
}