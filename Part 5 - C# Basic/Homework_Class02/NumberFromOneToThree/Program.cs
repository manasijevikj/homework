using System;

namespace NumberFromOneToThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number from one to three:");
            string number = Console.ReadLine();

            bool numberSuccess = int.TryParse(number, out int numberParsed);

            if(numberSuccess)
            {
                switch (numberParsed)
                {
                    case 1:
                        Console.WriteLine("You got a new car!");
                        break;
                    case 2:
                        Console.WriteLine("You got a new plane!");
                        break;
                    case 3:
                        Console.WriteLine("You got a new bike!");
                        break;
                    default:
                        Console.WriteLine("Your number is out of range!");
                        break;
                }
            }     
            else
            {
                Console.WriteLine("Your input is not a number!");
            }
            Console.ReadLine();
        }

    }
}
