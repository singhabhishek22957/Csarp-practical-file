using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second_Practical
{
    public class Employee11
    {

        private int id = 0;
        private string name = "";
        private string department = "";
        private string designation = "";


        public void Input(){
            Console.WriteLine("Enter the id of the employee: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the employee: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the department of the employee: ");
            department = Console.ReadLine();
            Console.WriteLine("Enter the designation of the employee: ");
            designation = Console.ReadLine();
        }

        public void Display(){
            Console.WriteLine("The id of the employee is: " + id);
            Console.WriteLine("The name of the employee is: " + name);
            Console.WriteLine("The department of the employee is: " + department);
            Console.WriteLine("The designation of the employee is: " + designation);
        }
        
    }
}