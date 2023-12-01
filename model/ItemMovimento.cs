using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class ItemMovimento
    {
        public int idItemMovimento { get; set; }
        public int idProdutoGrade { get; set; }
        public int idLocalizacao { get; set; }
        public int idMovimento { get; set; }
        public int promocaoIdPromocao { get; set; }
        public string quantidade { get; set; }
        public string saldoEstoque { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataAlteracao { get; set; }
        public double valorUnitario { get; set; }
        public double descontoAcrescimo { get; set; }
        public double valorTotal { get; set; }
        public int idTributacao { get; set; }
    }
}
