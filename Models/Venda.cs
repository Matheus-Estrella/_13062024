using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }
        public DateTime DataVenda { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public Decimal ValorVenda { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Pagamento Pagamento { get; set; }

    }
}
