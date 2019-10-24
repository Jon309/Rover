using System;

namespace Rover.Entities
{
    public sealed class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        
        //Add more data to database eventually
    }
}