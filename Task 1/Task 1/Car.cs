using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    internal class Car : Vehicle
    {
        public int FuelCapacity;
        public int Fuel;

        public void AddFuel(int fuel)
        {
            Fuel = fuel;

            if (fuel <= FuelCapacity)
            {
                Console.WriteLine("OKdi");
            }
            else
            {
                Console.WriteLine("Ok deyil");
            }
        }

    }
}
