using System;
using System.Collections.Generic;
using System.Text;

namespace Domain2.Classes
{
    public class Dog: Pet
    {
        public Dog(string name, string type, int age, string favoriteFood) : base(name, type, age)
        {
            FavoriteFood = favoriteFood;
        }

        public string FavoriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} \nType: {Type}\nAge: {Age}\nFavorite Food: {FavoriteFood}");
            Console.WriteLine();
        }
    } 
}
