using SEDC.TimeTracking.Domain.Enums;
using System;

namespace SEDC.TimeTracking.Domain.Models
{
    public class Working : Activity
    {

        public WorkingEnum WorkingType;

        public Working(WorkingEnum workingType, TimeSpan time, int userId)
        {
            ActivityType = Activities.Working;
            WorkingType = workingType;
            Time = time;
            UserId = userId;
        }


        public override string GetInfo()
        {
            return $"Working: at {WorkingType}, Time: {Time}";
        }
        public override string GetInfoActivity()
        {
            return $"Working: at {WorkingType}, Time: {Time}";
        }
    }
}
