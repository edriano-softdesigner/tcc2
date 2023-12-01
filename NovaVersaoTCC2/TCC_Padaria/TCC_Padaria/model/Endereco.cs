using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
     public class Endereco
    {
        public int idEndereco { get; set; }
        public int idPessoa { get; set; }
        public int idTPendereco { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string enderecoPadrao { get; set; }
    }
}
