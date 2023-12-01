using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Padaria.model
{
    public class ProdutoGrade
    {
        public int idProdutoGrade { get; set; }
        public int idProduto { get; set; }
        public int idGradeY { get; set; }
        public int idGradeX { get; set; }
        public string saldo { get; set; }
        public int codigoDeBarras { get; set; }
        public double pesoBruto { get; set; }
        public double pesoLiquido { get; set; }
        public double valorDeVenda { get; set; }
        public double custoMedio { get; set; }
        public double custoAtual { get; set; }
        public double estoqueMinimo { get; set; }
        public double estoqueMaximo { get; set; }
        public string situacao { get; set; }
    }
}
