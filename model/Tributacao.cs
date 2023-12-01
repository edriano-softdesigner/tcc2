using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Tributacao
    {
        public int idTributacao { get; set; }
        public int idOperacaoFiscal { get; set; }
        public int idGrupoTributario { get; set; }
        public string icms { get; set; }
        public string cfop { get; set; }
        public string csosn { get; set; }
        public string csticms { get; set; }
        public string icmsst { get; set; }
    }
}
