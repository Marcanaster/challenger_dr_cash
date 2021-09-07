using DrCash.Data.Mapping;
using DrCash.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrCash.Data.Context
{
    public class DrCashContext : DbContext
    {
        public DbSet<AutorEntity> Autores { get; set; }
        public DbSet<LivroEntity> Livros { get; set; }
        public DbSet<GeneroEntity> Generos { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public DrCashContext(DbContextOptions<DrCashContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<AutorEntity>(new AutorMap().Configure);
            modelbuilder.Entity<LivroEntity>(new LivroMap().Configure);
            modelbuilder.Entity<GeneroEntity>(new GeneroMap().Configure);
            modelbuilder.Entity<UserEntity>(new UserMap().Configure);

            modelbuilder.Entity<AutorLivroEntity>().HasKey(sc => new { sc.AutorId, sc.LivroId });

            modelbuilder.Entity<AutorLivroEntity>()
                .HasOne<LivroEntity>(sc => sc.Livro)
                .WithMany(s => s.AutoresLivros)
                .HasForeignKey(sc => sc.LivroId);


            modelbuilder.Entity<AutorLivroEntity>()
                .HasOne<AutorEntity>(sc => sc.Autor)
                .WithMany(s => s.AutoresLivros)
                .HasForeignKey(sc => sc.AutorId);

        }
    }
}
