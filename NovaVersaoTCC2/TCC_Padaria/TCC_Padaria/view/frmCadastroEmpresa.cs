using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_Padaria.model;

namespace TCC_Padaria.view
{
    public partial class frmCadastroEmpresa : Form
    {
        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 passo - Armazenar os dados em um objeto model
            Empresa obj = new Empresa();
            obj.dataDecriacao = dtDcEmpresa.Value;
            obj.CTR = int.Parse(txtCRT.Text);
            obj.nomeFantasia = txtNomeFantasia.Text;
            obj.razaoSocial = txtRazaoSocial.Text;
            obj.CNPJ = int.Parse(txtCNPJ.Text);
            obj.inscricaoEstadual = int.Parse(txtInscricaoEstadual.Text);
            obj.inscricaoMunicipal = int.Parse(txtInscricaoMunicipal.Text);
            obj.CEP = int.Parse(txtCEP.Text);
            obj.estado = txtEstado.Text;
            obj.cidade = txtCidade.Text;
            obj.logradouro = txtLogradouro.Text;    
            obj.numero = int.Parse(txtNumero.Text);
            obj.bairro = txtBairro.Text;
            obj.complemento = txtComplemento.Text;
            //obj.telefone = txtTelefone;
            obj.email = txtEmail.Text;
            
            
        }
    }
}
