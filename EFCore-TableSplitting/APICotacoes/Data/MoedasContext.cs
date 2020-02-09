using Microsoft.EntityFrameworkCore;
using APICotacoes.Models;

namespace APICotacoes.Data
{
    public class MoedasContext : DbContext
    {
        public DbSet<Cotacao> Cotacoes { get; set; }

        public MoedasContext(DbContextOptions<MoedasContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cotacao>()
                .HasKey(c => c.Sigla);

            // Owned entity/Table Splitting com a mesma tabela
            modelBuilder.Entity<Cotacao>()
                .OwnsOne(c => c.Valor);
        }
    }
}