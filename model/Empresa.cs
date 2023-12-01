using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
     public class Empresa
    {
        public int idEmpresa { get; set; }
        public DateTime dataDecriacao { get; set; }
        public int CTR { get; set; }
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public int CNPJ { get; set; }
        public int inscricaoEstadual { get; set; }
        public int inscricaoMunicipal { get; set; }
        public int CEP { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
    }
}
