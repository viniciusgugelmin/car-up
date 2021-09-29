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
    }
}