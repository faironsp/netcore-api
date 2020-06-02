using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.name)
                .IsRequired()
                .HasColumnName("Nome");

            builder.Property(c => c.lastname)
                .IsRequired()
                .HasColumnName("Sobrenome");

            builder.Property(c => c.email)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property(c => c.birthdate)
                .IsRequired()
                .HasColumnName("DataNascimento");

            builder.Property(c => c.schooling)
                .IsRequired()
                .HasColumnName("Escolaridade");
        }
    }
}
