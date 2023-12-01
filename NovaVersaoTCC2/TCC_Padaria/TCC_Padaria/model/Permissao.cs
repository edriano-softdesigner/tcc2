using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Permissao
    {
        public int idPermissao { get; set; }
        public int idUsuario { get; set; }
        public int idGrupo { get; set; }
        public int idTela { get; set; }
        public int ALTERACAO { get; set; }
        public int INCLUSAO { get; set; }
        public int EXCLUSAO { get; set; }
        public int CONSULTA { get; set; }
    }
}
