using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Jana", "Filip", "Sara", "Elena", "Gorijan" };

            Console.WriteLine("Insert number(1 or 2) of the students group: ");
            string number = Console.ReadLine();
            bool numberSuccess = int.TryParse(number, out int numberParsed);

            if(numberSuccess)
            {
                if(numberParsed == 1)
                {
                    foreach(string name in studentsG1)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if(numberParsed == 2)
                {
                    foreach (string name in studentsG2)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine("Students group with that number doesn't exist");
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
