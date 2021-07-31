
using System.Collections.Generic;

namespace SEDC.TimeTracking.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }


        public User(string firstName, string lastName, string age, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            Active = true;
        }

        public override string GetInfo()
        {
            return $"FirstName: {FirstName} \nLastName: {LastName} \nAge: {Age}\nUserName: {UserName}\nPassword: {Password}";
        }
    }
}
