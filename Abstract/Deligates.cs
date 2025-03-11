using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract
{
    public class Deligates
    {
        public delegate void sum(int x, int y);
        public delegate void sub(int x, int y);

        public void add(int x , int y){
            Console.WriteLine("the sum is: "+(x+y));
        }
        public void minus(int x , int y){
            Console.WriteLine("the sum is: "+(x-y));
        }



        // public static void Main(string[] args)
        // {
        //     Deligates d = new Deligates();

        //     sum  sdel = new sum(d.add);
        //     sub  bdel = new sub(d.minus);
        //     sdel(10,5);
        //     bdel(18,9);

        // }

    }
}