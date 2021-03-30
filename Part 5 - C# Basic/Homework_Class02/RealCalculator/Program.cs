using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 2 Homework - Task 1");

            Console.WriteLine("Enter the first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Enter the operation:");
            string operand = Console.ReadLine();

            bool firstNumSuccess = int.TryParse(firstNumber, out int firstNumberParsed);
            bool secondNumSuccess = int.TryParse(secondNumber, out int secondNumberParsed);

            bool validation = ValidationNumber(firstNumSuccess, secondNumSuccess);
            DisplayCalculation(validation, firstNumberParsed, secondNumberParsed, operand);
            Console.ReadLine();
        }

        public static bool ValidationNumber(bool firstCase, bool secondCase) 
        {
            if(!firstCase)
            {
                Console.WriteLine("The first input is not a number");
                return false;
            }
            if(!secondCase)
            {
                Console.WriteLine("The second input is not a number");
                return false;
            }
            return true;
        }

        public static void DisplayCalculation(bool validation, int number1, int number2, string operand)
        {
            int result;
            if(!validation)
            {
                Console.WriteLine("Try again!");
            }
            else
            {
                switch (operand)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine("The result is: "+result);
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    case "/":
                        result = number1 / number2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    default:
                        Console.WriteLine("Operand is not correct");
                        break;
                }
            }            
        }
    }
}
