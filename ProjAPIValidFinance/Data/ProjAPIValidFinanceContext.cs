using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIValidFinance.Data
{
    public class ProjAPIValidFinanceContext : DbContext
    {
        public ProjAPIValidFinanceContext (DbContextOptions<ProjAPIValidFinanceContext> options)
            : base(options)
        {
        }

        public DbSet<Models.PendenciaFinanceira> PendenciaFinanceira { get; set; } = default!;
    }
}
