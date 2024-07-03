
using System;

class BinarySearch
{
    static int BinarySearchAlgorithm(string[] names, string target)
    {
        int left = 0; 
        int right = names.Length - 1; 
        int steps = 0; // To count the number of steps 

        while (left <= right)
        {
            steps++; // Increment steps count
            int mid = left + (right - left) / 2;

            int result = string.Compare(names[mid], target, StringComparison.Ordinal);

            // Check if target is present at mid
            if (result == 0)
                return steps;

            // If target is greater, ignore the left half
            if (result < 0)
                left = mid + 1;
            // If target is smaller, ignore the right half
            else
                right = mid - 1;
        }


        return steps; // Return the number of steps
    }

    static void Main()
    {

        /* Task 1.1  Suppose you have a sorted list of 128 names, and you’re searching 
                    through it using binary search. What’s the maximum number of 
                    steps it would take?
        */
        // string[] names = {
        //     "Aaron", "Abigail", "Adam", "Adrian", "Aiden", "Alex", "Alexa", "Alexander",
        //     "Alexis", "Alice", "Alicia", "Alison", "Amanda", "Amber", "Amy", "Andrea",
        //     "Andrew", "Angela", "Anna", "Anthony", "Ashley", "Austin", "Ava", "Barbara",
        //     "Benjamin", "Betty", "Blake", "Brandon", "Brenda", "Brian", "Brittany", "Brooke",
        //     "Bryan", "Caleb", "Cameron", "Carl", "Carla", "Carol", "Caroline", "Carter",
        //     "Catherine", "Charles", "Charlotte", "Chloe", "Chris", "Christian", "Christina",
        //     "Christopher", "Cindy", "Claire", "Clara", "Connor", "Crystal", "Cynthia",
        //     "Daniel", "David", "Dawn", "Deborah", "Dennis", "Diana", "Diane", "Donna",
        //     "Doris", "Dorothy", "Douglas", "Dylan", "Edward", "Eleanor", "Elizabeth",
        //     "Emily", "Emma", "Eric", "Ethan", "Eugene", "Evan", "Evelyn", "Faith",
        //     "Florence", "Frances", "Frank", "Gabriel", "Gavin", "George", "Gloria",
        //     "Grace", "Gregory", "Hannah", "Harold", "Heather", "Helen", "Henry", "Isaac",
        //     "Isabella", "Jack", "Jacob", "James", "Jamie", "Jane", "Janet", "Janice",
        //     "Jason", "Jean", "Jeffrey", "Jennifer", "Jessica", "John", "Jonathan", "Joseph",
        //     "Joshua", "Judith", "Judy", "Julia", "Julie", "Justin", "Katherine", "Kathleen",
        //     "Kayla", "Keith", "Kelly", "Kenneth", "Kevin", "Kimberly", "Kyle", "Laura",
        //     "Lauren", "Lillian", "Lily", "Linda", "Logan", "Lori", "Lucas", "Luke"
        // };

        // string target = "Grace"; // Example target name

        // int steps = BinarySearchAlgorithm(names, target);
        // Console.WriteLine($"Number of steps to find '{target}': {steps}");




        /* 
            Task 1.2  Suppose you double the size of the list. What’s the maximum number of steps now?
        */


        string[] names = new string[256]; // Assuming we fill this array with 256 sorted names
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = $"Name{i:D3}"; // Example: Name000, Name001, ..., Name255
        }

        string target = "Name128";
        int steps = BinarySearchAlgorithm(names, target);
        Console.WriteLine($"Number of steps to find '{target}': {steps}");
    }
}

