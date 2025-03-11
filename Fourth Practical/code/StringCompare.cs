using System;

class StringCompare
{
    private static void Compare(string str1, string str2)
    {
        string greatest = str1.CompareTo(str2) > 0 ? str1 : str2;
        Console.WriteLine("Greatest String: " + greatest);
    }

    private static void Compare(string str1, string str2, string str3)
    {
        string greatest = str1;
        if (str2.CompareTo(greatest) > 0) greatest = str2;
        if (str3.CompareTo(greatest) > 0) greatest = str3;
        Console.WriteLine("Greatest String: " + greatest);
    }

    private static void Compare(string str1, string str2, string str3, string str4)
    {
        string greatest = str1;
        if (str2.CompareTo(greatest) > 0) greatest = str2;
        if (str3.CompareTo(greatest) > 0) greatest = str3;
        if (str4.CompareTo(greatest) > 0) greatest = str4;
        Console.WriteLine("Greatest String: " + greatest);
    }

    static void Main()
    {
        Console.WriteLine("Enter number of strings (2-4): ");
        int count = Convert.ToInt32(Console.ReadLine());

        if (count == 2)
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine() ?? string.Empty;
            Compare(str1, str2);
        }
        else if (count == 3)
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter third string: ");
            string str3 = Console.ReadLine() ?? string.Empty;
            Compare(str1, str2, str3);
        }
        else if (count == 4)
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter third string: ");
            string str3 = Console.ReadLine() ?? string.Empty;
            Console.Write("Enter fourth string: ");
            string str4 = Console.ReadLine() ?? string.Empty;
            Compare(str1, str2, str3, str4);
        }
        else
        {
            Console.WriteLine("Invalid input! Enter 2, 3, or 4 strings.");
        }
    }
}
