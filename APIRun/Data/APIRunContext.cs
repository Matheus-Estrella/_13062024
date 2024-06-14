using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace APIRun.Data
{
    public class APIRunContext : DbContext
    {
        public APIRunContext (DbContextOptions<APIRunContext> options)
            : base(options)
        {

        }

        public DbSet<Models.TipoPix> TipoPix { get; set; } = default!;
        public DbSet<Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<Models.CNH> CNH { get; set; } = default!;
        public DbSet<Models.PendenciaFinanceira> PendenciaFinanceira { get; set; } = default!;
        public DbSet<Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Models.Condutor> Condutor { get; set; } = default!;
        public DbSet<Models.Pagamento> Pagamento { get; set; } = default!;
        public DbSet<Models.Pix> Pix { get; set; } = default!;
        public DbSet<Models.Cartao> Cartao { get; set; } = default!;
        public DbSet<Models.Boleto> Boleto { get; set; } = default!;
        public DbSet<Models.Compra> Compra { get; set; } = default!;
        public DbSet<Models.Carro> Carro { get; set; } = default!;
        public DbSet<Models.CarroServico> CarroServico { get; set; } = default!;
        public DbSet<Models.Servico> Servico { get; set; } = default!;
        public DbSet<Models.Endereco> Endereco { get; set; } = default!;
        public DbSet<Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<Models.Cargo> Cargo { get; set; } = default!;
        public DbSet<Models.Venda> Venda { get; set; } = default!;
        public DbSet<Models.Pessoa> Pessoa { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa

            modelBuilder.Entity<Models.Funcionario>()
                .HasBaseType<Pessoa>().ToTable("Funcionario");

            modelBuilder.Entity<Models.Cliente>()
                .HasBaseType<Pessoa>().ToTable("Cliente");

            modelBuilder.Entity<Models.Condutor>()
                .HasBaseType<Pessoa>().ToTable("Condutor");


        }

    }
}
