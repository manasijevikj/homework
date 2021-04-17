using Domain.Classes;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager1 = new Manager("Mona", "Monalisa", 800, "Finance");
            Manager manager2 = new Manager("Igor", "Igorsky", 750, "Business");

            Contractor contractor1 = new Contractor("Bob","Bobert",40, 5, manager1);
            Contractor contractor2 = new Contractor("Rick", "Rickert", 40, 6, manager2);

            SalesPerson salesPerson = new SalesPerson("Lea", "Leova");

            Employee[] company = new Employee[] { manager1, manager2, contractor1, contractor2, salesPerson };

            CEO ceo = new CEO("Leo", "Leonsky", company, 15, 1500);

            ceo.PrintInfo();
            Console.WriteLine("Salary of CEO is: "+ ceo.GetSalary());
            ceo.PrintEmployees();
            Console.ReadLine();
        }
    }
}
