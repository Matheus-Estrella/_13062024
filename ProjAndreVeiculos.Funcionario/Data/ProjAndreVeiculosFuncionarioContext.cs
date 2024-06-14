using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAndreVeiculos.Funcionario.Data
{
    public class ProjAndreVeiculosFuncionarioContext : DbContext
    {
        public ProjAndreVeiculosFuncionarioContext (DbContextOptions<ProjAndreVeiculosFuncionarioContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Funcionario> Funcionario { get; set; } = default!;

        public DbSet<Models.Pessoa> Pessoa { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa

            modelBuilder.Entity<Models.Funcionario>()
                .HasBaseType<Pessoa>().ToTable("Funcionario");
        }
    }
}
