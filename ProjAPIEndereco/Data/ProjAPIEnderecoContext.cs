using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPIEndereco.Data
{
    public class ProjAPIEnderecoContext : DbContext
    {
        public ProjAPIEnderecoContext (DbContextOptions<ProjAPIEnderecoContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Endereco> Endereco { get; set; } = default!;
    }
}
