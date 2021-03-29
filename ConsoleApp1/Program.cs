using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int[] userArray = new int[6];
            int sumNumbers = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                userArray[i] = int.Parse(Console.ReadLine());
                if (userArray[i] % 2 == 0)
                {
                    sumNumbers += userArray[i];
                }
            }

            Console.WriteLine("Sum of even numbers is " + sumNumbers);

            Console.ReadLine();

            // Task 2
            string[] studentsG1 = new string[]
            {
                "Jana",
                "Ivan",
                "Gligor",
                "Hristijan",
                "Sanja",
                "Marta"
            };
            string[] studentsG2 = new string[]
                {
                "Nikola",
                "Gjorgje",
                "Martina",
                "Jelena",
                "Marija",
                "Marko"
                };
            Console.WriteLine("Enter number 1 or 2");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                foreach (string item in studentsG1)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                foreach (string item in studentsG1)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();

            //Exercise 6
            string[] userArray1 = new string[1];
            Console.WriteLine("Enter name: ");
            userArray1[1] = Console.ReadLine();

            Console.WriteLine("Do you want to enter another name(Y / N)");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Y":
                    {
                        for (int i = 1; i < 2; i++)
                        {
                            Console.WriteLine("Enter name: ");
                            Array.Resize(ref userArray1, i + 1);
                            userArray1[i + 1] = Console.ReadLine();
                        }
                    }
                    break;
                case "N":
                    {
                        foreach (string item in userArray1)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("No such answer");
                    break;
            }
            Console.ReadLine();
        }
    }
}
