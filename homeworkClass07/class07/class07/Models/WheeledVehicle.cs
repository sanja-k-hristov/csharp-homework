using class07.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace class07.Models
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Type { get; set; }

        public WheeledVehicle()
        {

        }
        public WheeledVehicle(string type)
        {
            Type = type;
            Console.WriteLine($"The type of vechicle is: {Type}");
        }
        
        public virtual void Repair()
        {
            Console.WriteLine($"Reapairing");
        }
    }
}
