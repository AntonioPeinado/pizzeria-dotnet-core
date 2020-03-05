using System;
using API.Domain;
using API.DTO;

namespace API.Application
{
    public class UserMapper : IUserMapper
    {
        public User ToUser(UserRegistrationDTO dto)
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password
            };
        }
        public UserDetailDTO ToUserDetail(User user)
        {
            return new UserDetailDTO()
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name
            };
        }
    }
}