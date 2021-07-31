using SEDC.TimeTracking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Services.Interfaces
{
    public interface ITrackingService<T> where T: Activity
    {
        void AddActivity(T activity);
        T FindActivityById(T activity);
        TimeSpan StopwatchActivity();
    }
}
