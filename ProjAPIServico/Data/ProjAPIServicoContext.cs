using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIServico.Data
{
    public class ProjAPIServicoContext : DbContext
    {
        public ProjAPIServicoContext (DbContextOptions<ProjAPIServicoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Servico> Servico { get; set; } = default!;
    }
}
