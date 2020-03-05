using API.DTO;
using API.Domain;
using System;

namespace API.Application
{
    public interface IUserService
    {
        UserDetailDTO Register(UserRegistrationDTO userRegistration);
        User FindById(Guid id);
    }
}