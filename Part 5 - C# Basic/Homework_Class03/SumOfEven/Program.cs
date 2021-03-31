using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[6];
            int sum = 0;
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Insert number " + (counter + 1) + ":");
                string number = Console.ReadLine();
                bool numberSuccess = int.TryParse(number, out int numberParsed);

                if (numberSuccess)
                {
                    numbersArray[counter] = numberParsed;
                    counter++;
                }
                if (counter == 6)
                {
                    break;
                }
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 2 == 0)
                {
                    sum += numbersArray[i];
                }
            }

            Console.WriteLine("Sum of even numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
