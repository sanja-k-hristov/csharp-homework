using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, forthNumber;
            float averageOfNumbers;
            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter forth number");
            forthNumber = Convert.ToInt32(Console.ReadLine());

            averageOfNumbers = (firstNumber + secondNumber + thirdNumber + forthNumber) / 4;
            Console.WriteLine("The average is:" + averageOfNumbers);

            Console.ReadLine();
        }
}
