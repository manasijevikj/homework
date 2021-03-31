using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");
            string row = Console.ReadLine();
            bool rowSuccess = int.TryParse(row, out int rowsParsed);

            if(rowSuccess)
            {
                string space = " ";
                int temp = rowsParsed-1; 
                int counter = 1;

                for(int i=1; i <= rowsParsed; i++)
                {
                    for(int j = temp; j >= 1; j--)   
                    {
                        Console.Write($"{space}");
                    }
                    temp--;
                    
                    for(int k = 0; k < i; k++ )
                    {
                            Console.Write($"{counter} ");
                            counter++;
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Your input is not a number.");
            }

            Console.ReadLine();
        }
    }
}
