using System;

namespace WebApi.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string Role { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogOutTime { get; set; }
    }
}