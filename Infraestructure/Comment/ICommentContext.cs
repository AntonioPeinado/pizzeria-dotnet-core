using Microsoft.EntityFrameworkCore;
using API.Domain;

namespace API.Infraestructure
{
    public interface ICommentContext : IUnitOfWork
    {
        DbSet<Comment> Comment { get; set; }
    }
}