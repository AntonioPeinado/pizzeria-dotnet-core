using System;
using API.Domain;
using API.DTO;

namespace API.Application
{
    public interface IUserMapper
    {
        User ToUser(UserRegistrationDTO dto);
        UserDetailDTO ToUserDetail(User user);
    }
}