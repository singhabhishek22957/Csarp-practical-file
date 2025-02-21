using System;

public class Q10
{
    public void Q()
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];


        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element:" + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        int[] checkedArr = new int[size];
        int checkedCount = 0;

        Console.WriteLine("\nElements with more than 2 duplicates:");
        bool found = false;

        for (int i = 0; i < size; i++)
        {
            int count = 0;

            // Check if already counted
            bool alreadyChecked = false;
            for (int c = 0; c < checkedCount; c++)
            {
                if (arr[i] == checkedArr[c])
                {
                    alreadyChecked = true;
                    break;
                }
            }

            if (alreadyChecked) continue;


            for (int j = 0; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.Write(arr[i] + " ");
                found = true;
                checkedArr[checkedCount++] = arr[i];
            }
        }

        if (!found)
        {
            Console.WriteLine("No element has more than 2 duplicates.");
        }
    }
}
