using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string day, month, year, birthday;

            Console.WriteLine("Write your birthday.");

            Console.WriteLine("Day:");
            day = Console.ReadLine();
            Console.WriteLine("Month:");
            month = Console.ReadLine();
            Console.WriteLine("Year:");
            year = Console.ReadLine();

            birthday = $"{year}, {month}, {day}";
            bool success = DateTime.TryParse(birthday, out DateTime parsedDate);

            if (success)
            {
                
                AgeCalculator(parsedDate);

            } 
            else
            {
                Console.WriteLine("Your input is not valid. Try again.");
            }
            Console.ReadLine();
        }

        public static void AgeCalculator(DateTime input)
        {
            DateTime currentDay = DateTime.Today;
            int age;
            
            if ((input.Year > currentDay.Year)
                || (input.Year == currentDay.Year && input.Month > currentDay.Month)
                || input.Year == currentDay.Year && input.Month == currentDay.Month && input.Day > currentDay.Day)
            {
                Console.WriteLine("You are not born yet.");
            }
            else
            {
                age = currentDay.Year - input.Year; 

                if (input.Month > currentDay.Month) 
                {
                    age--;
                    Console.WriteLine("You are " + age + " years old.");
                }
                else if(input.Month == currentDay.Month)
                {
                    if(input.Day > currentDay.Day)
                    {
                        age--;
                        Console.WriteLine("You are "+age+" years old.");
                    }
                    else if(input.Day == currentDay.Day)
                    {
                        if(age == 0)
                        {
                            Console.WriteLine("You are born today.");
                        }
                        else
                        {
                            Console.WriteLine("Today is your birthday. You are now " + age + " years old.");
                        }                       
                    }
                    else
                    {
                        Console.WriteLine("You are " + age + " years old.");
                    }           
                }
                else
                {
                    Console.WriteLine("You are " + age + " years old.");
                }
            }
        }
    }
}
