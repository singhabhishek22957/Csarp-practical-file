using System;

public class Q9
{
    public void Q()
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        // Taking input
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element:"+ (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Removing duplicates
        int[] uniqueArr = new int[size];
        int uniqueCount = 0;

        for (int i = 0; i < size; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (arr[i] == uniqueArr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                uniqueArr[uniqueCount++] = arr[i];
            }
        }

        // Displaying the array without duplicates
        Console.WriteLine("\nArray without duplicates:");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(uniqueArr[i] + " ");
        }
    }
}
