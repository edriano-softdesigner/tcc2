using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class ItemServico
    {
        public int idItemServico { get; set; }
        public int idServico { get; set; }
        public int idMovimento { get; set; }
        public int promocaoIdPromocao { get; set; }
        public int quantidade { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataAlteracao { get; set; }
        public double valorUnitario { get; set; }
        public double descontoAcrescimo { get; set; }
        public double valorTotal { get; set; }
        public int idTributacao { get; set; }
        public int idItemMovimento { get; set; }
        public int idPrestador { get; set; }
    }
}
