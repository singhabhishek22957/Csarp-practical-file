// using System;


// public class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a size of array:");
//         int size = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[size];

//         Dictionary<int, int> freq = new Dictionary<int, int>();
//         for (int i = 0; i < size; i++)
//         {
//             Console.Write("Enter " + (i + 1) + " Element: ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());

//             if (freq.ContainsKey(arr[i]))
//             {
//                 freq[arr[i]]++;
//             }
//             else
//             {
//                 freq[arr[i]] = 1;
//             }
//         }
//         foreach (var pair in freq)
//         {
//             Console.WriteLine(pair.Key + ": " + pair.Value);
//         }
//     }
// }




using System;

public class Program{


    static void Main(string [] args){

        Student s1 = new Student(01,"MCA","abhishek",21,"Bihar",45,50);
        Student s2 = new Student(02,"MCA","Rahul",21,"Bihar",72,65);
        s1.DisplayStudentInfo();
        s2.DisplayStudentInfo();
        Employee e1 = new Employee(01,"UG","Danish",23,"Delhi","HR",3400.00);
        Employee e2 = new Employee(01,"UG","Gautam",23,"Delhi","HR",3400.00);
        e1.DisplayStudentInfo();
        e2.DisplayStudentInfo();

    }
}