using SEDC.TimeTracking.Domain.Enums;
using System;


namespace SEDC.TimeTracking.Domain.Models
{
    public class OtherHobbies : Activity
    {

        public string Name;

        public OtherHobbies(TimeSpan time, string name, int userId)
        {
            ActivityType = Activities.Other;
            Time = time;
            Name = name;
            UserId = userId;
        }


        public override string GetInfo()
        {
            return $"Other Hobbie: {Name}, Time: {Time}";
        }

        public override string GetInfoActivity()
        {
            return $"Other Hobbie: {Name}, Time: {Time}";
        }
    }
}
