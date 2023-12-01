using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
     public class Financeiro
    {
        public int idFinanceiro { get; set; }
        public int idMovimentoParcelas { get; set; }
        public int idTPFinanceiro { get; set; }
        public int idPlanoDeContas { get; set; }
        public int idTPPagamento { get; set; }
        public int idEmpresa { get; set; }
        public int idPessoa { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtAlteracao { get; set; }
        public DateTime dtPagamento { get; set; }
        public DateTime dtVencimento { get; set; }
        public double valor { get; set; }
        public double valorPago { get; set; }
        public string desc_acresc { get; set; }
        public int nrParcela { get; set; }
        public string observaco { get; set; }
    }
}
