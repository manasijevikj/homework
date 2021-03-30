using System;

namespace SwapNumbers
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
                int temp = firstNumberParsed;
                firstNumberParsed = secondNumberParsed;
                secondNumberParsed = temp;
                Console.WriteLine("After Swaping:");
                Console.WriteLine("First Number: "+firstNumberParsed);
                Console.WriteLine("Second Number: "+secondNumberParsed);
            }
            else
            {
                Console.WriteLine("Wrong input, try again!");
            }
            Console.ReadLine();

        }
    }
}
