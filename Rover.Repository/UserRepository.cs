using Rover.Entities;
using Rover.Interfaces;
using System;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using Rover.DataAccess;

namespace Rover.Repository
{
    public sealed class UserRepository : IUserRepository
    {
        private readonly IDbConnection _connection = new ConnectionFactory().ConnectRover();

        public async Task<User> GetUserById(int userId)
            => await _connection.QueryFirstOrDefaultAsync<User>(@"
SELECT userId
    first_name
    last_name
    email
    description
FROM Apollo.Rover.Users
WHERE userId = @userId;", new {userId});
        
        public async Task DeleteUser(int userId)
            => await _connection.ExecuteAsync(@"
DELETE FROM Apollo.Rover.Users 
WHERE userId = @userId", new {userId});

    }
}
