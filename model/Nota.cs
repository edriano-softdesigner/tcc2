using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Nota
    {
        public int idNota { get; set; }
        public string NRNota { get; set; }
        public int idMovimento { get; set; }
        public DateTime dataEmissao { get; set; }
        public string situacao { get; set; }
    }
}
