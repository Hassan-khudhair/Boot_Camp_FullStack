using System;

// Define a DoublyNode class to represent each element in the doubly linked list
public class DoublyNode
{
    public int Data; // Data to store in the node
    public DoublyNode Next; // Pointer to the next node in the list
    public DoublyNode Prev; // Pointer to the previous node in the list

    // Constructor to initialize the node with data
    public DoublyNode(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}

// Define a DoublyLinkedList class to represent the doubly linked list
public class DoublyLinkedList
{
    private DoublyNode head; // Pointer to the head (first) node in the list

    // Method to insert a node at the beginning of the doubly linked list
    public void InsertAtBeginning(int data)
    {
        DoublyNode newNode = new DoublyNode(data);
        if (head != null)
        {
            head.Prev = newNode;
            newNode.Next = head;
        }
        head = newNode;
    }

    // Method to insert a node at the end of the doubly linked list
    public void InsertAtEnd(int data)
    {
        DoublyNode newNode = new DoublyNode(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            DoublyNode current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Prev = current;
        }
    }

    // Method to insert a node at a specific position in the doubly linked list
    public void InsertAtPosition(int data, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Position should be >= 1.");
            return;
        }

        if (position == 1)
        {
            InsertAtBeginning(data);
            return;
        }

        DoublyNode newNode = new DoublyNode(data);
        DoublyNode current = head;
        int count = 1;

        while (current != null && count < position - 1)
        {
            current = current.Next;
            count++;
        }

        if (current == null)
        {
            Console.WriteLine("The position is out of range.");
        }
        else
        {
            newNode.Next = current.Next;
            newNode.Prev = current;

            if (current.Next != null)
            {
                current.Next.Prev = newNode;
            }
            current.Next = newNode;
        }
    }

    // Method to delete a node with a specific value from the doubly linked list
    public void DeleteNode(int data)
    {
        if (head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        DoublyNode current = head;

        // If the node to be deleted is the head node
        if (current.Data == data)
        {
            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }
            return;
        }

        // Traverse the list to find the node to be deleted
        while (current != null && current.Data != data)
        {
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Node with value {0} not found.", data);
            return;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
    }

    // Method to display all the nodes in the doubly linked list
    public void Display()
    {
        DoublyNode current = head;

        if (head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        // Traverse through the list and print each node's data
        while (current != null)
        {
            Console.Write(current.Data + " <-> ");
            current = current.Next;
        }
        Console.WriteLine("null"); // Indicate the end of the list
    }
}

// Main class to test the DoublyLinkedList implementation
public class Program
{
    public static void Main(string[] args)
    {
        DoublyLinkedList linkedList = new DoublyLinkedList();

        // Insert nodes at the beginning
        linkedList.InsertAtBeginning(10);
        linkedList.InsertAtBeginning(20);

        // Insert nodes at the end
        linkedList.InsertAtEnd(30);
        linkedList.InsertAtEnd(40);

        // Insert a node at a specific position
        linkedList.InsertAtPosition(25, 3);

        // Display the linked list
        Console.WriteLine("Doubly linked list:");
        linkedList.Display();

        // Delete a node
        linkedList.DeleteNode(25);
        Console.WriteLine("Doubly linked list after deletion:");
        linkedList.Display();
    }
}
