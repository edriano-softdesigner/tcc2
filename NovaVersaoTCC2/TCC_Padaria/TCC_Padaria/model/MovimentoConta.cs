using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class MovimentoConta
    {
        public int idMovimentoConta { get; set; }
        public string dataCadastro { get; set; }
        public string dataBaixa { get; set; }
        public string tipo { get; set; }
        public string valor { get; set; }
        public DateTime dataConciliacao { get; set; }
        public string conciliado { get; set; }
        public int idConta { get; set; }
    }
}
