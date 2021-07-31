using SEDC.TimeTracking.Domain.Database;
using SEDC.TimeTracking.Domain.Models;
using SEDC.TimeTracking.Services.Interfaces;
using SEDC.TimeTracking.Services.Helpers;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SEDC.TimeTracking.Services.Implementations
{
    public class UserService : IUserService
    {
        private IDatabase<User> _databaseUser;

        public UserService()
        {
            _databaseUser = new FileDatabase<User>();

        }

        public void AddUser(User user)
        {
            _databaseUser.Insert(user);
        }

        public void DeleteUser(User user)
        {
            _databaseUser.RemoveById(user.Id);
        }

        public User FirstOrDefaultUser(string username)
        {
            User user = _databaseUser.GetAll().FirstOrDefault(x => x.UserName == username);
            return user;
        }
        public User FirstOrDefaultPassword(string password)
        {
            User user = _databaseUser.GetAll().FirstOrDefault(x => x.Password == HashingPassword(password));
            return user;
        }

        public User LogIn(string username, string password)
        {
            User tempUser = _databaseUser.GetAll().FirstOrDefault(x => x.UserName == username
            && x.Password == HashingPassword(password));


            if(tempUser == null)
            {
                MessageHelper.PrintMessage($"[Error] User with username {username} does not exist.", ConsoleColor.Red);
                return null;
            }

            return tempUser;
        }


        public User Register(User userModel)
        {
            if (!ValidationHelper.ValidateFirstName(userModel.FirstName) 
                || !ValidationHelper.ValidateLastName(userModel.LastName)
                || !ValidationHelper.ValidateAge(userModel.Age)
                || !ValidationHelper.ValidateUserName(userModel.UserName)
                || !ValidationHelper.ValidatePassword(userModel.Password))
            {
                MessageHelper.PrintMessage("[Error] User data is invalid", ConsoleColor.Red);
                return null;
            }
            string hashedPass = HashingPassword(userModel.Password);
            userModel.Password = hashedPass;
            int id = _databaseUser.Insert(userModel);
            return _databaseUser.GetbyId(id);
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            User userDb = _databaseUser.GetbyId(userId);

            if (userDb.Password != HashingPassword(oldPassword))
            {
                throw new Exception("Old passwords do not match");
            }
            if (!ValidationHelper.ValidatePassword(newPassword))
            {
                throw new Exception("Invalid password");
            }
            userDb.Password = HashingPassword(newPassword);
            //send the object with the new values to the Update method of the database
            _databaseUser.Update(userDb);
            MessageHelper.PrintMessage($"Password of User with id {userId} was successfully updated", ConsoleColor.Green);
        }


        public bool ChangeFirstName(int userId, string firstName, string pass)
        {
            User userDb = _databaseUser.GetbyId(userId);
            if (userDb.Password != HashingPassword(pass))
            {
                throw new Exception("Invalid password");
            }

            if (!ValidationHelper.ValidateFirstName(firstName))
            {
                MessageHelper.PrintMessage("[Error] Invalid user data", ConsoleColor.Red);
                return false;
            }
            userDb.FirstName = firstName;
            _databaseUser.Update(userDb);
            MessageHelper.PrintMessage($"User with id {userId} was successfully updated", ConsoleColor.Green);
            return true;
        }

        public bool ChangeLastName(int userId, string lastName, string pass)
        {
            User userDb = _databaseUser.GetbyId(userId);
            if (userDb.Password != HashingPassword(pass))
            {
                throw new Exception("Invalid password");
            }

            if (!ValidationHelper.ValidateLastName(lastName))
            {
                MessageHelper.PrintMessage("[Error] Invalid user data", ConsoleColor.Red);
                return false;
            }
            userDb.LastName = lastName;
            _databaseUser.Update(userDb);
            MessageHelper.PrintMessage($"User with id {userId} was successfully updated", ConsoleColor.Green);
            return true;
        }

         
        public bool DeactivateAccount(int userId, string pass)
        {
            User userDb = _databaseUser.GetbyId(userId);
            if (userDb.Password != HashingPassword(pass))
            {
                throw new Exception("The passwords do not match");
            }

            userDb.Active = false;
            _databaseUser.Update(userDb);
            MessageHelper.PrintMessage($"Your account was successfully deactivated", ConsoleColor.Yellow);
            return true;
        }


        public bool ActivateAccount(int userId)
        {
            User userDb = _databaseUser.GetbyId(userId);

            userDb.Active = true;
            _databaseUser.Update(userDb);
            MessageHelper.PrintMessage($"Your account was successfully activated", ConsoleColor.Green);
            return true;
        }

        public static string HashingPassword(string pass)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(pass);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash;
            }
        }

    }
}
