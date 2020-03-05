using Microsoft.EntityFrameworkCore;
using API.Domain;

namespace API.Infraestructure
{
    public interface IPizzaContext : IUnitOfWork
    {
        DbSet<Pizza> Pizza { get; set; }
    }
}