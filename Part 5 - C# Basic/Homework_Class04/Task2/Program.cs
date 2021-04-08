using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence.");
            string inputString = Console.ReadLine();
            Console.WriteLine("Insert a word and find out if the word exists.");
            string wordString = Console.ReadLine();
            int index = inputString.IndexOf(wordString);
            if(index == -1)
            {
                Console.WriteLine(wordString+" doesn't exist in your sentence.");
            }
            else
            {
                Console.WriteLine(wordString + " exists in your sentence.");
            }

            Console.ReadLine();

        }
    }
}
