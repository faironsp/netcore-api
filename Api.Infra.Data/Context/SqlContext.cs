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
            modelBuilder.Entity<Acquirer>(new AcquirerMap().Configure);
            modelBuilder.Entity<AcquirerTax>(new AcquirerTaxMap().Configure);
            modelBuilder.Entity<Bank>(new BankMap().Configure);
            modelBuilder.Entity<BankingDomicile>(new BankingDomicileMap().Configure);
            modelBuilder.Entity<Charge>(new ChargeMap().Configure);
            modelBuilder.Entity<Customer>(new CustomerMap().Configure);
            modelBuilder.Entity<CustomerHistory>(new CustomerHistoryMap().Configure);
            modelBuilder.Entity<Equipment>(new EquipmentMap().Configure);
            modelBuilder.Entity<Flag>(new FlagMap().Configure);
            modelBuilder.Entity<Manufacturer>(new ManufacturerMap().Configure);
            modelBuilder.Entity<Plan>(new PlanMap().Configure);
            modelBuilder.Entity<Transaction>(new TransactionMap().Configure);
            modelBuilder.Entity<TransactionInstallment>(new TransactionInstallmentMap().Configure);
        }
    }
}
