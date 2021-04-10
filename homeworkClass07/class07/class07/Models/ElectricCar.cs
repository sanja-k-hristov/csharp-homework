using class07.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace class07.Models
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }
        public ElectricCar()
        {

        }
        public void Recharge()
        {
            Console.WriteLine($"Recharging car");
        }
        public ElectricCar(EngineType ElectricEngine)
        {
            Engine = ElectricEngine;
            Console.WriteLine($"The type of engine is {Engine}.");
        }
        public override void Drive()
        {
            Console.WriteLine($"Car is driving on max speed 200");
        }

    }
}
