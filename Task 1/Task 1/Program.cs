using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();

            car1.Brand = "BMW";
            car1.Model = "535";
            car1.Millage = 300;
            car1.FuelCapacity = 70;

            car1.AddFuel(70);

        }
    }
}
