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

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnName("Nome");

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasColumnName("Sobrenome");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnName("Email");

            builder.Property(c => c.Birthdate)
                .IsRequired()
                .HasColumnName("DataNascimento");

            builder.Property(c => c.Schooling)
                .IsRequired()
                .HasColumnName("Escolaridade");
        }
    }
}
