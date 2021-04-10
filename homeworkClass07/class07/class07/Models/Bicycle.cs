using System;
using System.Collections.Generic;
using System.Text;

namespace class07.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        protected bool IsElectric { get; set; }

        public Bicycle() : base("bicycle")
        {
            Console.WriteLine("A new instance of bicycle is created by the parent c-tor that requires type parameter");
        }
        public void Ride()
        {
            Console.WriteLine($"Bicycle is riding.");
        }
        public override void Repair()
        {
            IsElectric = false;
            Console.WriteLine($"Reapairing overrided for bicycle");
        }
    }
}
