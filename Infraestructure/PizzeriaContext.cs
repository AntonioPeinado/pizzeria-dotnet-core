using Microsoft.EntityFrameworkCore;
using System;
using API.Domain;

namespace API.Infraestructure
{
    public class PizzeriaContext : DbContext, IUserContext
    {
        public DbSet<User> User { get; set; }

        public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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