using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPISeguro.Data
{
    public class ProjAPISeguroContext : DbContext
    {
        public ProjAPISeguroContext (DbContextOptions<ProjAPISeguroContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Seguro> Seguro { get; set; } = default!;
    }
}
