using RockPaperScissors.Domain;
using System;
using RockPaperScissors.Services;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            User me = new User("Me"); ;
            User cpu = new User("Cpu");
            while (true)
            {
                try
                {
                    Console.WriteLine("Pick one option in menu:");
                    Console.WriteLine("Play \nStats \nExit ");
                    string option = Console.ReadLine();

                    if (option.ToLower() == "play")
                    {
                        PlayService.StartPlay(me, cpu);
                        PlayService.WhoWin(me, cpu);

                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }

                    else if (option.ToLower() == "stats")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        StatsService.ShowWinsStats(me, cpu);
                        StatsService.ShowWinsPercentage(me, cpu);
                        Console.ForegroundColor = ConsoleColor.White;

                        ConsoleKey key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Enter)
                        {
                            continue;
                        }

                    }
                    else if (option.ToLower() == "exit")
                    {
                        Environment.Exit(0);
                    }

                    else
                    {
                        throw new Exception("Invalid input, try again.");
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
        }  
    }
}
