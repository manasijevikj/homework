using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartDate = new DateTime(1999, 01, 01);
            DateTime EndDate = DateTime.Now;
            string myDate, year, month, day;
            bool validDay = false;

            List<DateTime> selectedDates = new List<DateTime>();
            List<DateTime> saturdays = new List<DateTime>();
            List<DateTime> sundays = new List<DateTime>();
            List<DateTime> holidays = new List<DateTime>();


            DateTime aCustomDate = new DateTime(1992, 01, 15);


            for (var date = StartDate; date <= EndDate; date = date.AddDays(1))
            {
                selectedDates.Add(date);
            }

            saturdays = selectedDates.Where(day => day.DayOfWeek.ToString() == "Saturday").ToList();
            sundays = selectedDates.Where(day => day.DayOfWeek.ToString() == "Sundays").ToList();
            holidays = selectedDates.Where(day => ((day.Month.ToString() == "1") && ((day.Day.ToString() == "1") ||
            (day.Day.ToString() == "7"))) || ((day.Month.ToString() == "4") && (day.Day.ToString() == "20")) ||
            ((day.Month.ToString() == "5") && ((day.Day.ToString() == "1") || (day.Day.ToString() == "25"))) ||
            ((day.Month.ToString() == "8") && (day.Day.ToString() == "3")) || ((day.Month.ToString() == "9") && (day.Day.ToString() == "8")) ||
            ((day.Month.ToString() == "10") && ((day.Day.ToString() == "12") || (day.Day.ToString() == "23"))) ||
            ((day.Month.ToString() == "12") && (day.Day.ToString() == "8"))).ToList();


            while (!validDay)
            {
                try
                {
                    Console.WriteLine("Enter a date between " + (StartDate.ToShortDateString()) + " and " + (EndDate.ToShortDateString()));

                    Console.WriteLine("Enter a year");
                    year = Console.ReadLine();

                    Console.WriteLine("Enter a month");
                    month = Console.ReadLine();

                    Console.WriteLine("Enter a day");
                    day = Console.ReadLine();

                    myDate = $"{year} {day} {month}";

                    if (DateTime.TryParse(myDate, out DateTime dateValue))
                    {
                        if (selectedDates.Contains(dateValue))
                        {

                            if (saturdays.Contains(dateValue) && holidays.Contains(dateValue))
                            {
                                Console.WriteLine("Saturday and Holiday. It's not working day.");
                            }
                            else if (sundays.Contains(dateValue) && holidays.Contains(dateValue))
                            {
                                Console.WriteLine("Sunday and Holiday. It's not working day.");
                            }
                            else if (saturdays.Contains(dateValue))
                            {
                                Console.WriteLine("Saturday. It's not working day.");
                            }
                            else if (sundays.Contains(dateValue))
                            {
                                Console.WriteLine("Sunday. It's not working day.");
                            }
                            else if (holidays.Contains(dateValue))
                            {
                                Console.WriteLine("Holiday. It's not working day.");
                            }
                            else
                            {
                                Console.WriteLine("It's working day.");
                                
                            }
                            validDay = true;
                        }
                        else
                        {
                            throw new Exception("Your date is not in the range, try again.");
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid Date, try again.");
                    }
                }

                catch (NullReferenceException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.ReadLine();
        }
    }
}
