using System;
using System.Collections.Generic;
using System.Text;

namespace Domain2.Classes
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }


        public Cat(string name, string type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} \nType: {Type}\nAge: {Age}\nLazy: {Lazy}\nLives Left: {LivesLeft}");
            Console.WriteLine();
        }
    }
} 
