using System;
using System.Collections.Generic;
using Task4.Classes;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Ann", "Mcnally", 35));
            employees.Add(new Employee("Saba", "Webster", 51));
            employees.Add(new Employee("Grayson", "Ball", 29));
            employees.Add(new Employee("Danny", "Maxwell", 32));
            employees.Add(new Employee("Coral", "Black", 22));
            employees.Add(new Employee("Dilara", "Edwards", 47));
            employees.Add(new Employee("Ewen", "Stone", 44));
            employees.Add(new Employee("Maci ", "Bowden", 51));
            employees.Add(new Employee("Tia", "Simmonds", 29));
            employees.Add(new Employee("Dane", "Rush", 35));

            Dictionary<int, List<string>> employeeD = new Dictionary<int, List<string>>();

            foreach(Employee employee in employees)
            {
                if(employeeD.ContainsKey(employee.Age))
                {
                    List<string> tempList = employeeD[employee.Age];
                    tempList.Add($"{ employee.FirstName} {employee.LastName}");
                    employeeD[employee.Age] = tempList;
                }
                else
                {
                    employeeD.Add(employee.Age, new List<string> { $"{ employee.FirstName} {employee.LastName}" });
                }
            } 

            foreach(var item in employeeD)
            {
                Console.WriteLine("Age: "+item.Key);
                foreach(string fullName in item.Value)
                {
                    Console.WriteLine(fullName);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();

        }
    }
}
