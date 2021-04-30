using Domain2.Classes;
using System;

namespace Task2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Bruno", "Dog", 4, "Kibbles");
            Dog dog2 = new Dog("Lea", "Dog", 3, "Bone");

            Cat cat1 = new Cat("Lili", "Cat", 7, true, 6);
            Cat cat2 = new Cat("Garfild", "Cat", 5, false, 1);

            Fish fish1 = new Fish("Nemo", "Fish", 1, "Orange", 30);
            Fish fish2 = new Fish("Figaro", "Fish", 2, "Gold", 45);

            PetStore<Dog>.PetsList.Add(dog1);
            PetStore<Dog>.PetsList.Add(dog2);

            PetStore<Cat>.PetsList.Add(cat1);
            PetStore<Cat>.PetsList.Add(cat2);

            PetStore<Fish>.PetsList.Add(fish1);
            PetStore<Fish>.PetsList.Add(fish2);

            Console.WriteLine("Buying dog.");
            PetStore<Dog>.BuyPet("Lea");

            Console.WriteLine("Buying cat.");
            PetStore<Cat>.BuyPet("Lili");

            Console.WriteLine();
            Console.WriteLine("Dogs:");
            PetStore<Dog>.PrintsPets();

            Console.WriteLine();
            Console.WriteLine("Cats:");
            PetStore<Cat>.PrintsPets();

            Console.WriteLine();
            Console.WriteLine("Fish:");
            PetStore<Fish>.PrintsPets();

            Console.ReadLine();
        }
    }
}
