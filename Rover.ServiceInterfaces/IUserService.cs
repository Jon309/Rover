using System;
using System.Threading.Tasks;
using Rover.Entities;

namespace Rover.ServiceInterfaces
{
    public interface IUserService
    {
        //Task InsertUser(User user);
        Task RemoveUser(int userId);
        Task<User> GetUserById(int userId);
    }
}