using Microsoft.EntityFrameworkCore;
using System;
using API.Domain;

namespace API.Infraestructure
{
    public class PizzeriaContext : DbContext, ICommentContext, IIngredientContext, IPizzaContext, IPizzaIngredientContext, IUserContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredient { get; set; }


        public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CommentConfiguration.Apply(modelBuilder);
            IngredientConfiguration.Apply(modelBuilder);
            PizzaConfiguration.Apply(modelBuilder);
            PizzaIngredientConfiguration.Apply(modelBuilder);
            UserConfiguration.Apply(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                // TODO: throw custom exception
                throw ex;
            }
        }
    }
}