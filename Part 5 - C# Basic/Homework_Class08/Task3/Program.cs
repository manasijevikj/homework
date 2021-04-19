using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Classes;
using Task3.Enum;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Animal("Raccoon", "Grry", 2, Gender.Female));
            animals.Add(new Animal("Tiger", "Brown", 8, Gender.Male));
            animals.Add(new Animal("Aligator", "Green", 12, Gender.Male));
            animals.Add(new Animal("Monkey", "Black", 3, Gender.Male));
            animals.Add(new Animal("Hedgehog", "Grey", 4, Gender.Female));
            animals.Add(new Animal("Antelope", "Brown", 6, Gender.Female));
            animals.Add(new Animal("Bear", "Brown", 15, Gender.Male));
            animals.Add(new Animal("Hedgehog", "Grey", 4, Gender.Female));
            animals.Add(new Animal("Frigatebird", "Black", 1, Gender.Female));


            List<string> agedFiveOrMore = animals.Where(animal => animal.Age >= 5).Select(animal => $"{animal.Name} {animal.Age}").ToList();
            List<string> startWithA = animals.Where(animal => animal.Name.StartsWith("A")).Select(animal => $"{animal.Name}").ToList();
            List<string> maleBrownAnimals = animals.Where(animal => animal.Gender == Gender.Male && animal.Color == "Brown").
                Select(animal => $"{animal.Name} {animal.Color}").ToList();
            Animal longerThanTenCharacters = animals.FirstOrDefault(a => a.Name.Length > 10);

            Console.WriteLine("The names of all the animals aged 5 or more");
            foreach (string animal in agedFiveOrMore)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("");

            Console.WriteLine("All the Animals whose name starts with 'A' ");
            foreach (string animal in startWithA)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("");

            Console.WriteLine("All the brown male Animals: ");
            foreach (string animal in maleBrownAnimals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("");

            Console.WriteLine("The first Animal whose name is longer than 10 characters: ");
            Console.WriteLine(longerThanTenCharacters.Name);

            Console.ReadLine();

        }
    }
}

