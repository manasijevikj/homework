using Domain;
using Domain.Database;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {

        static void Main(string[] args)
        {
            Database _database = new Database();
            

            while(true)
            {
                Console.WriteLine("Create a dog.");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Incorect name. Try again.");
                    continue;
                }

                Console.WriteLine("Age:");
                bool success = int.TryParse(Console.ReadLine(), out int age);
                if (!success)
                {
                    Console.WriteLine("Incorect age. Try again.");
                    continue;
                }


                Console.WriteLine("Color:");
                string color = Console.ReadLine();
                if (string.IsNullOrEmpty(color))
                {
                    Console.WriteLine("Incorect color. Try again.");
                    continue;
                }


                Console.WriteLine("The dog is created and inserted in database");
                _database.Insert(CreateDog(name, age, color));

                Console.WriteLine("");
                Console.WriteLine("All dogs in the list");
                foreach(Dog dog in _database.GetAll())
                {
                    Console.WriteLine($"Name: {dog.Name} Age: {dog.Age} Color: {dog.Color}");               
                }
                Console.WriteLine("");
            }        

        }


        public static Dog CreateDog(string name, int age, string color)
        {
            return new Dog(name, age, color);
        }


    }
}
