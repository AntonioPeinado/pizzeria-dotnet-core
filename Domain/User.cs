using System;
using API.DTO;
namespace API.Domain
{
    public class User
    {
        public static User Create(UserRegistration userRegistration)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = userRegistration.Name,
                Email = userRegistration.Email,
                Password = userRegistration.Password
            };
            return user;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}