using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Manager : Employee
    {
        public string Department { get; set; }
        private double _bonus { get; set; }

        public Manager(string firstName, string lastName, double salary, string department) : base(firstName, lastName)
        {
            Department = department;
            Role = RoleEnum.Manager;
            Salary = salary;
            _bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }


    }
}
