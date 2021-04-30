using System;
using System.Collections.Generic;
using System.Text;

namespace Domain2.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Fish(string name, string type, int age, string color, int size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} \nType: {Type} \nAge: {Age} \nColor: {Color} \nSize: {Size}");
            Console.WriteLine();
        }
    }
}
