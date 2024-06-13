using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICarro.Pix.Data
{
    public class ProjAPICarroPixContext : DbContext
    {
        public ProjAPICarroPixContext (DbContextOptions<ProjAPICarroPixContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Pix> Pix { get; set; } = default!;
    }
}
