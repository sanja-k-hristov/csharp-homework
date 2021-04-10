﻿using System;
using System.Collections.Generic;
using System.Text;

namespace class07.Models
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}");
        }
    }
}
