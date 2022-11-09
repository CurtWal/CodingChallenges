using System;
using System.Collections.Generic;

class Program
{
    // Returns index of x if it is present in arr[],
    // else return -1
    static int LookThrough(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;
        while (l <= r)
        {
            int m = l + (r - l) / 2;

            // Check if x is present at mid
            if (arr[m] == x)
                return m;

            // If x greater, ignore left half
            if (arr[m] < x)
                l = m + 1;

            // If x is smaller, ignore right half
            else
                r = m - 1;
        }

        // if we reach here, then value was
        // not present
        return -1;
    }

    // Driver method to test above
    public static void Main()
    {
        //create a int[] array method that loops through the array length
        //while the method is looping check to see if the value of one side is higher then the interger that you want to find, if so basically delete them from the array
        //while the method is looping check to see if the values are lower on the other side of the interger that you want to find, if so basically delete them from the array
        //if there is only one interger in the int[] then return that number
        //repeat until the value of the array is found and return its index
        //return -1 if the value that the user want to find is not in the array
        int[] arr = { 2, 3, 4, 10, 44, 56, 65, 72 };
        int n = arr.Length;
        int x = 56;
        int result = LookThrough(arr, x);
        if (result == -1)
            Console.WriteLine("Value not present");
        else
            Console.WriteLine("Value found at "
                              + "index " + result);
    }
}