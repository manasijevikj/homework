using System;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[10];
            int counter = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            while (true)
            {
                Console.WriteLine("Insert number " + (counter + 1) + ":");
                string number = Console.ReadLine();
                bool numberSuccess = int.TryParse(number, out int numberParsed);

                if (numberSuccess)
                {
                    numberArray[counter] = numberParsed;
                    counter++;
                }
                if (counter == 10)
                {
                    break;
                }
            }


            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                }
                if (numberArray[i] < min)
                {
                    min = numberArray[i];
                }
            }

            Console.WriteLine("Min " + min);
            Console.WriteLine("Max " + max);
            Console.ReadLine();
        }
    }
}
