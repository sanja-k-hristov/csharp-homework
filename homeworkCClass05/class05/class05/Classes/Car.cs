using System;
using System.Collections.Generic;
using System.Text;

namespace class05.Classes
{
    public class Car : Driver
    {
        public Car() 
        {

        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public int CalculateSpeed(string Driver)
        {
            int result = Skill * Speed;
            return result;
            //Console.WriteLine($"The speed of the car is {result}");
        }
       




    }
}
