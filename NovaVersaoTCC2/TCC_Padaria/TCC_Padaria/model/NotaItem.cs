using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class NotaItem
    {
        public int idNotaItem { get; set; }
        public int idProdutoGrade { get; set; }
        public int idNota { get; set; }
        public string quantidade { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal { get; set; }
    }
}
