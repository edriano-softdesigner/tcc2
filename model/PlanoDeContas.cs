using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class PlanoDeContas
    {
        public int idPlanoDeContas { get; set; }
        public string classificacao { get; set; }
        public string descricao { get; set; }
        public string tipo { get; set; }
        public int idPlanoDeContasPai { get; set; }
        public int idConta { get; set; }
    }
}
