using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public CEO(string firstName, string lastName, Employee[] employeesArray, int shares, double salary) : base(firstName, lastName)
        {
            Employees = employeesArray;
            Shares = shares;
            Role = RoleEnum.CEO;
            Salary = salary;
        }

        public void PrintEmployees()
        {
            if(Employees ==  null)
            {
                Console.WriteLine("There are not Employees");
            }
            else
            {
                Console.WriteLine("Employees:");
                foreach(Employee employee in Employees)
                {
                    employee.PrintInfo();
                }
            }
        }

        public override double GetSalary()
        {
            return Salary+(Shares*_sharesPrice);
        }

        public void AddSharesPrice(int price)
        {
            if (price == 0)
            {
                price = 5;
            }
            _sharesPrice += price;
        }
    }
}
