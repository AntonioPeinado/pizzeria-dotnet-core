using Microsoft.EntityFrameworkCore;
using API.Domain;

namespace API.Infraestructure
{
    public interface IPizzaIngredientContext : IUnitOfWork
    {
        DbSet<PizzaIngredient> PizzaIngredient { get; set; }
    }
}