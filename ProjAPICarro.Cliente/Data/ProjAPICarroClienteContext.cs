using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICarro.Cliente.Data
{
    public class ProjAPICarroClienteContext : DbContext
    {
        public ProjAPICarroClienteContext (DbContextOptions<ProjAPICarroClienteContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Cliente> Cliente { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa

            modelBuilder.Entity<Models.Cliente>()
                .HasBaseType<Pessoa>().ToTable("Cliente");
        }
    }
}
