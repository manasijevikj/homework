using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Dog : Animal, IDog
    {
        public string Size { get; set; }
        public Dog(string name, string color, string size) : base(name,color)
        {
            Size = size;
        }


        public override void PrintAnimal()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Size: {Size}");
        }

        public void Bark()
        {
            Console.WriteLine(Name+": Af Af");
        }
    }
}
