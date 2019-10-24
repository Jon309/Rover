using System.Threading.Tasks;
using Rover.Entities;
using Rover.Interfaces;
using Rover.ServiceInterfaces;

namespace Rover.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public Task<User> GetUserById(int userId)
        {
            await _userRepository.GetUserById(userId);
        }

        public async Task RemoveUser(int userId)
        {
            await _userRepository.DeleteUser(userId);
        }

    }
}