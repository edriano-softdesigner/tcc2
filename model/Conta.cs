using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
     public class Conta
    {
        public int idConta { get; set; }
        public string numeroBanco { get; set; }
        public string agencia { get; set; }
        public string tipo { get; set; }
        public string numeroConta { get; set; }
        public string descricao { get; set; }
    }
}
