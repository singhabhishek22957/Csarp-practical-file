using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Second_Practical
{
    public class StringCount13
    {
        public void CountCharA(string str)
        {
            int count = 0;
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                    str1 = str1+str[i];
                }
                else
                {
                    Console.WriteLine(str1+": "+count);
                    count= 0;
                    str1 = "";
                }
            }
        }
    }
}
