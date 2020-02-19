using API.DTO;

namespace API.Application
{
    public interface IUserService
    {
        UserRegistered Register(UserRegistration userRegistration);
    }
}