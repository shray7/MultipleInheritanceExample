using System;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var superCar = new SuperCar();
            Console.WriteLine("A supercar has " + superCar.NumberOfWheels() + " wheels,");
            Console.WriteLine(string.Concat("And it can ", superCar.CanFly() ? "fly." : "not fly."));
            Console.ReadLine();
        }
    }

    public interface ICar
    {
        int NumberOfWheels();
    }
    public class Car : ICar
    {
        private static int NumberWheels => 4;
        public int NumberOfWheels()
        {
            return NumberWheels;
        }
    }

    public interface IPlane
    {
        bool CanFly();
    }
    public class Plane : IPlane
    {
        public bool CanFly() => true;

    }

    public class SuperCar : ICar, IPlane
    {
        Car _car = new Car();
        Plane _plane = new Plane();
        public int NumberOfWheels()
        {
            return _car.NumberOfWheels();
        }

        public bool CanFly()
        {
            return _plane.CanFly();
        }
    }
}
