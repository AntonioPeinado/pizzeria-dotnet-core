using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Infraestructure
{
    public class UserConfiguration
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasKey(user => user.Id);
        }
    }
}