using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }


        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, List<string> countries) :
            base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }




        public override void PrintVehicle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"FuelTank: {FuelTank}L");
            Console.WriteLine("Countries:");
            foreach(string country in Countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
