using DrCash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrCash.Data.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<LivroEntity>
    {
        public void Configure(EntityTypeBuilder<LivroEntity> builder)
        {
            builder.ToTable("Livro");
            builder.HasKey(p => p.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.QuantidadeCopias);
        }
    }
}
