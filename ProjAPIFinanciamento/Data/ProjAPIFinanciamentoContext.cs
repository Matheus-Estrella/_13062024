using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIFinanciamento.Data
{
    public class ProjAPIFinanciamentoContext : DbContext
    {
        public ProjAPIFinanciamentoContext (DbContextOptions<ProjAPIFinanciamentoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Financiamento> Financiamento { get; set; } = default!;
    }
}
