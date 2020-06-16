using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Data.Mapping
{
    public class AcquirerTaxMap : IEntityTypeConfiguration<AcquirerTax>
    {
        public void Configure(EntityTypeBuilder<AcquirerTax> builder)
        {
            builder.ToTable("AcquirerTax");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.IdFlag).IsRequired().HasColumnName("IdFlag");
            builder.Property(c => c.DebitTax).IsRequired().HasColumnName("DebitTax");
            builder.Property(c => c.CreditTax1x1x).IsRequired().HasColumnName("CreditTax1x1x");
            builder.Property(c => c.CreditTax2x6x).IsRequired().HasColumnName("CreditTax2x6x");
            builder.Property(c => c.CreditTax7x12).IsRequired().HasColumnName("CreditTax7x12");
        }
    }
}
