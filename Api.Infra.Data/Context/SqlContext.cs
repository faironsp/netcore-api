using Api.Domain.Entities;
using Api.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Api.Infra.Data.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=mssql.fairon.com.br;Database=_dev;User Id=dev;Password=340$Uuxwp7Mcxo7Khy;Integrated Security=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
