using Microsoft.EntityFrameworkCore;
using API.Domain;

namespace API.Infraestructure
{
    public interface IUserContext : IUnitOfWork
    {
        DbSet<User> User { get; set; }
    }
}