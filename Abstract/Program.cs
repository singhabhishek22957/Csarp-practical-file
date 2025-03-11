using System;

namespace abstracts{

    public abstract class Animal{
        public abstract void bark();

        public virtual void SayHello(){
            Console.WriteLine("Hello, World!  in side a Animal");
        }
        public  void SayHey(){
            Console.WriteLine("Hello, World! in side Animal");
        }

    }

    public class Dog:Animal{

        public override void bark()
        {
            Console.WriteLine("Abstracted Method");
        }

        public override void SayHello()
        {
            Console.WriteLine("Override SayHello Method in side a Dog");
        }

        public void SayHey(){
            Console.WriteLine("This SayHey Method in side a Dog");
        }

    }

    public class Program{
        static void Main(string [] args){
            Console.WriteLine("Main Method");

            Dog d = new Dog();
            d.bark();
            d.SayHello();
            d.SayHey();
        }
    }
}