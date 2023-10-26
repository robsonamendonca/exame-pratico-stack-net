using Microsoft.EntityFrameworkCore;
using SeguroVeiculos.Domain.Models;

namespace Mysql.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Segurado> Segurados { get; set; }

        public DbSet<SeguroVeiculo> SeguroVeiculos {  get; set; }

    }
}