using Domain.Classes;
using System;
using System.Collections.Generic;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Mici", "White", "American Shorthair");
            Cat cat2 = new Cat("Garfild", "Orange", "Persian Tabby");
            Cat cat3 = new Cat("Lili", "Black", "Burmese");
            Cat cat4 = new Cat("Jack", "Gray", "Ragdoll");

            Dog dog1 = new Dog("Leo", "Black", "Large");
            Dog dog2 = new Dog("Astor", "White", "Small");
            Dog dog3 = new Dog("Cezar", "Black", "Large");
            Dog dog4 = new Dog("Papi", "Gray", "Medium");

            cat1.PrintAnimal();
            cat2.Eat("Fish");
            dog1.PrintAnimal();
            dog2.Bark();

            Console.WriteLine("------------");

            List<Animal> animals = new List<Animal>();
            animals.Add(cat1);
            animals.Add(cat2);
            animals.Add(cat3);
            animals.Add(cat4);
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(dog3);
            animals.Add(dog4);

            Dog tempDog;
            Cat tempCat;
            foreach(Animal animal in animals)
            {
                if (animal.GetType() == typeof(Dog))
                {
                    tempDog = (Dog)animal;
                    tempDog.Bark();
                }
                else if (animal.GetType() == typeof(Cat))
                {
                    tempCat = (Cat)animal;
                    tempCat.Eat("Something");
                }
            }
            Console.ReadLine();
        }
    }
}
