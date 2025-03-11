using System;

namespace fourth_practical
{

    public abstract class Bike
    {
        public abstract void Average();
        public abstract void maxSpeed();
    }

    public class Splendor : Bike
    {
        public override void Average()
        {
            Console.WriteLine("Splendor Average is 50-60 km/h");
        }
        public override void maxSpeed()
        {
            Console.WriteLine("Splendor max speed is 70-80 km/h");
        }
    }
    public class RoyalEnfield350 : Bike
    {
        public override void Average()
        {
            Console.WriteLine("Royal Enfield classic 350 Average is 25-35 km/h");
        }
        public override void maxSpeed()
        {
            Console.WriteLine("Royal Enfield classic 350 max speed is 110-120 km/h");
        }
    }
    public class KTM : Bike
    {
        public override void Average()
        {
            Console.WriteLine("KTM Average is 25-35 km/h");
        }
        public override void maxSpeed()
        {
            Console.WriteLine("KTM max speed is 150-160 km/h");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Splendor
            Splendor splendor = new Splendor();
            splendor.Average();
            splendor.maxSpeed();

            // Royal Enfield 350
            RoyalEnfield350 royal = new RoyalEnfield350();
            royal.Average();
            royal.maxSpeed();

            //KTM
            KTM ktm = new KTM();
            ktm.Average();
            ktm.maxSpeed();
        }

    }

}