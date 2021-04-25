using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        protected Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void PrintAnimal();
    }
}
  