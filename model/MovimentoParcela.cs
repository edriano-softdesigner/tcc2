using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class MovimentoParcela
    {
        public int idMovimentoParcelas { get; set; }
        public int idTPPagamento { get; set; }
        public int idMovimento { get; set; }
        public DateTime dataVencimento { get; set; }
        public double valor { get; set; }
    }
}
