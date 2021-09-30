using Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Back.Data
{
    public class DataContext : DbContext
    {
        /// Database options
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        {
        }

        /// Tables

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Modelo> Modelos { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        /// Relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Marca 1n Modelo
            modelBuilder.Entity<Modelo>()
            .HasOne(modelo => modelo.Marca)
            .WithMany(marca => marca.Modelo)
            .HasForeignKey(modelo => modelo.MarcaId)
            .IsRequired();

            modelBuilder.Entity<Marca>()
            .HasMany(marca => marca.Modelo)
            .WithOne(modelo => modelo.Marca)
            .OnDelete(DeleteBehavior.Cascade);

            // Modelo 1n Veículo

            modelBuilder.Entity<Veiculo>()
            .HasOne(veiculo => veiculo.Modelo)
            .WithMany(modelo => modelo.Veiculo)
            .HasForeignKey(veiculo => veiculo.ModeloId)
            .IsRequired();

            modelBuilder.Entity<Modelo>()
            .HasMany(modelo => modelo.Veiculo)
            .WithOne(veiculo => veiculo.Modelo)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}