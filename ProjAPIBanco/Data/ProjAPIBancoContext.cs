using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIBanco.Data
{
    public class ProjAPIBancoContext : DbContext
    {
        public ProjAPIBancoContext (DbContextOptions<ProjAPIBancoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Banco> Banco { get; set; } = default!;
    }
}
