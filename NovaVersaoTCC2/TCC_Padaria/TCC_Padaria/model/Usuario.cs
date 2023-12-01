using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public int situacao { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int idGrupoUsuario { get; set; }
    }
}
