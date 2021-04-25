using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Cat : Animal, ICat
    {
        public string Family { get; set; }

        public Cat(string name, string color, string family) : base(name, color)
        {
            Family = family;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Family: {Family}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating {food}");
        }
    }
}
