using SEDC.TimeTracking.Domain.Enums;
using SEDC.TimeTracking.Domain.Interfaces;
using System;

namespace SEDC.TimeTracking.Domain.Models
{
    public abstract class Activity : BaseEntity, IActivity
    {
        public TimeSpan Time { get; set; }
        public int UserId { get; set; }
        public Activities ActivityType { get; set; }
         
        public abstract string GetInfoActivity();
    }
}

