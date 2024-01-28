using System;

namespace zadaca
{
    public abstract class Car
    {
        public abstract void Drive();
    }
    public class Ford : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Driving Ford");
        }
    }

    public class Toyota : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Driving Toyota");
        }
    }

    public abstract class CarFactory
    {
        public abstract Car Create();
    }

    public class FordFactory : CarFactory
    {
        public override Car Create()
        {
            return new Ford();
        }
    }
    public class ToyotaFactory : CarFactory
    {
        public override Car Create()
        {
            return new Toyota();
        }
    }


    public class Program
    {
        static void Main()
        {
            CarFactory factory = new ToyotaFactory();
            Car myCar = factory.Create();
            myCar.Drive(); 

            if (myCar is Toyota)
            {
                Toyota myToyota = (Toyota)myCar;
            }
        }
    }
}

