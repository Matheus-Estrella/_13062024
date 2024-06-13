using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICompra.Data
{
    public class ProjAPICompraContext : DbContext
    {
        public ProjAPICompraContext (DbContextOptions<ProjAPICompraContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Compra> Compra { get; set; } = default!;
    }
}
