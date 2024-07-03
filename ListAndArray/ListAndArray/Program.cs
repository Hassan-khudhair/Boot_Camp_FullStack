// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

// 1. Write a  c# program to create and display a Singly Linked List.
/*
namespace ListAndArray
{
    // Define a Node class to represent each element in the linked list
    public class Node
    {
        public int Data; // Data to store in the node
        public Node Next; // Pointer to the next node in the list

        // Constructor to initialize the node with data
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    // Define a LinkedList class to represent the singly linked list
    public class LinkedList
    {
        private Node head; // Pointer to the head (first) node in the list

        // Method to add a node to the end of the linked list
        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode; // If the list is empty, set the head to the new node
            }
            else
            {
                Node current = head;
                // Traverse to the end of the list
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Append the new node at the end of the list
                current.Next = newNode;
            }
        }

        // Method to display all the nodes in the linked list
        public void Display()
        {
            Node current = head;

            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Traverse through the list and print each node's data
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null"); // Indicate the end of the list
        }
    }

    // Main class to test the LinkedList implementation
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            // Add some nodes to the linked list
            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);
            linkedList.AddNode(40);

            // Display the linked list
            linkedList.Display();
        }
    }
}
*/






// 2. Write a  c# program to create a singly linked list of n nodes 
//    and display it in reverse order.

/*
namespace ListAndArray
{
    public class Node
    {
        public int Data; 
        public Node Next; 
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node head; 
        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode; 
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void DisplayReverse()
        {
            Stack<int> stack = new Stack<int>();
            Node current = head;

            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            while (current != null)
            {
                stack.Push(current.Data);
                current = current.Next;
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " -> ");
            }
            Console.WriteLine("null"); 
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            int n;

            Console.Write("Enter the number of nodes: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter value for node {i}: ");
                int value = int.Parse(Console.ReadLine());
                linkedList.AddNode(value);
            }

            // Display the linked list in reverse order
            Console.WriteLine("Linked list in reverse order:");
            linkedList.DisplayReverse();
        }
    }
}*/







// 3. Write a  c# program to create a singly linked list of n nodes 
//    and count the number of nodes.
/*
namespace ListAndArray
{
    public class Node
    {
        public int Data; 
        public Node Next; 

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node head; 
        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode; 
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Method to count the number of nodes in the linked list
        public int CountNodes()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
        public void Display()
        {
            Node current = head;

            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null"); 
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            int n;

            Console.Write("Enter the number of nodes: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter value for node {i}: ");
                int value = int.Parse(Console.ReadLine());
                linkedList.AddNode(value);
            }
            Console.WriteLine("Linked list:");
            linkedList.Display();

            // Count and display the number of nodes in the linked list
            int nodeCount = linkedList.CountNodes();
            Console.WriteLine($"The number of nodes in the linked list is: {nodeCount}");
        }
    }
}*/





//  4. Write a  c# program to insert a node at any position in a Singly Linked List.
/*namespace ListAndArray
{
    // Define a Node class to represent each element in the linked list
    public class Node
    {
        public int Data; // Data to store in the node
        public Node Next; // Pointer to the next node in the list

        // Constructor to initialize the node with data
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    // Define a LinkedList class to represent the singly linked list
    public class LinkedList
    {
        private Node head; // Pointer to the head (first) node in the list

        // Method to add a node to the end of the linked list
        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode; // If the list is empty, set the head to the new node
            }
            else
            {
                Node current = head;
                // Traverse to the end of the list
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Append the new node at the end of the list
                current.Next = newNode;
            }
        }

        // Method to insert a node at a specific position in the linked list
        public void InsertNode(int data, int position)
        {
            Node newNode = new Node(data);

            if (position < 1)
            {
                Console.WriteLine("Position should be >= 1.");
                return;
            }

            if (position == 1)
            {
                // Insert at the beginning
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                int count = 1;

                // Traverse to the node before the position where we want to insert
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
                    // Insert the new node at the specified position
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }
        }

        // Method to display all the nodes in the linked list
        public void Display()
        {
            Node current = head;

            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Traverse through the list and print each node's data
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null"); // Indicate the end of the list
        }
    }

    // Main class to test the LinkedList implementation
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            int n;

            Console.Write("Enter the number of nodes: ");
            n = int.Parse(Console.ReadLine());

            // Add nodes to the linked list based on user input
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter value for node {i}: ");
                int value = int.Parse(Console.ReadLine());
                linkedList.AddNode(value);
            }

            // Display the linked list
            Console.WriteLine("Linked list before insertion:");
            linkedList.Display();

            // Insert a new node at a specific position
            Console.Write("Enter the value for the new node: ");
            int newValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the position to insert the new node: ");
            int position = int.Parse(Console.ReadLine());

            linkedList.InsertNode(newValue, position);

            // Display the linked list after insertion
            Console.WriteLine("Linked list after insertion:");
            linkedList.Display();
        }
    }
}
*/






//  5. Write a  c# program to insert a node at the beginning of a Singly Linked List.
namespace ListAndArray
{
    // Define a Node class to represent each element in the linked list
    public class Node
    {
        public int Data; // Data to store in the node
        public Node Next; // Pointer to the next node in the list

        // Constructor to initialize the node with data
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    // Define a LinkedList class to represent the singly linked list
    public class LinkedList
    {
        private Node head; // Pointer to the head (first) node in the list

        // Method to add a node to the end of the linked list
        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode; // If the list is empty, set the head to the new node
            }
            else
            {
                Node current = head;
                // Traverse to the end of the list
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Append the new node at the end of the list
                current.Next = newNode;
            }
        }

        // Method to insert a node at the beginning of the linked list
        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head; // Point the new node's next to the current head
            head = newNode; // Set the head to the new node
        }

        // Method to display all the nodes in the linked list
        public void Display()
        {
            Node current = head;

            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // Traverse through the list and print each node's data
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null"); // Indicate the end of the list
        }
    }

    // Main class to test the LinkedList implementation
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            int n;

            Console.Write("Enter the number of nodes: ");
            n = int.Parse(Console.ReadLine());

            // Add nodes to the linked list based on user input
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter value for node {i}: ");
                int value = int.Parse(Console.ReadLine());
                linkedList.AddNode(value);
            }

            // Display the linked list
            Console.WriteLine("Linked list before insertion at beginning:");
            linkedList.Display();

            // Insert a new node at the beginning
            Console.Write("Enter the value for the new node to insert at the beginning: ");
            int newValue = int.Parse(Console.ReadLine());

            linkedList.InsertAtBeginning(newValue);

            // Display the linked list after insertion
            Console.WriteLine("Linked list after insertion at beginning:");
            linkedList.Display();
        }
    }
}
