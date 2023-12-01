using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Movimento
    {
        public int idMovimento { get; set; }
        public int idEmpresa { get; set; }
        public int idPessoa { get; set; }
        public int idTPMovimento { get; set; }
        public int idOperacao { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int entregar_S_N { get; set; }
        public DateTime dataBaixa { get; set; }
        public double descontoAcrescimo { get; set; }
        public string situacao { get; set; }
        public int idOperacaoFiscal { get; set; }
    }
}
