using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIVenda.Data
{
    public class ProjAPIVendaContext : DbContext
    {
        public ProjAPIVendaContext (DbContextOptions<ProjAPIVendaContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Venda> Venda { get; set; } = default!;
    }
}
