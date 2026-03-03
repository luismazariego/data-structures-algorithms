namespace AlgorithmsDataStructures.DataStructures;

/// <summary>
/// Insert anywhere
/// Dynamic size
/// Insert: (O(1))
/// 1. Create a new node
/// 2. Assign data to the next field
/// 3. Assign the head
/// Delete: (O(1))
/// 1. Assign temp variable
/// 2. Assign new head
/// 3. Return temp variable
/// ITerate: (O(n))
/// 1. Assign a current node
/// 2. while current node is not null
/// </summary>
public class LinkedLists
{
    public Node? Head { get; set; }

    public void InsertFirst(int data)
    {
        // create the node and insert data on it
        Node newNode = new Node(data);
        // set the old node in next
        newNode.Next = Head;
        // make the new node the head
        Head = newNode;
    }

    public Node DeleteFirst()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("List is empty");
        }
        // assign the head to a temp variable
        Node temp = Head;
        // assign the new head to the next node
        Head = Head.Next;
        // return the temp variable
        Console.WriteLine($"Deleted: {temp}");
        return temp;
    }
    
    public void DisplayList()
    {
        Node? current = Head;
        while (current != null)
        {
            Console.Write($"{current} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public void InsertLast(int data)
    {
        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        var newNode = new Node(data);
        current.Next = newNode;
    }
}

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}