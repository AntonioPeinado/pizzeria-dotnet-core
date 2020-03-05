using Microsoft.EntityFrameworkCore;
using API.Domain;

namespace API.Infraestructure
{
    public interface IIngredientContext : IUnitOfWork
    {
        DbSet<Ingredient> Ingredient { get; set; }
    }
}