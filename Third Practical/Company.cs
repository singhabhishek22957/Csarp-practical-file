using System;

public class Company
{
    public string Cname, Cho;
    public int Temp;

    public void Input()
    {
        Console.Write("Enter Company Name: ");
        Cname = Console.ReadLine();
        Console.Write("Enter Company Head Office: ");
        Cho = Console.ReadLine();
        Console.Write("Enter Total Employees: ");
        Temp = Convert.ToInt32(Console.ReadLine());
    }
}

public class Department : Company
{
    public string Dcode, Dname;

    public void Read()
    {
        Console.Write("Enter Department Code: ");
        Dcode = Console.ReadLine();
        Console.Write("Enter Department Name: ");
        Dname = Console.ReadLine();
    }
}

public class Employee : Department
{
    public string Ecode, Ename;
    public double Sal;
    public int Wexp;

    public void Emp()
    {
        Console.Write("Enter Employee ID: ");
        Ecode = Console.ReadLine();
        Console.Write("Enter Employee Name: ");
        Ename = Console.ReadLine();
        Console.Write("Enter Employee Salary: ");
        Sal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Work Experience (Years): ");
        Wexp = Convert.ToInt32(Console.ReadLine());
    }

    public void Show()
    {
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine($"Employee ID: {Ecode}");
        Console.WriteLine($"Employee Name: {Ename}");
        Console.WriteLine($"Salary: {Sal}");
        Console.WriteLine($"Work Experience: {Wexp} years");

        Console.WriteLine("\n--- Department Details ---");
        Console.WriteLine($"Department Code: {Dcode}");
        Console.WriteLine($"Department Name: {Dname}");

        Console.WriteLine("\n--- Company Details ---");
        Console.WriteLine($"Company Name: {Cname}");
        Console.WriteLine($"Head Office: {Cho}");
        Console.WriteLine($"Total Employees: {Temp}");
    }
}


