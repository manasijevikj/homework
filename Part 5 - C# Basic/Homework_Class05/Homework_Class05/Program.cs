using Homework_Class05.Classes;
using System;

namespace Homework_Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car[] cars = new Car[]
            {
                new Car("Hyundai", 150),
                new Car("Mazda", 140),
                new Car("Ferrari", 200),
                new Car("Porsche", 190)
             };

            Driver[] drivers = new Driver[]
            {
                new Driver("Bob", 2),
                new Driver("Greg", 1),
                new Driver("Jill", 4),
                new Driver("Anne", 3)
            };

            CarsAndDrivers(cars, drivers);

            Console.ReadLine();
        }

        public static Car RaceCars(Car car1, Car car2)
        {
            if(car1.GetType() == typeof(Car) && car2.GetType() == typeof(Car))
            {
                int case1 = car1.CalculateSpeed(car1.Driver);
                int case2 = car2.CalculateSpeed(car2.Driver);

                if(case1 <= 0)
                {
                    Console.WriteLine("The first car doesn't move.");
                    return null;
                }
                else if (case2 <= 0)
                {
                    Console.WriteLine("The second car doesn't move.");
                    return null;
                }
                else
                {
                    if(case1 > case2)
                    {
                        Console.WriteLine("The first car is faster then the second car.");
                        return car1;
                    }
                    else  if(case2 > case1)
                    {
                        Console.WriteLine("The second car is faster then the first car.");
                        return car2;
                    }
                    else
                    {
                        Console.WriteLine("They are equaly fast.");
                        return null;
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong Input.");
                return null;
            }
        }

        public static void CarsAndDrivers(Car []cars, Driver []drivers)
        {
            string car1, car2, driver1, driver2;
            Car firstCar, secondCar;
            Car[] resultCars;
            Driver[] resultDrivers;

            Console.WriteLine("Cars:");
            foreach(Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Drivers:");
            foreach (Driver driver in drivers)
            {
                Console.WriteLine(driver.Name);
            }
            Console.WriteLine(" ");
            while (true)
            {
                Console.WriteLine("Choose a car no.1:");
                car1 = Console.ReadLine();

                Console.WriteLine("Choose a driver no.1:");
                driver1 = Console.ReadLine();

                if (ValidateCar(cars, car1) == null || ValidateDriver(drivers, driver1) == null)
                {
                    Console.WriteLine("Your choice is incorrect");           
                }
                else
                {
                    Car resultCar = ValidateCar(cars, car1);
                    Driver resultDriver = ValidateDriver(drivers, driver1);
                    firstCar = new Car(resultCar.Model, resultCar.Speed, resultDriver);

                    resultCars = NewCarsList(cars, resultCar);
                    resultDrivers = NewDriversList(drivers, resultDriver);


                    Console.WriteLine("You chose car: " + (resultCar.Model));
                    Console.WriteLine("You chose driver: " + (resultDriver.Name));
                    break;
                }
            }
           

            while (true)
            {
                Console.WriteLine("Choose a car no.2:");
                car2 = Console.ReadLine();

                Console.WriteLine("Choose a driver no.2:");
                driver2 = Console.ReadLine();

                if (ValidateCar(resultCars, car2) == null || ValidateDriver(resultDrivers, driver2) == null)
                {
                    Console.WriteLine("Your choice is incorrect");
                }
                else
                {
                    Car resultCar2 = ValidateCar(resultCars, car2);
                    Driver resultDriver2 = ValidateDriver(resultDrivers, driver2);
                    secondCar = new Car(resultCar2.Model, resultCar2.Speed, resultDriver2);
                    Console.WriteLine("You chose car: " + (resultCar2.Model));
                    Console.WriteLine("You chose driver: " + (resultDriver2.Name));
                    break;
                }
            }

            Car wCar = RaceCars(firstCar, secondCar);
            InfoAboutWinner(wCar);
            RaceAgain(cars, drivers);

        }

        public static Car ValidateCar(Car []cars, string carName)
        {
            foreach(Car car in cars)
            {
                if(car.Model.ToLower() == carName.ToLower())
                {
                    Car result = new Car(car.Model, car.Speed);
                    return result;
                }
            }
            return null;
        }

        public static Driver ValidateDriver(Driver[] drivers, string driverName)
        {
            foreach (Driver driver in drivers)
            {
                if (driver.Name.ToLower() == driverName.ToLower())
                {
                    Driver result = new Driver(driver.Name, driver.Skill);
                    return result;
                }
            }
            return null;
        }

        public static void InfoAboutWinner(Car winner)
        {
            Console.WriteLine($"The model of the faster car is {winner.Model}, with speed of {winner.Speed} km/h" +
                $" and its driver is {winner.Driver.Name}");
        }

        public static Car[] NewCarsList(Car[] cars, Car car)
        {
            Car[] newCarsList = new Car[0];
            int counter = 0;
            foreach(Car tempCar in cars)
            {
                if(tempCar.Model != car.Model)
                {
                    counter++;
                    Array.Resize(ref newCarsList, counter);
                    newCarsList[counter - 1] = tempCar;
                }
            }
            return newCarsList;
        }

        public static Driver[] NewDriversList(Driver[] drivers, Driver driver)
        {
            Driver[] newDriversList = new Driver[0];
            int counter = 0;
            foreach (Driver tempDriver in drivers)
            {
                if (tempDriver.Name != driver.Name)
                {
                    counter++;
                    Array.Resize(ref newDriversList, counter);
                    newDriversList[counter - 1] = tempDriver;
                }
            }
            return newDriversList;
        }

        public static void RaceAgain(Car[] cars, Driver[] drivers)
        {
            while(true)
            {
                Console.WriteLine("Do you want to race again? Y for Yes, N for No");
                string answer = Console.ReadLine();

                if(answer.ToLower() == "y")
                {
                    CarsAndDrivers(cars, drivers);
                    break;
                }
                else if(answer.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect answer");
                }
            }          
        }
    }
}
