using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Models
{
    public class Exercising : Activity
    {

        public ExercisingEnum ExercisingType;

        public Exercising(ExercisingEnum exercisingType, TimeSpan time, int userId)
        {
            ActivityType = Activities.Exercising;
            ExercisingType = exercisingType;
            Time = time;
            UserId = userId;
        }

         
        public override string GetInfo()
        {
            return $"Exercising: {ExercisingType}, Time: {Time}";
        }

        public override string GetInfoActivity()
        {
            return $"Exercising: {ExercisingType}, Time: {Time}";
        }
    }
}
