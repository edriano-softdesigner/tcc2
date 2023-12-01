using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class Promocao
    {
        public int idPromocao { get; set; }
        public int idProdutoGrade { get; set; }
        public double porcentagemMinima { get; set; }
        public double porcentagemMaxima { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public string descricao { get; set; }
    }
}
