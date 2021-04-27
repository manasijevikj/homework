using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) :
             base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Year Of Production: {YearOfProduction}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
