using System;

class Convert
{
    private string name;

    private Convert(string name)
    {
        this.name = name;
        this.show();
    }

    private void show()
    {
        string result = "";
        foreach (char ch in this.name)
        {
            if ("AEIOUaeiou".Contains(ch))
            {
                result += (char)(ch - 2);
            }
            else if (char.IsLetter(ch))
            {
                result += (char)(ch + 2);
            }
            else
            {
                result += ch;
            }
        }
        Console.WriteLine("Resultant String: " + result);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        new Convert(input);
    }
}
