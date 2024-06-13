using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICondutor.Data
{
    public class ProjAPICondutorContext : DbContext
    {
        public ProjAPICondutorContext (DbContextOptions<ProjAPICondutorContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Condutor> Condutor { get; set; } = default!;
        public DbSet<Models.CNH> CNH { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.Documento);

            modelBuilder.Entity<Condutor>().ToTable("Condutor");
            modelBuilder.Entity<CNH>().ToTable("CNH");
        }

    }
}
