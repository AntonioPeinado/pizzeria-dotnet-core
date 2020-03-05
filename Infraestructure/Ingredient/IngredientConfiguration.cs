using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Infraestructure
{
    public class IngredientConfiguration
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ingredient>(ingredient =>
                {
                    ingredient.HasKey(i => i.Id);
                });
        }
    }
}