using SEDC.TimeTracking.Domain.Enums;
using SEDC.TimeTracking.Domain.Models;
using SEDC.TimeTracking.Services.Helpers;
using SEDC.TimeTracking.Services.Implementations;
using System;
using System.Collections.Generic;


namespace SEDC.TimeTracking.App
{
    class Program
    {
        public static UserService _userService = new UserService();
        public static UIService _uiService = new UIService();
        public static TrackingService<Reading> _readingTrackingService = new TrackingService<Reading>();
        public static TrackingService<Working> _workingTrackingService = new TrackingService<Working>();
        public static TrackingService<Exercising> _exercisingTrackingService = new TrackingService<Exercising>();
        public static TrackingService<OtherHobbies> _otherTrackingService = new TrackingService<OtherHobbies>();
        public static User _currentUser;


        static void Main(string[] args)
        {
            //Call Seed when you don't work with file db
            //Seed(); 
            int? option = null;

            while (true)  
            {
                if (option == null)
                {
                    option = _uiService.LogInMenu();
                }

                while (true) 
                {
                    if (option == null)
                    {
                        option = _uiService.LogInMenu();
                    }

                    if (option == 1)
                    {

                        Console.WriteLine("Enter username");
                        string username = Console.ReadLine();
                        if (string.IsNullOrEmpty(username))
                        {
                            throw new Exception("You must enter username");
                        }
                        Console.WriteLine("Enter password");
                        string password = Console.ReadLine();
                        if (string.IsNullOrEmpty(password))
                        {
                            throw new Exception("You must enter password");
                        }

                        User logInUser = _userService.LogIn(username, password);
                        if (logInUser != null)
                        {
                            if (logInUser.Active == false)
                            {
                                MessageHelper.PrintMessage($"Your account is deativated. Do you want to activate again?", ConsoleColor.Yellow);
                                int yesNo = _uiService.YesNoMenu();

                                if (yesNo == 1)
                                {
                                    _userService.ActivateAccount(logInUser.Id);
                                    _currentUser = logInUser;
                                    break;
                                }
                                else if (yesNo == 2)
                                {
                                    _currentUser = null;
                                    option = null;
                                    continue;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                MessageHelper.PrintMessage($"Successfully logged in", ConsoleColor.Green);
                                _currentUser = logInUser;
                                break;
                            }

                        }                       
                    }
                    else if (option == 2)
                    {
                        User newUser = _uiService.CreateNewUser();
                        _currentUser = _userService.Register(newUser);
                        if (_currentUser != null)
                        {
                            Console.Clear();
                            MessageHelper.PrintMessage($"Successfully registered", ConsoleColor.Green);
                            break;
                        }

                    }
                }



                while (true) // Main menu
                {
                    int optionMenu = _uiService.MainMenu();

                    if (optionMenu == 1)
                    {
                        int optionActivity = _uiService.ActivityMenu();

                        if (optionActivity >= 1 && optionActivity <= 5)
                        {
                            switch (optionActivity)
                            {
                                case 1:
                                    int optionReading = _uiService.ReadingMenu();
                                    TimeSpan time1 = _readingTrackingService.StopwatchActivity();
                                    Reading readingActivity;

                                    Console.WriteLine("How many pages have you read?");
                                    string pages = Console.ReadLine();
                                    bool success = int.TryParse(pages, out int pagesNumber);

                                    if (success)
                                    {
                                        if (optionReading == 1)
                                        {
                                            readingActivity = new Reading(pagesNumber, ReadingEnum.BellesLettres, time1, _currentUser.Id);
                                            _readingTrackingService.AddActivity(readingActivity);
                                            string info = readingActivity.GetInfoActivity();
                                            Console.WriteLine(info);
                                            continue;
                                        }
                                        else if (optionReading == 2)
                                        {
                                            readingActivity = new Reading(pagesNumber, ReadingEnum.Fiction, time1, _currentUser.Id);
                                            _readingTrackingService.AddActivity(readingActivity);
                                            string info = readingActivity.GetInfoActivity();
                                            Console.WriteLine(info);
                                            continue;
                                        }
                                        else if (optionReading == 3)
                                        {
                                            readingActivity = new Reading(pagesNumber, ReadingEnum.ProfessionalLiterature, time1, _currentUser.Id);
                                            _readingTrackingService.AddActivity(readingActivity);
                                            string info = readingActivity.GetInfoActivity();
                                            Console.WriteLine(info);
                                            Console.WriteLine(_currentUser.Id);
                                            continue;
                                        }
                                        //break;
                                    }
                                    break;
                                case 2:
                                    int optionExercising = _uiService.ExercisingMenu();
                                    TimeSpan time2 = _exercisingTrackingService.StopwatchActivity();

                                    Exercising exercisingActivity;

                                    if (optionExercising == 1)
                                    {
                                        exercisingActivity = new Exercising(ExercisingEnum.General, time2, _currentUser.Id);
                                        _exercisingTrackingService.AddActivity(exercisingActivity);
                                        string info = exercisingActivity.GetInfoActivity();
                                        Console.WriteLine(info);
                                        continue;
                                    }

                                    else if (optionExercising == 2)
                                    {
                                        exercisingActivity = new Exercising(ExercisingEnum.Running, time2, _currentUser.Id);
                                        _exercisingTrackingService.AddActivity(exercisingActivity);
                                        string info = exercisingActivity.GetInfoActivity();
                                        Console.WriteLine(info);
                                        continue;
                                    }
                                    else if (optionExercising == 3)
                                    {
                                        exercisingActivity = new Exercising(ExercisingEnum.Sport, time2, _currentUser.Id);
                                        _exercisingTrackingService.AddActivity(exercisingActivity);
                                        string info = exercisingActivity.GetInfoActivity();
                                        Console.WriteLine(info);
                                        continue;
                                    }

                                    break;
                                case 3:

                                    int optionWorking = _uiService.WorkingMenu();
                                    TimeSpan time3 = _workingTrackingService.StopwatchActivity();
                                    Working workingActivity;

                                    if (optionWorking == 1)
                                    {
                                        workingActivity = new Working(WorkingEnum.Office, time3, _currentUser.Id);
                                        _workingTrackingService.AddActivity(workingActivity);
                                        string info = workingActivity.GetInfoActivity();
                                        Console.WriteLine(info);
                                        continue;
                                    }

                                    else if (optionWorking == 2)
                                    {
                                        workingActivity = new Working(WorkingEnum.Home, time3, _currentUser.Id);
                                        _workingTrackingService.AddActivity(workingActivity);
                                        string info = workingActivity.GetInfoActivity();
                                        Console.WriteLine(info);
                                        continue;
                                    }
                                    break;
                                case 4:
                                    TimeSpan time4 = _otherTrackingService.StopwatchActivity();
                                    OtherHobbies otherActivity;
                                    Console.WriteLine("Enter the name of the hobby");
                                    string nameOfHobby = Console.ReadLine();
                                    otherActivity = new OtherHobbies(time4, nameOfHobby, _currentUser.Id);
                                    _otherTrackingService.AddActivity(otherActivity);

                                    continue;

                                case 5:
                                    continue;
                            }
                            break;
                        }
                    }


                    else if (optionMenu == 2)
                    {
                        int optionStatistics = _uiService.UserStatisticsMenu();

                        switch (optionStatistics)
                        {
                            case 1:
                                int readingStatsOption = _uiService.ReadingStatisticsMenu();

                                if (readingStatsOption == 1)
                                {
                                    int totalTimeReading = _readingTrackingService.TotalTime(_currentUser);
                                    Console.WriteLine($"Total time of reading {totalTimeReading} seconds");
                                    continue;
                                }

                                else if (readingStatsOption == 2)
                                {
                                    int avgReading = _readingTrackingService.AvgActivity(_currentUser);
                                    Console.WriteLine($"Average time of reading {avgReading} seconds");
                                    continue;
                                }

                                else if (readingStatsOption == 3)
                                {
                                    int totalPages = _readingTrackingService.TotalPages(_currentUser);
                                    Console.WriteLine($"Total read pages {totalPages}");
                                    continue;
                                }

                                else if (readingStatsOption == 4)
                                {

                                    string favoriteType = _readingTrackingService.FavoriteTypeReading(_currentUser, _readingTrackingService.GetDatabase());

                                    Console.WriteLine($"Favorite type:");
                                    Console.WriteLine(favoriteType);
                                    continue;
                                }
                                break;

                            case 2:
                                int exercisingStatsOption = _uiService.ExercisingStatisticsMenu();

                                if (exercisingStatsOption == 1)
                                {
                                    int totalTimeExercasing = _exercisingTrackingService.TotalTime(_currentUser);
                                    Console.WriteLine($"Total time of exercising {totalTimeExercasing} seconds");
                                    continue;
                                }

                                else if (exercisingStatsOption == 2)
                                {
                                    int avgExercising = _exercisingTrackingService.AvgActivity(_currentUser);
                                    Console.WriteLine($"Average time of exercising {avgExercising} seconds");
                                    continue;
                                }

                                else if (exercisingStatsOption == 3)
                                {
                                    string favoriteType = _exercisingTrackingService.FavoriteTypeExercising(_currentUser, _exercisingTrackingService.GetDatabase());

                                    Console.WriteLine($"Favorite type:");
                                    Console.WriteLine(favoriteType);
                                    continue;
                                }
                                break;

                            case 3:
                                int workingStatsOption = _uiService.WorkingStatisticsMenu();


                                if (workingStatsOption == 1)
                                {
                                    int totalTimeExercasing = _workingTrackingService.TotalTime(_currentUser);
                                    Console.WriteLine($"Total time of working {totalTimeExercasing} seconds");
                                    continue;
                                }

                                else if (workingStatsOption == 2)
                                {
                                    int avgWorking = _workingTrackingService.AvgActivity(_currentUser);
                                    Console.WriteLine($"Average time of working {avgWorking} seconds");
                                    continue;
                                }

                                else if (workingStatsOption == 3)
                                {
                                    Dictionary<string, TimeSpan> homeVsOffice = _workingTrackingService.HomeVSOffice(_currentUser, _workingTrackingService.GetDatabase());

                                    Console.WriteLine($"Total time of working at Home: {homeVsOffice["Home"]} seconds");
                                    Console.WriteLine($"Total time of working at Office: {homeVsOffice["Office"]} seconds");
                                    continue;
                                }
                                break;

                            case 4:
                                int hobiesStatsOption = _uiService.HobbiesStatisticsMenu();
                                if (hobiesStatsOption == 1)
                                {
                                    int totalTimeHobies = _otherTrackingService.TotalTime(_currentUser);
                                    Console.WriteLine($"Total time spend on hobies {totalTimeHobies} seconds");
                                    continue;
                                }

                                else if (hobiesStatsOption == 2)
                                {
                                    List<string> hobies = _otherTrackingService.AllHobies(_currentUser, _otherTrackingService.GetDatabase());
                                    Console.WriteLine("Hobies:");
                                    foreach (string hobie in hobies)
                                    {
                                        Console.WriteLine(hobie);
                                    }
                                    continue;
                                }

                                break;
                            case 5:
                                int global = _uiService.GlobalStatisticsMenu();

                                List<Reading> readingData = _readingTrackingService.GetDatabase();
                                List<Exercising> exercisingData = _exercisingTrackingService.GetDatabase();
                                List<Working> workingData = _workingTrackingService.GetDatabase();
                                List<OtherHobbies> hobiesData = _otherTrackingService.GetDatabase();

                                if (global == 1)
                                {
                                    int totalTimes = TrackingService<Activity>.TotalTimeActivities(_currentUser, readingData, exercisingData, workingData, hobiesData);
                                    Console.WriteLine($"Total time of all activities is: {totalTimes} seconds");
                                    continue;
                                }

                                else if (global == 2)
                                {
                                    string favoriteActivity = TrackingService<Activity>.FavoriteActivity(_currentUser, readingData, exercisingData, workingData, hobiesData);
                                    Console.WriteLine($"The favorite activity is {favoriteActivity}");
                                    continue;
                                }

                                break;
                            case 6:

                                continue;
                        }

                    }


                    else if (optionMenu == 4)
                    {
                        int acountOption = _uiService.AccountMenu();

                        if (acountOption == 1)
                        {
                            Console.WriteLine("Enter your Password:");
                            string pass = Console.ReadLine();

                            Console.WriteLine("Enter your new First Name:");
                            string firstName = Console.ReadLine();

                            bool success = _userService.ChangeFirstName(_currentUser.Id, firstName, pass);

                            continue;
                        }

                        else if (acountOption == 2)
                        {
                            Console.WriteLine("Enter your Password:");
                            string pass = Console.ReadLine();

                            Console.WriteLine("Enter your new Last Name:");
                            string lastName = Console.ReadLine();

                            bool success = _userService.ChangeLastName(_currentUser.Id, lastName, pass);

                            continue;
                        }

                        else if (acountOption == 3)
                        {
                            try
                            {
                                Console.WriteLine("Enter your old Password:");
                                string passOld = Console.ReadLine();

                                Console.WriteLine("Enter your new Password:");
                                string passNew = Console.ReadLine();

                                _userService.ChangePassword(_currentUser.Id, passOld, passNew);
                            }

                            catch (Exception ex)
                            {

                                Console.WriteLine($"{ex.Message}");
                            }

                            continue;
                        }

                        else if (acountOption == 4)
                        {
                            try
                            {
                                Console.WriteLine("Enter your Password:");
                                string pass = Console.ReadLine();

                                bool success = _userService.DeactivateAccount(_currentUser.Id, pass);

                                if (success)
                                {
                                    _currentUser = null;
                                    option = null;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                continue;
                            }

                        }

                        else if (acountOption == 5)
                        {
                            continue;
                        }
                        break;
                    }



                    else if (optionMenu == 5)
                    {
                        _currentUser = null;
                        option = null; // da se smeni
                        break;
                    }

                    break;
                }
            }
            Console.ReadLine();
        }

        public static void Seed()
        {
            _userService.Register(new User("Bob", "Bobsky", "25", "bob.bobsky", "123456A"));
            _userService.Register(new User("Anne", "Bobsky", "32", "anne.bobsky", "123456B"));
            _userService.Register(new User("Paul", "Paulsky", "28", "paul.paulsky", "123456C"));
        }

    }
}



