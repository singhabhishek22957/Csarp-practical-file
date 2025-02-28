using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a size of array:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];

        Dictionary<int, int> freq = new Dictionary<int, int>();
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter " + (i + 1) + " Element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (freq.ContainsKey(arr[i]))
            {
                freq[arr[i]]++;
            }
            else
            {
                freq[arr[i]] = 1;
            }
        }
        foreach (var pair in freq)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }
}