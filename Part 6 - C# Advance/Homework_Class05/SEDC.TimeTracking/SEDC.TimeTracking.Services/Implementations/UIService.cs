using SEDC.TimeTracking.Domain.Enums;
using SEDC.TimeTracking.Domain.Models;
using SEDC.TimeTracking.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracking.Services.Implementations
{
    public class UIService
    {
        public List<string> MenuItems { get; set; }

        public int ChooseMenuItem(List<string> menuItems)
        {
            while (true)
            {
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menuItems[i]}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, menuItems.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("You must enter a valid option", ConsoleColor.Red);
                    continue;
                }
                return choice;
            }
        }


        public User CreateNewUser()
        {
            User newUser;

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("You must enter first name");
            }

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("You must enter last name");
            }

            Console.WriteLine("Enter age");
            string age = Console.ReadLine();
            if (string.IsNullOrEmpty(age))
            {
                throw new Exception("You must enter age");
            }

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("You must enter username");
            }

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("You must enter password");
            }

            newUser = new User(firstName, lastName, age, username, password);

            return newUser;
        }




        public int LogInMenu()
        {
            List<string> menuItems = new List<string> { "LogIn", "Register" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int ActivityMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(Activities)).ToList();
            menuItems.Add("Back to Main Menu");
            Console.WriteLine("Choose activity");
            return ChooseMenuItem(menuItems);
        }

        public int WorkingMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(WorkingEnum)).ToList();
            Console.WriteLine("Choose working option");
            return ChooseMenuItem(menuItems);
        }

        public int ReadingMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(ReadingEnum)).ToList();
            Console.WriteLine("Choose reading option");
            return ChooseMenuItem(menuItems);
        }

        public int ExercisingMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(ExercisingEnum)).ToList();
            Console.WriteLine("Choose exercising option");
            return ChooseMenuItem(menuItems);
        }



        public int UserStatisticsMenu()
        {
            List<string> menuItems = new List<string> { "Reading", "Exercising", "Working", "Hobbies", "Global", "Back to Main Menu" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int ReadingStatisticsMenu()
        {
            List<string> menuItems = new List<string> { "Total Time", "Average of all activity records", "Total number of pages", "Favorite Type" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int ExercisingStatisticsMenu()
        {
            List<string> menuItems = new List<string> { "Total Time", "Average of all activity records", "Favorite Type" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }


        public int WorkingStatisticsMenu()
        {
            List<string> menuItems = new List<string> { "Total Time", "Average of all activity records", "Home VS Office" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }


        public int HobbiesStatisticsMenu()
        {
            List<string> menuItems = new List<string> { "Total Time", "All hobies" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }


        public int GlobalStatisticsMenu()
        {
            List<string> menuItems = new List<string> { "Total Time", "Favorite activity" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int AccountMenu()
        {
            List<string> accountMenuItems = new List<string>() { "Change First Name", "Change Last Name", "Change Password", "Deactivate Account", "Back to Main Menu" };
            return ChooseMenuItem(accountMenuItems);
        }

        public int YesNoMenu()
        {
            List<string> accountMenuItems = new List<string>() { "Yes", "No" };
            return ChooseMenuItem(accountMenuItems);
        }

        public int MainMenu()
        {
            List<string> menuItems = new List<string> { "Start Activity", "User Statistics", "Predefined Activities", "Account", "LogOut" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }




    }
}
