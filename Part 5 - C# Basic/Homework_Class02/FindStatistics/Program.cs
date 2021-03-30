using System;

namespace FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first number:");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Insert the second number:");
            string secondNumber = Console.ReadLine();

            bool firstNumSuccess = int.TryParse(firstNumber, out int firstNumberParsed);
            bool secondNumSuccess = int.TryParse(secondNumber, out int secondNumberParsed);

            if(firstNumSuccess && secondNumSuccess)
            {
                int result;
                if(firstNumberParsed%2 == 0 && secondNumberParsed % 2 == 0) 
                {
                    result = firstNumberParsed + secondNumberParsed;
                    Console.WriteLine($"The both numbers are even. The operation: {firstNumberParsed} + {secondNumberParsed} = {result}");
                }
                else if (firstNumberParsed % 2 == 1 && secondNumberParsed % 2 == 1)
                {
                    result = firstNumberParsed * secondNumberParsed;
                    Console.WriteLine($"The both numbers are odd. The operation: {firstNumberParsed} * {secondNumberParsed} = {result}");
                }
                else if(firstNumberParsed % 2 == 1 || secondNumberParsed % 2 == 1)
                {
                    result = firstNumberParsed - secondNumberParsed;
                    Console.WriteLine($"The one of both numbers are odd. The operation: {firstNumberParsed} - {secondNumberParsed} = {result}");
                }
                else
                {
                    Console.WriteLine("Error...");
                }
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }

            Console.ReadLine();
        }
    }
}
