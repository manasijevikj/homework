using RockPaperScissors.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Domain
{
    public class User
    {
        public string Name { get; set; }

        public int Wins { get; set; }
        public int Draw { get; set; }
        public Item Item { get; set; }


        public User(string name)
        {
            Name = name;
            Wins = 0;
            Draw = 0;

        }

        public void RandomItem()
        {
            Random getRandom = new Random();
            int number = getRandom.Next(1, 4);
            if(number == 1)
            {
                Item = Item.Rock;
            }
            else if(number == 2)
            {
                Item = Item.Paper;
            }
            else if(number == 3)
            {
                Item = Item.Sciccors;
            }
        }  
    }
}
