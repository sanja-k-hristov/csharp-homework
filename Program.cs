using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());


            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Tik - Tak");
            } else if (number % 3 == 0)
            {
                Console.WriteLine("Tik");
            } else if (number % 5 == 0)
            {
                Console.WriteLine("Tak");
            } else
            {
                Console.WriteLine("Bad number");
            }

            Console.ReadLine();

        }
    }
}
