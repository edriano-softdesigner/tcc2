using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Operacao
    {
        public int idOperacao { get; set; }
        public string descricao { get; set; }
        public double entradaSaida { get; set; }
        public int idPlanoDeContas { get; set; }
        public int idTPFinanceiro { get; set; }
        public int idMovimento { get; set; }
    }
}
