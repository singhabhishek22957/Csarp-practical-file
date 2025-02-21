using System;
public class Q8
{
    public void Q()
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];


        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element" + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Enter the element to divide the array: ");
        int ele = Convert.ToInt32(Console.ReadLine());

        int[] left = new int[size];
        int[] right = new int[size];
        int leftCount = 0, rightCount = 0;
        bool found = false;

        // Categorizing elements
        for (int i = 0; i < size; i++)
        {
            if (arr[i] < ele)
            {
                left[leftCount] = arr[i];
                leftCount++;
            }
            else if (arr[i] > ele)
            {
                right[rightCount] = arr[i];
                rightCount++;
            }
            else
            {
                found = true;
            }
        }

        // Displaying result
        Console.WriteLine("\nResult:");

        if (found)
        {

            Console.Write("Left Side: ");
            for (int i = 0; i < leftCount; i++)
            {
                Console.Write(left[i] + " ");
            }


            Console.Write("\nRight Side: ");
            for (int i = 0; i < rightCount; i++)
            {
                Console.Write(right[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
