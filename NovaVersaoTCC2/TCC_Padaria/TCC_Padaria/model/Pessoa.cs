using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Pessoa : TPPessoa   {
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public Date dataCriacao { get; set; }
        public string nomeFantasia { get; set; }
        public string razaoSocial { get; set; }
        public string IE_RG { get; set; }
        public string CPF_CNPJ { get; set; }
        public string situacao { get; set; }
        public string telComercial { get; set; }
        public string telResidencial { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
       
    }
}
