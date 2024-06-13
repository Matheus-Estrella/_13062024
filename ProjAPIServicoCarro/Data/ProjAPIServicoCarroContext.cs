using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIServicoCarro.Data
{
    public class ProjAPIServicoCarroContext : DbContext
    {
        public ProjAPIServicoCarroContext (DbContextOptions<ProjAPIServicoCarroContext> options)
            : base(options)
        {
        }

        public DbSet<Models.CarroServico> CarroServico { get; set; } = default!;
    }
}
