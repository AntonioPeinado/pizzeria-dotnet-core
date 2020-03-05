using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Infraestructure
{
    public class PizzaConfiguration
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Pizza>(pizza =>
                {
                    pizza.HasKey(p => p.Id);

                    pizza
                        .HasMany<Comment>(p => p.Comments)
                        .WithOne();

                    pizza.Ignore(p => p.Price);
                });
        }
    }
}