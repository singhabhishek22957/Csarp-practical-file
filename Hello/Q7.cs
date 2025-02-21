using System;

public class Q7
{
    public void Q()
    {
        Console.Write("Enter size of array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int[] originalArr = new int[size];
        int[] originalIndex = new int[size];


        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element" + (i + 1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            originalArr[i] = arr[i];
            originalIndex[i] = i;
        }


        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {

                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;


                    int tempIndex = originalIndex[j];
                    originalIndex[j] = originalIndex[j + 1];
                    originalIndex[j + 1] = tempIndex;
                }
            }
        }


        Console.WriteLine("\nElement Positions (Before Index - After Index):");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{arr[i]}: {originalIndex[i]} - {i}");
        }
    }
}
