using System;
using System.Collections.Generic;


namespace Homework_Class05.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }


        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;        
        }

        public int CalculateSpeed(Driver input)
        {
            int result = Speed * input.Skill;

            return result;
        }

    }
}
