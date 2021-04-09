using class05.Classes;
using System;

namespace class05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 01");

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            DateTime addedYears = currentDate.AddYears(10);
            Console.WriteLine(addedYears);

            DateTime removedMonthsAndDays = currentDate.AddMonths(-2).AddDays(-15);
            Console.WriteLine(removedMonthsAndDays);

            DateTime currentDay = DateTime.Today;
            DateTime addMonthsAndDays = currentDay.AddMonths(11).AddDays(-1);
            DayOfWeek DayOfWeek = addMonthsAndDays.DayOfWeek;
            Console.WriteLine(DayOfWeek);

            DateTime ValentinesDay = currentDay.AddYears(-1).AddMonths(-2).AddDays(5);
            DayOfWeek DayOfWeekValentines = ValentinesDay.DayOfWeek;
            Console.WriteLine(DayOfWeekValentines);

            Console.WriteLine("Task 02");

            Car[] cars = new Car[]
            {
                new Car("Hyndai", 200),
                new Car("Mazda", 150),
                new Car("Ferrari", 250),
                new Car("Porsche", 170)
            };

            Driver[] drivers = new Driver[]
            {
                new Car("Bob", 3),
                new Car("Greg", 4),
                new Car("Jill", 2),
                new Car("Anne", 5)
            };

            Console.WriteLine("Choose a car no.1:");
            foreach (Car item in cars)
            {
                Console.Write($"{item.Model} ");
            }
            string userCar01 = Console.ReadLine();
            
            Console.WriteLine("Choose Driver:");
            foreach (Driver item in drivers)
            {
                Console.Write($"{item.Name} ");
            }
            string userDriver01 = Console.ReadLine();

            
            Console.WriteLine("Choose a car no.2:");
            foreach (Car item in cars)
            {
                Console.Write($"{item.Model} ");
            }
            string userCar02 = Console.ReadLine();
            
            Console.WriteLine("Choose Driver:");
            foreach (Driver item in drivers)
            {
                Console.Write($"{item.Name} ");
            }
            string userDriver02 = Console.ReadLine();

            static Car FindCar(Car[] cars, string model)
            {
                foreach (Car item in cars)
                {
                    if (item.Model.ToLower() == model.ToLower())
                    {
                        return item;
                    }
                }
                return null;
            }

            static Driver FindDriver(Driver[] drivers, string name)
            {
                foreach (Driver obj in drivers)
                {
                    if (obj.Name.ToLower() == name.ToLower())
                    {
                        return obj;
                    }
                }
                return null;
            }

            int firstCar = userCar01.CalculateSpeed(userDriver01);
            int secondCar = userCar02.CalculateSpeed(userDriver02);

            static void RaceCars(int firstCar, int secondCar)
            {
                if (firstCar > secondCar)
                {
                    Console.WriteLine($"The car no.1 is faster");
                }
                else
                {
                    Console.WriteLine($"The car no.2 is faster");
                }
            }
            RaceCars(firstCar, secondCar);

            Console.ReadLine();
        }
    }
}
