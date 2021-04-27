using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, int yearOfProduction, int batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Id: {Id}, Type: {Type}, Year of Production: {YearOfProduction}");
        }

    }
}
