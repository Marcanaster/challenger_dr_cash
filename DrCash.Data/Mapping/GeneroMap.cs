using DrCash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrCash.Data.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<GeneroEntity>
    {
        public void Configure(EntityTypeBuilder<GeneroEntity> builder)
        {
            builder.ToTable("Genero");
            builder.HasKey(p => p.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(500);
        }
    }
}
