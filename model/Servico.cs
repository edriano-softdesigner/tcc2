using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Servico
    {
        public int idServico { get; set; }
        public int idGrupo { get; set; }
        public int idSubGrupo { get; set; }
        public int idGrupoTributario { get; set; }
        public string descricao { get; set; }
        public string situacao { get; set; }
        public decimal valorServico { get; set; }
    }
}
