using class07.Enums;
using class07.Models;
using System;

namespace class07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car bmw = new Car()
            {
                Id = 1,
                Manufacturer = "bmw",
                Model = "bmw7",
                NumberOfDoors = 4,
            };
            bmw.Drive();
            bmw.Repair();

            ElectricCar tesla = new ElectricCar()
            {
                Id = 2,
                Manufacturer = "tesla",
                BatteryCapacity = 500,
                BatteryPercentage = 70
            };

            tesla.Drive();
            tesla.Recharge();


            Bicycle poni = new Bicycle()
            {
                Id = 3,
                Model = "poni3",
                NumberOfSpeedLevels = 6
            };

            poni.Ride();
            poni.Repair();




        }
    }
}
