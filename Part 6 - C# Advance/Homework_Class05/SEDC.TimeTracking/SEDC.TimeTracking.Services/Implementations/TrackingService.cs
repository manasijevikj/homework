
using SEDC.TimeTracking.Domain.Database;
using SEDC.TimeTracking.Domain.Enums;
using SEDC.TimeTracking.Domain.Models;
using SEDC.TimeTracking.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Activity = SEDC.TimeTracking.Domain.Models.Activity;

namespace SEDC.TimeTracking.Services.Implementations
{
    public class TrackingService<T> : ITrackingService<T> where T : Domain.Models.Activity
    {
        private FileDatabase<T> _databaseActivities;

        public TrackingService()
        {
            _databaseActivities = new FileDatabase<T>();
        }

        public void AddActivity(T activity)
        {
            _databaseActivities.Insert(activity);
        }

        public T FindActivityById(T activity)
        {
            return _databaseActivities.GetbyId(activity.Id);
        }

        public List<T> GetDatabase()
        {

            return _databaseActivities.GetAll();
        }


        public TimeSpan StopwatchActivity()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting activity");
            stopwatch.Start();
            Console.WriteLine("Press enter if you want to stop.");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            while (consoleKeyInfo.Key != ConsoleKey.Enter)
            {
                consoleKeyInfo = Console.ReadKey();
            }

            Console.WriteLine("You pressed Enter and activity stopped");
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            return ts;
        }

        public int TotalTime(User user)
        {
            List<TimeSpan> times = _databaseActivities.GetAll().Where(x => x.UserId == user.Id).Select(x => x.Time).ToList();

            TimeSpan totalTime = TimeSpan.Zero;
            foreach (TimeSpan ts in times)
            {
                totalTime += ts;
            }
            return totalTime.Seconds;
        }

        public int AvgActivity(User user)
        {
            List<TimeSpan> times = _databaseActivities.GetAll().Where(x => x.UserId == user.Id).Select(x => x.Time).ToList();

            int timesCount = times.Count();
            int totalSeconds;
            int result;

            TimeSpan totalTime = TimeSpan.Zero;
            foreach (TimeSpan ts in times)
            {
                totalTime += ts;
            }
            totalSeconds = totalTime.Seconds;

            if (timesCount == 0)
            {
                result = 0;
            }
            else
            {
                result = (totalTime.Seconds) / timesCount;
            }

            return result;
        }

        public int TotalPages(User user)
        {
            List<T> readingActivities = _databaseActivities.GetAll().Where(x => x.UserId == user.Id).Where(x => x.ActivityType == Domain.Enums.Activities.Reading).ToList();

            int totalPages = 0;
            Reading rTemp = null;

            for (int i = 0; i < readingActivities.Count; i++)
            {
                rTemp = readingActivities.ElementAt(i) as Reading;
                totalPages += rTemp.Pages;

            }
            return totalPages;
        }





        public string FavoriteTypeReading(User user, List<Reading> database)
        {
            List<Reading> activities = database.Where(x => x.UserId == user.Id).ToList();
            string favorite = "No one";


            int? bellesLettresNum = activities.Where(x => x.ReadingType == ReadingEnum.BellesLettres).Count();
            int? fictionNum = activities.Where(x => x.ReadingType == ReadingEnum.Fiction).Count();
            int? professionalLiteratureNum = activities.Where(x => x.ReadingType == ReadingEnum.ProfessionalLiterature).Count();

            if (bellesLettresNum == null)
            {
                bellesLettresNum = 0;
            }

            if (fictionNum == null)
            {
                fictionNum = 0;
            }

            if (professionalLiteratureNum == null)
            {
                professionalLiteratureNum = 0;
            }

            List<int?> ints = new List<int?> { bellesLettresNum, fictionNum, professionalLiteratureNum };
            int? result = ints.Max();


            if (bellesLettresNum == result)
            {
                favorite = "Belles Lettres";
            }
            if (fictionNum == result)
            {
                favorite = "Fiction";
            }
            if (professionalLiteratureNum == result)
            {
                favorite = "Professional Literature";
            }

            bool all = ints.All(x => x == result);
            if (all)
            {
                favorite = "Belles Lettres, Fiction and Professional Literature ";
            }

            bool allZero = ints.All(x => x == 0);
            if (allZero)
            {
                favorite = "Not inserted data yet";
            }
            return favorite;
        }



