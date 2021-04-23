using RockPaperScissors.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Services
{
    public class StatsService
    {

        public static void ShowWinsStats(User me, User cpu)
        {
            Console.WriteLine($"{me.Name}: {me.Wins} wins");
            Console.WriteLine($"{cpu.Name}: {cpu.Wins} wins");
        }
         

        public static void ShowWinsPercentage(User me, User cpu)
        {
            float meP = (me.Wins) / (float)((me.Wins) + (me.Draw));
            float cpuP = (cpu.Wins) / (float)((cpu.Wins) + (cpu.Draw));

            if (float.IsNaN(meP) || float.IsNaN(cpuP))    
            {
                meP = 0;
                cpuP = 0;
            }

            string percentM = string.Format("{0:P}", meP);
            string percentC = string.Format("{0:P}", cpuP);

            Console.WriteLine($"{me.Name}: {percentM} winning percentage");
            Console.WriteLine($"{cpu.Name}: {percentC} winning percentage");

        }

    }
}
