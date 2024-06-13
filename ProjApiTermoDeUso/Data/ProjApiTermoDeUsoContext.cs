using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjApiTermoDeUso.Data
{
    public class ProjApiTermoDeUsoContext : DbContext
    {
        public ProjApiTermoDeUsoContext (DbContextOptions<ProjApiTermoDeUsoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.AceiteTermoUso> AceiteTermoUso { get; set; } = default!;
    }
}