        public string FavoriteTypeExercising(User user, List<Exercising> database)
        {
            List<Exercising> activities = database.Where(x => x.UserId == user.Id).ToList();
            string favorite = "";


            int? generalNum = activities.Where(x => x.ExercisingType == ExercisingEnum.General).Count();
            int? runningNum = activities.Where(x => x.ExercisingType == ExercisingEnum.Running).Count();
            int? sportNum = activities.Where(x => x.ExercisingType == ExercisingEnum.Sport).Count();

            if (generalNum == null)
            {
                generalNum = 0;
            }

            if (runningNum == null)
            {
                runningNum = 0;
            }

            if (sportNum == null)
            {
                sportNum = 0;
            }

            List<int?> ints = new List<int?> { generalNum, runningNum, sportNum };
            int? result = ints.Max();


            if (generalNum == result)
            {
                favorite = "General";
            }
            if (runningNum == result)
            {
                favorite = "Running";
            }
            if (sportNum == result)
            {
                favorite = "Sport";
            }

            bool all = ints.All(x => x == result);
            if (all)
            {
                favorite = "General, Running and Sport ";
            }

            bool allZero = ints.All(x => x == 0);
            if (allZero)
            {
                favorite = "Not inserted data yet";
            }
            return favorite;
        }


        public Dictionary<string, TimeSpan> HomeVSOffice(User user, List<Working> database)
        {
          
            List<TimeSpan> timesHome = database.Where(x => x.UserId == user.Id).Where(x => x.WorkingType == WorkingEnum.Home).Select(x => x.Time).ToList();
            List<TimeSpan> timesOfice = database.Where(x => x.UserId == user.Id).Where(x => x.WorkingType == WorkingEnum.Office).Select(x => x.Time).ToList();

            TimeSpan totalTimeHome = TimeSpan.Zero;
            foreach (TimeSpan ts in timesHome)
            {
                totalTimeHome += ts;
            }

            TimeSpan totalTimeOffice = TimeSpan.Zero;
            foreach (TimeSpan ts in timesOfice)
            {
                totalTimeOffice += ts;
            }

            return new Dictionary<string, TimeSpan>() { { "Home", totalTimeHome }, { "Office", totalTimeOffice } };
        }


        public List<string> AllHobies(User user, List<OtherHobbies> database)
        {

            List<string> allHobiesList = database.Where(x => x.UserId == user.Id).Select(x => x.Name).Distinct().ToList();

            return allHobiesList;
        }


        public static int TotalTimeActivities(User user, List<Reading> readingData, List<Exercising> exercisingData, List<Working> workingData, List<OtherHobbies> hobiesData)
        {

            List<TimeSpan> readingTimes = readingData.Where(x => x.UserId == user.Id).Select(x => x.Time).ToList();
            List<TimeSpan> exercisingTimes = exercisingData.Where(x => x.UserId == user.Id).Select(x => x.Time).ToList();
            List<TimeSpan> workingTimes = workingData.Where(x => x.UserId == user.Id).Select(x => x.Time).ToList();
            List<TimeSpan> hobiesTimes = hobiesData.Where(x => x.UserId == user.Id).Select(x => x.Time).ToList();


            TimeSpan totalTime = TimeSpan.Zero;
            foreach (TimeSpan ts in readingTimes)
            {
                totalTime += ts;
            }
            foreach (TimeSpan ts in exercisingTimes)
            {
                totalTime += ts;
            }
            foreach (TimeSpan ts in workingTimes)
            {
                totalTime += ts;
            }
            foreach (TimeSpan ts in hobiesTimes)
            {
                totalTime += ts;
            }

            return totalTime.Seconds;
        }

        public static string FavoriteActivity(User user, List<Reading> readingData, List<Exercising> exercisingData, List<Working> workingData, List<OtherHobbies> hobiesData)
        {
            string favorite = "";

            int? readingNum = readingData.Where(x => x.UserId == user.Id).Count();
            int? exercisingNum = exercisingData.Where(x => x.UserId == user.Id).Count();
            int? workingNum = workingData.Where(x => x.UserId == user.Id).Count();
            int? hobiesNum = hobiesData.Where(x => x.UserId == user.Id).Count();

            if (readingNum == null)
            {
                readingNum = 0;
            }

            if (exercisingNum == null)
            {
                exercisingNum = 0;
            }

            if (workingNum == null)
            {
                workingNum = 0;
            }

            if (hobiesNum == null)
            {
                hobiesNum = 0;
            }

            List<int?> ints = new List<int?> { readingNum, exercisingNum, workingNum, hobiesNum };
            int? result = ints.Max();


            if (readingNum == result)
            {
                favorite = "Reading";
            }
            if (exercisingNum == result)
            {
                favorite = "Exercising";
            }
            if (workingNum == result)
            {
                favorite = "Working";
            }
            if (hobiesNum == result)
            {
                favorite = "Hobies";
            }

            bool all = ints.All(x => x == result);
            if (all)
            {
                favorite = "Reading, Exercising, Working and Hobies ";
            }

            bool allZero = ints.All(x => x == 0);
            if (allZero)
            {
                favorite = "no one";
            }
            return favorite;

        }


    }
}


