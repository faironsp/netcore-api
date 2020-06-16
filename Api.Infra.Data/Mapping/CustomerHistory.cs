using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Data.Mapping
{
    public class CustomerHistoryMap : IEntityTypeConfiguration<CustomerHistory>
    {
        public void Configure(EntityTypeBuilder<CustomerHistory> builder)
        {
            builder.ToTable("CustomerHistory");

            builder.HasKey(c => c.Id);
        }
    }
}
