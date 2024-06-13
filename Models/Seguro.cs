using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Seguro
    {
        public int Id  { get; set; }
        Cliente Cliente { get; set; }
        decimal Franquia { get; set; }
        Carro Carro { get; set; }
        Condutor CondutorPrincipal { get; set; }
    }
}
