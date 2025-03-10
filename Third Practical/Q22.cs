using System;
public class Q22
{
    public int CalculateHCF(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }
        return a;
    }
    public int CalculateHCF(int a, int b, int c)
    {
        int tempHCF = CalculateHCF(a, b);
        return CalculateHCF(tempHCF, c);
    }
    public int CalculateHCF(int a, int b, int c, int d)
    {
        int tempHCF = CalculateHCF(a, b, c);
        return CalculateHCF(tempHCF, d);
    }
}
