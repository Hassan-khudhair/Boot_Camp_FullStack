using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public class SampleStack
{
    public static void Main(string[] args)
    {
        //1.Write a C# program to implement a stack with push and pop operations. 
        //    Find the top element of the stack and check if the stack is empty or not.


        /*Stack myStack = new Stack();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        Console.WriteLine("the count of myStack " + myStack.Count);
        Console.WriteLine("the count of myStack "+ myStack.Peek());
        myStack.Pop();
        Console.WriteLine("the count of myStack "+ myStack.Count);
        Console.WriteLine("the count of myStack "+ myStack.Peek());

        foreach (object obj in myStack)
        {
            Console.WriteLine(obj); 
        }*/




        //2. Write a C# program to sort the elements of a given stack in descending order.
        /*Stack<int> myStack = new Stack<int>();
        for(int i = 0; i <= 10 ; i++)
        {
            myStack.Push(i);
        }

        Console.WriteLine("Original stack:");
        PrintStack(myStack);

        // Sort the stack in descending order
        Stack<int> sortedStack = SortStackDescending(myStack);
        Console.WriteLine("\nSorted stack (descending order):");
        PrintStack(sortedStack);
        static Stack<int> SortStackDescending(Stack<int> stack)
        {
            // Pop all elements from the stack and add them to a list
            List<int> list = new List<int>();
            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
            }
            // Sort the list in descending order
            list.Sort();
            list.Reverse();
            foreach (int item in list)
            {
                stack.Push(item);
            }
            return stack;
        }

        static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }*/



        //3. Write a C# program to sort the elements of a given stack in ascending order.
        /* sol: the same code of (2) just i will be replace the revearse and just sorted it in list.
         * 
         * list.Sort(); // just that after removing the list.Reverse(); 
         */



        //4. Write a C# program to reverse the elements of a given stack.
        /* sol: the same code of (2) just i will be removed sorted from the list item.
         * 
         * list.Reverse(); // just that after removing the sort
         */



        //5. Write a C# program to find the maximum element in a stack.
        /*Stack<int> myStack = new Stack<int>();
        List<int> list = new List<int>();
        myStack.Push(2);
        myStack.Push(6);
        myStack.Push(4);
        myStack.Push(1); 

        // convert the stack items to list to find the max
        while (myStack.Count > 0)
        {
            list.Add(myStack.Pop());
        }
        
        foreach (object obj in myStack)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("the maximum number in Stack : " + list.Max()); // print hte maximum number
        */
    }
}