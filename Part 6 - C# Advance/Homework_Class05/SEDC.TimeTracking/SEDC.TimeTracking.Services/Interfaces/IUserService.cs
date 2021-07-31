using SEDC.TimeTracking.Domain.Models;

namespace SEDC.TimeTracking.Services.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        void DeleteUser(User user);
        User FirstOrDefaultUser(string username);
        User FirstOrDefaultPassword(string password);

    }
} 
