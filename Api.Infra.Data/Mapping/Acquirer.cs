using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Data.Mapping
{
    public class AcquirerMap : IEntityTypeConfiguration<Acquirer>
    {
        public void Configure(EntityTypeBuilder<Acquirer> builder)
        {
            builder.ToTable("Acquirer");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("Nome");
        }
    }
}
