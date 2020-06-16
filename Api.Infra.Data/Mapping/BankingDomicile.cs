using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Data.Mapping
{
    public class BankingDomicileMap : IEntityTypeConfiguration<BankingDomicile>
    {
        public void Configure(EntityTypeBuilder<BankingDomicile> builder)
        {
            builder.ToTable("BankingDomicile");

            builder.HasKey(c => c.Id);
        }
    }
}
