using System;

namespace HowManyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements: ");
            string number = Console.ReadLine();
            bool numberSuccess = int.TryParse(number, out int numberParsed);

            if(numberSuccess)
            {
                int[] arrayOfNumbers = new int[numberParsed];
                int counter = 0;
                int countThree = 0;

                while(counter < numberParsed)
                {
                    Console.WriteLine("Enter number "+(counter+1)+": ");
                    string element = Console.ReadLine();
                    bool elementSuccess = int.TryParse(element, out int elementParsed);

                    if(elementSuccess)
                    {
                        arrayOfNumbers[counter] = elementParsed;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Try again.");
                    }
                }

                for(int i = 0; i < arrayOfNumbers.Length-1; i++)
                {
                    if (arrayOfNumbers[i] == 3 && arrayOfNumbers[i+1] == 3)
                    {
                        countThree++;
                    }
                }

                Console.WriteLine(countThree+" times there are threes next to each other.");
            }
            else
            {
                Console.WriteLine("Input is not a number!");
            }

            Console.ReadLine();
        }
    }
}
