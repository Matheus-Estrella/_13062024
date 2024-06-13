using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TermodeUso
    {
        public int id { get; set; }
        public string texto { get; set; }
        public int versao { get; set; }
        public DateTime dataCadastro { get; set; }
        public bool status { get; set; }
    }
}
