using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using SeguroVeiculos.Domain.Models;

namespace SeguroVeiculos.Persistence.DbContext
{

    public class SeguroVeiculosDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Segurado> Segurados { get; set; }

        public SeguroVeiculosDbContext(DbContextOptions<SeguroVeiculosDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações de mapeamento aqui
        }
    }

}
