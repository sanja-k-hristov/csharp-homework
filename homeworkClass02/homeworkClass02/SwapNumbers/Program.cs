using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            firstNumber = firstNumber * secondNumber;
            secondNumber = firstNumber / secondNumber;
            firstNumber = firstNumber / secondNumber;

            Console.WriteLine("After swapping");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);

            Console.ReadLine();
        }
    }
}
