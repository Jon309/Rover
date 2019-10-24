using System.Threading.Tasks;
using Rover.Entities;

namespace Rover.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(int userId);
        Task DeleteUser(int userId);

        //Fill with whatever tasks you want, specific or not specific

    }
}