using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PendenciaFinanceira
    {
        [Key]
        public int Id { get; set; }
        string Descricao { get; set; }
        DateTime DataPendencia { get; set; }
        DateTime DataCobranca   { get; set; }
        bool Status { get; set; }
        Cliente Cliente { get; set; }
    }
}
