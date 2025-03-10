using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        char[] vowelsArray = new char[str.Length];
        char[] consonantsArray = new char[str.Length];

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int vIndex = 0, cIndex = 0;
        int i = 0;

        while (i < str.Length)
        {
            char ch = str[i];
            bool isVowel = false;
            int j = 0;

            while (j < vowels.Length)
            {
                if (ch == vowels[j])
                {
                    isVowel = true;
                    break;
                }
                j++;
            }

            if (isVowel)
                vowelsArray[vIndex++] = ch;
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                consonantsArray[cIndex++] = ch;

            i++;
        }

        if (vIndex > cIndex)
            Console.WriteLine(str.ToLower());
        else
            Console.WriteLine(str.ToUpper());
    }
}
