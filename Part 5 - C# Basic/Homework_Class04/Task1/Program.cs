using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something.");
            string inputString = Console.ReadLine();
            char[] arrayOfChars = inputString.ToCharArray();
            Array.Reverse(arrayOfChars);
            foreach(char c in arrayOfChars)
            {
                Console.Write(c);
            }
            Console.ReadLine();


        }
    }
}
