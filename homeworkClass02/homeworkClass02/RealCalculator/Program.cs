using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput, secondInput;
            string operatorInput;
            Console.WriteLine("Enter first number: ");
            firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation");
            operatorInput = Console.ReadLine();


            int result;

            switch (operatorInput)
            {
                case "+":
                    result = firstInput + secondInput;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "-":
                    result = firstInput - secondInput;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "*":
                    result = firstInput * secondInput;
                    Console.WriteLine("The result is: " + result);
                    break;
                case "/":
                    result = firstInput / secondInput;
                    Console.WriteLine("The result is: " + result);
                    break;
                default:
                    Console.WriteLine("No such operation");
                    break;
            }


            Console.ReadLine();
        }
    }
}
