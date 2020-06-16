using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Data.Mapping
{
    public class TransactionInstallmentMap : IEntityTypeConfiguration<TransactionInstallment>
    {
        public void Configure(EntityTypeBuilder<TransactionInstallment> builder)
        {
            builder.ToTable("TransactionInstallment");

            builder.HasKey(c => c.Id);
        }
    }
}
