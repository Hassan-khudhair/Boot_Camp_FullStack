using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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







        //6. Write a C# program to find the manimum element in a stack.
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
        Console.WriteLine("the manimum number in Stack : " + list.Min()); // print hte manimum number
            */




        // 7.Write a C# program to remove all the elements from a given stack.
        /* Stack<int> myStack = new Stack<int>();
         myStack.Push(2);
         myStack.Push(6);
         myStack.Push(4);
         myStack.Push(1);
         foreach (object obj in myStack)
         {
             Console.WriteLine(obj);
         }
         // clear() : method to removes all data from stack
         myStack.Clear();
         Console.WriteLine("after remove all elements , the stack Count = " + myStack.Count ); // print the count of elements in the stack
         */






        // 8. Write a C# program to remove specified element from a given stack.
        /*Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        // get the specific element from the UInput
        int specificElmFind = Convert.ToInt32(Console.ReadLine());
        // the same way above , i used list to help me with remove the element
        List<int> myList = new List<int>();

        while(myStack.Count > 0)
            myList.Add(myStack.Pop());
        

        myList.Remove(specificElmFind);
        foreach (int i in myList)
            myStack.Push(i);
        
        foreach (int i in myStack)
            Console.WriteLine("the elements in stack is :" + i);*/





        // 9. Write a C# program to count all the elements in a given stack.
        /*Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        // to get the count with methods in stack return all count.
         Console.WriteLine("the Count of elements in stack is :" + myStack.Count);*/






        // 10. Write a C# program to count specified element in a given stack.
        /*Stack<int> myStack = new Stack<int>();
        // i need second stack to count the limit of number i need to count it
        Stack<int> tempStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        // array of specified elements
        int[] specificElements = {1 , 4, 3};
        
        // the first loop of array will be detect if any number is equal of 
        // the elements in stack , and the result store in another stack to find the count.
        foreach(int ele2 in specificElements)
            foreach(int ele3 in myStack)
                { if (ele2 == ele3)
                        tempStack.Push(ele2);}
                    
         Console.WriteLine("the elemenst specified is : " + tempStack.Count);*/



        //11.Write a C# program to implement a stack that checks if a given element is present or not in the stack.
        /* sol: the solutions of this is with used contains() method 
         * to detect from the number
         * 
         * stack.contains() // to find the detect
         */


        //12. Write a C# program to remove duplicates from a given stack.
        

    }
}