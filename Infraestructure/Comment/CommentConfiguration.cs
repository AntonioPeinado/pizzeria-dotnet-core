using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Infraestructure
{
    public class CommentConfiguration
    {
        public static void Apply(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Comment>(comment =>
                {

                    comment.HasKey(c => c.Id);

                    comment
                        .HasOne<User>(c => c.User)
                        .WithMany();
                });
        }
    }
}