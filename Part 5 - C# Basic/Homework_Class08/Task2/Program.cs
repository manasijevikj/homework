using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>();
            Console.WriteLine("Insert 10 numbers:");
            while(integerList.Count < 10)
            {
                Console.WriteLine($"Insert a number {integerList.Count + 1}: ");
                string number = Console.ReadLine();
                bool numberSuccess = int.TryParse(number, out int numberParsed);
                if(numberSuccess)
                {
                    integerList.Add(numberParsed);
                }
            }
            List<int> newList = integerList.Select(x => x*x).ToList();

            foreach(int n in newList)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
