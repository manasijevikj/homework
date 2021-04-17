using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible) : base(firstName, lastName)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
            Role = RoleEnum.Contractor;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return WorkHours * PayPerHour;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
