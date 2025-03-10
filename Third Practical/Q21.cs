using System;
public class Q21
{
    public void Asen(string str)
    {
        int count = 0;
        bool isNewWord = true;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                isNewWord = true;
            }
            else if (isNewWord)
            {
                count++;
                isNewWord = false;
            }
        }
        if (count <= 3)
        {
            Console.WriteLine("Input should contain more than 3 words.");
            return;
        }
        string[] arrStr = new string[count];
        int index = 0;
        string word = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                if (word != "")
                {
                    arrStr[index] = word;
                    index++;
                    word = "";
                }
            }
            else
            {
                word += str[i];
            }
        }  
        if (word != "")
        {
            arrStr[index] = word;
        }
        for (int i = 0; i < arrStr.Length - 1; i++)
        {
            for (int j = i + 1; j < arrStr.Length; j++)
            {
                if (arrStr[i].Length > arrStr[j].Length)
                {
                    // Swap words
                    string temp = arrStr[i];
                    arrStr[i] = arrStr[j];
                    arrStr[j] = temp;
                }
            }
        }
        for (int i = 0; i < arrStr.Length; i++)
        {
            Console.Write(arrStr[i] + " ");
        }
    }
}
