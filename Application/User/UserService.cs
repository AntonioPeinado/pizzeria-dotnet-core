using API.DTO;
using API.Domain;
using API.Infraestructure;
using System;

namespace API.Application
{
    public class UserService : BaseService, IUserService
    {
        private readonly PizzeriaContext _context;

        private readonly IUserMapper _userMapper;
        public UserService(PizzeriaContext context, IUserMapper userMapper) : base(context)
        {
            _context = context;
            _userMapper = userMapper;
        }

        public User FindById(Guid id)
        {
            return this._context.User.Find(id);
        }

        public UserDetailDTO Register(UserRegistrationDTO userRegistration)
        {
            var user = _userMapper.ToUser(userRegistration);
            _context.User.Add(user);
            _context.SaveChanges();
            return _userMapper.ToUserDetail(user);
        }
    }
}