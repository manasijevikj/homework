using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 2 Homework - Task 2");

            Console.WriteLine("Enter the first number:");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("Enter the third number:");
            string thirdNumber = Console.ReadLine();

            Console.WriteLine("Enter the fourth number:");
            string fourthNumber = Console.ReadLine();

            bool firstNumSuccess = int.TryParse(firstNumber, out int firstNumberParsed);
            bool secondNumSuccess = int.TryParse(secondNumber, out int secondNumberParsed);
            bool thirdNumSuccess = int.TryParse(thirdNumber, out int thirdNumberParsed);
            bool fourthNumSuccess = int.TryParse(fourthNumber, out int fourthNumberParsed);

            bool validation = ValidationNumber(firstNumSuccess, secondNumSuccess, thirdNumSuccess, fourthNumSuccess);
            AverageNum(validation, firstNumberParsed, secondNumberParsed, thirdNumberParsed, fourthNumberParsed);
            Console.ReadLine();
        }


        public static bool ValidationNumber(bool firstCase, bool secondCase, bool thirdCase, bool fourthCase)
        {
            if (!firstCase)
            {
                Console.WriteLine("The first input is not a number");
                return false;
            }
            if (!secondCase)
            {
                Console.WriteLine("The second input is not a number");
                return false;
            }
            if (!thirdCase)
            {
                Console.WriteLine("The third input is not a number");
                return false;
            }
            if (!fourthCase)
            {
                Console.WriteLine("The fourth input is not a number");
                return false;
            }
            return true;
        }


        public static void AverageNum(bool succsess, int first, int second, int third, int fourth)
        {
            float result;
            float temp = 4;
            if(!succsess)
            {
                Console.WriteLine("Try again!");
            }
            else
            {
                result = (first + second + third + fourth) / temp;
                Console.WriteLine("The average number is: "+result);
            }
        }
    }
}
