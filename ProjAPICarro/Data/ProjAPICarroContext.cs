using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICarro.Data
{
    public class ProjAPICarroContext : DbContext
    {
        public ProjAPICarroContext (DbContextOptions<ProjAPICarroContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Carro> Carro { get; set; } = default!;
        public DbSet<Models.Pessoa>? Pessoas { get; set; } = default!;
        public DbSet<Models.Cliente>? Cliente { get; set; } = default!;
        public DbSet<Models.Funcionario>? Funcionario { get; set; } = default!;
        public DbSet<Models.Boleto>? Boleto { get; set; } = default!;
        public DbSet<Models.Cargo>? Cargo { get; set; } = default!;
        public DbSet<Models.CarroServico>? CarroServico { get; set; } = default!;
        public DbSet<Models.Cartao>? Cartao { get; set; } = default!;
        public DbSet<Models.Compra>? Compra { get; set; } = default!;
        public DbSet<Models.Endereco>? Endereco { get; set; } = default!;
        public DbSet<Models.Pagamento>? Pagamento { get; set; } = default!;
        public DbSet<Models.Pix>? Pix { get; set; } = default!;
        public DbSet<Models.Servico>? Servico { get; set; } = default!;
        public DbSet<Models.TipoPix>? TipoPix { get; set; } = default!;
        public DbSet<Models.Venda>? Venda { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.Documento);

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");

            modelBuilder.Entity<Carro>().ToTable("Carro");
            modelBuilder.Entity<Boleto>().ToTable("Boleto");
            modelBuilder.Entity<Cargo>().ToTable("Cargo");
            modelBuilder.Entity<CarroServico>().ToTable("CarroServico");
            modelBuilder.Entity<Cartao>().ToTable("Cartao");
            modelBuilder.Entity<Compra>().ToTable("Compra");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Pagamento>().ToTable("Pagamento");
            modelBuilder.Entity<Pix>().ToTable("Pix");
            modelBuilder.Entity<Servico>().ToTable("Servico");
            modelBuilder.Entity<TipoPix>().ToTable("TipoPix");
            modelBuilder.Entity<Venda>().ToTable("Venda");

        }



    }
}
