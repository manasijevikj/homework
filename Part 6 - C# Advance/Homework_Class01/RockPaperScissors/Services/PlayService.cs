using RockPaperScissors.Domain;
using RockPaperScissors.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Services
{
    public class PlayService
    {
        public static void StartPlay(User me, User cpu)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Pick rock, paper or scissors:");
                    string myItem = Console.ReadLine();
                    bool valid = false;

                    foreach (Item item in Enum.GetValues(typeof(Item)))
                    {
                        string itemString = item.ToString();
                        if (itemString.ToLower() == myItem.ToLower())
                        {
                            me.Item = item;
                            valid = true;
                            Console.WriteLine("You picked " + item+".");
                            break;
                        }
                    }
                    if(!valid)
                    {
                        throw new Exception("Invalid Option, try again.");
                    }
                    else
                    {                   
                        break;
                    }                  
                } 
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            cpu.RandomItem();
            Console.WriteLine("The application randomly picked " + cpu.Item+".");
        }

        public static void WhoWin(User me, User cpu)
        {
            if(me.Item == Item.Rock)
            {
                if(cpu.Item == Item.Rock)
                {
                    Console.WriteLine("You both picked rock, it's equale.");
                    me.Draw++;
                    cpu.Draw++;
                }
                else if(cpu.Item == Item.Paper)
                {
                    Console.WriteLine("The application won.");
                    cpu.Wins++;
                }
                else
                {
                    Console.WriteLine("I won.");
                    me.Wins++;
                }
            }
            else if(me.Item == Item.Paper)
            {
                if (cpu.Item == Item.Rock)
                {
                    Console.WriteLine("I won.");
                    me.Wins++;
                }
                else if (cpu.Item == Item.Paper)
                {
                    Console.WriteLine("You both picked paper, it's equale.");
                    me.Draw++;
                    cpu.Draw++;
                }
                else
                {
                    Console.WriteLine("The application won.");
                    cpu.Wins++;
                }
            }
            else
            {
                if (cpu.Item == Item.Rock)
                {
                    Console.WriteLine("The application won.");
                    cpu.Wins++;
                }
                else if (cpu.Item == Item.Paper)
                {
                    Console.WriteLine("I won.");
                    me.Wins++;
                }
                else
                {
                    Console.WriteLine("You both picked scissors, it's equale.");
                    me.Draw++;
                    cpu.Draw++;
                }
            }
        }
    }
}
