using DrCash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrCash.Data.Mapping
{
    public class AutorMap : IEntityTypeConfiguration<AutorEntity>
    {
        public void Configure(EntityTypeBuilder<AutorEntity> builder)
        {
            builder.ToTable("Autor");
            builder.HasKey(p => p.Id);
            builder.OwnsOne(c => c.Nome, nome =>
            {
                nome.Property(c => c.PrimeiroNome).IsRequired().HasMaxLength(100);
                nome.Property(c => c.Sobrenome).IsRequired().HasMaxLength(100);
            });
        }
    }
}
