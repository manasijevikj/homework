using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }


        public Employee()
        {
            Salary = 600;
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;        
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Role}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

    }
}
