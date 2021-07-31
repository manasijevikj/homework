using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Models
{
    public class Reading : Activity 
    {

        public int Pages { get; set; }
        public ReadingEnum? ReadingType { get; set; }

        public Reading(int pages, ReadingEnum readingType, TimeSpan time, int userId)
        {
            ActivityType = Activities.Reading;
            Pages = pages;
            ReadingType = readingType;
            Time = time;
            UserId = userId;
        }



        public override string GetInfo()
        {
            return $"Reading: {ReadingType}, Time: {Time}, Pages: {Pages}, UserId:{UserId}";
        }

        public override string GetInfoActivity()
        {
            return $"Reading: {ReadingType}, Time: {Time}, Pages: {Pages}, UserId:{UserId}";
        }
    }
}
