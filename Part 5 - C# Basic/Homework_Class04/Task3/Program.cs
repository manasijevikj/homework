using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfDigits();
            Console.ReadLine();
        }

        public static void SumOfDigits()
        {
            int sum = 0;
            int temp;

            Console.WriteLine("Insert a number:");
            string number = Console.ReadLine();
            bool numberSuccess = int.TryParse(number, out int numberParsed);

            if(!numberSuccess)
            {
                Console.WriteLine("Incorrect input. Try again.");
                
            }
            else
            {
                while(numberParsed > 0)
                {
                    temp = numberParsed % 10;
                    sum += temp;
                    numberParsed /= 10;
                }

                Console.WriteLine("Sum of digits is "+sum);
            }                   
        }
    }
}
