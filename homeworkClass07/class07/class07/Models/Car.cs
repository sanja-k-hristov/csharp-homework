using class07.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace class07.Models
{
    public class Car : WheeledVehicle
    {
        public EngineType Engine { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public Car() : base("car")
        {
        }
        public virtual void Drive()
        {
            Console.WriteLine($"Car is driving.");
        }

        public override void Repair()
        {
            Console.WriteLine($"Reapairing overrided for car");
        }
    }
}
