using System;

namespace SEDC.TimeTracking.Services.Helpers
{
    public static class ValidationHelper
    {

        public static bool ValidateUserName(string userName)
        {
            if (userName.Length < 5)
                return false;
            return true;
        }


        public static bool ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            bool isNum = false;
            foreach (char ch in password)
            {
                isNum = int.TryParse(ch.ToString(), out int num);
                if (isNum)
                    break;
            }
            if (!isNum)
                return false;

            bool isCapital = false;
            foreach (char ch in password)
            {
                if (Char.IsUpper(ch))
                {
                    isCapital = true;
                    break;
                }
            }
            if (!isCapital)
                return false;

            return true;
        }

        public static bool ValidateFirstName(string firstName)
        {
            if (firstName.Length < 2)
                return false;

            foreach (char ch in firstName)
            {
                if (Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateLastName(string lastName)
        {
            if (lastName.Length < 2)
                return false;

            foreach (char ch in lastName)
            {
                if (Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateAge(string ageString)
        {
            bool ageS = int.TryParse(ageString, out int age);
            if(!ageS)
            {
                return false;
            }

            if (age < 18 || age > 120)
                return false;
            return true;
        }

        public static int ValidateNumber(string numberInput, int range)
        {
            bool isNumber = int.TryParse(numberInput, out int number);
            if (!isNumber)
                return -1;
            if (number < 1 || number > range)
                return -1;
            return number;
        }

    }
}
