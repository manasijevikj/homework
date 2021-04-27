using Domain;
using Domain.Classes;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1, "Sport", 2016, 005566, 55, new List<string> { "France", "India", "Poland" });
            Car car2 = new Car(2, "Family", 2010, 004462, 65, new List<string> { "UK", "Italy", "Norway" });
            Car car3 = new Car(3, "Old Timer", 1960, 001122, 40, new List<string> { "USA", "Germany"});

            Vehicle vehicle1 = new Vehicle(4, "Jeep", 1999, 008562);
            Vehicle vehicle2 = new Vehicle(5, "Truck", 2003, 003596);
            Vehicle vehicle3 = new Vehicle(6, "Bus", 2006, 001654);

            Bike bike1 = new Bike(7, "Scooter", 2009, 009652, "White");
            Bike bike2 = new Bike(8, "Touring", 1995, 003286, "Black");
            Bike bike3 = new Bike(9, "Utility", 2020, 016952, "Red");

            InMemoryDb.Vehicles.Add(car1);
            InMemoryDb.Vehicles.Add(bike1);
            InMemoryDb.Vehicles.Add(vehicle1);
            InMemoryDb.Vehicles.Add(car2);
            InMemoryDb.Vehicles.Add(bike2);
            InMemoryDb.Vehicles.Add(vehicle2);
            InMemoryDb.Vehicles.Add(car3);
            InMemoryDb.Vehicles.Add(bike3);
            InMemoryDb.Vehicles.Add(vehicle3);


            foreach (Vehicle vehicle in InMemoryDb.Vehicles)
            {
                vehicle.PrintVehicle();
            }

            try
            {
                //Car car = new Car(0, "Old Timer", 1960, 001122, 40, new List<string> { "USA", "Germany" });
                //Validator.Validate(car);

                //Vehicle vehicle = new Vehicle(4, "", 1999, 008562);
                //Validator.Validate(vehicle);

                Bike bike = new Bike(7, "Scooter", 0, 009652, "White");
                Validator.Validate(bike);

            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
