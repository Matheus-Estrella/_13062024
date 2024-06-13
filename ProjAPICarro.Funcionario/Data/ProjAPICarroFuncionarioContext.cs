using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICarro.Funcionario.Data
{
    public class ProjAPICarroFuncionarioContext : DbContext
    {
        public ProjAPICarroFuncionarioContext (DbContextOptions<ProjAPICarroFuncionarioContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
