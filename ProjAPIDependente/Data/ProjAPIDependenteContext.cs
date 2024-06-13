using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIDependente.Data
{
    public class ProjAPIDependenteContext : DbContext
    {
        public ProjAPIDependenteContext (DbContextOptions<ProjAPIDependenteContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Dependente> Dependente { get; set; } = default!;
    }
}
