using System;
using API.Domain;

namespace API.DTO
{
    public class UserRegistered
    {
        public static UserRegistered Create(User user)
        {
            var userRegistered = new UserRegistered()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
            return userRegistered;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}