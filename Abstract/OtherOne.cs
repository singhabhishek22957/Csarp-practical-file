using System;

namespace abstracts{

    public  class Head{
        

        public virtual void SayHello(){
            Console.WriteLine("Hello, World!");
        }
        public  void SayHey(){
            Console.WriteLine("Hello, World!");
        }

    }

    public class Tail:Head{

        

        public override void SayHello()
        {
            Console.WriteLine("Override SayHello Method");
        }

        public void SayHey(){
            Console.WriteLine("This SayHey Method");
        }

    }

    public class OtherOne{
        // static void Main(string [] args){
        //     Console.WriteLine("Main Method");

        //     Tail d = new Tail();
          
        //     d.SayHello();
        //     d.SayHey();
        // }
    }
}