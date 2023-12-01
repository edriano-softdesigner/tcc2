using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_Padaria.controller;
using TCC_Padaria.model;

namespace TCC_Padaria.view
{
    public partial class frmCadastroPessoa : Form
    {
        private object Private;
        private MySqlCommand executacmd;
        public frmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa obj = new Pessoa();
            
            try
            {
                obj.idPessoa = int.Parse(txtCodigo.Text.Trim());
                obj.nome = txtNome_NomeFantasia.Text.Trim();
                obj.nomeFantasia = txtNome_NomeFantasia.Text.Trim();
                obj.dataCriacao = dtNasc_DcPessoa.Value.Date;
                obj.razaoSocial = txtRazaoSocial.Text.Trim();
                obj.IE_RG = txtInscricaoEstadual_RG.Text.Trim();
                obj.CPF_CNPJ = txtCPF_CNPJ.Text.Trim();

                string status = gBxStatus.Controls.OfType<RadioButton>().First(RadioButton => RadioButton.Checked).Text;
                if (gBxStatus.Controls.OfType<RadioButton>().First(RadioButton => RadioButton.Checked).Checked == true)
                {
                    if (status == rdBtnAtivo.Text)
                    {
                      

                        obj.situacao = "Ativo";

                    }
                    if (status == rdBtnInativo.Text)
                    {

                        obj.situacao = "Inativo";

                    }

                }
                obj.telComercial = txtComercial.Text.Trim();
                obj.telResidencial = txtResidencial.Text.Trim();
                obj.celular = txtCelular.Text.Trim();
                obj.email = txtEmail.Text;

                PessoaController dao = new PessoaController();
                dao.cadastrarPessoa(obj);
                BindingSource bs = new BindingSource();
                PessoaController dao1 = new PessoaController();
                bs.DataSource = dao1.listarPessoa();
                tabelaPessoa.DataSource = bs;


            }
            catch (Exception erro)
            {


                MessageBox.Show("Aconteceu o erro: " + erro);

            }
            
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            PessoaController dao = new PessoaController();
      
            tabelaPessoa.DataSource = dao.listarPessoa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           Pessoa obj = new Pessoa();
            obj.idPessoa = int.Parse(txtCodigo.Text);
            PessoaController dao = new PessoaController();
            dao.excluirPessoa(obj);
            
            BindingSource bs = new BindingSource();
            PessoaController dao1 = new PessoaController();
            bs.DataSource = dao1.listarPessoa();
            tabelaPessoa.DataSource=bs;
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            
            Pessoa obj = new Pessoa();

            try
            {
                obj.idPessoa = int.Parse(txtCodigo.Text);
                obj.nome = txtNome_NomeFantasia.Text;
                obj.nomeFantasia = txtNome_NomeFantasia.Text;
                obj.dataCriacao = dtNasc_DcPessoa.Value.Date;
                obj.razaoSocial = txtRazaoSocial.Text;
                obj.IE_RG = txtInscricaoEstadual_RG.Text.Trim();
                obj.CPF_CNPJ = txtCPF_CNPJ.Text.Trim();
               


                string status = gBxStatus.Controls.OfType<RadioButton>().First(RadioButton => RadioButton.Checked).Text;
                if (gBxStatus.Controls.OfType<RadioButton>().First(RadioButton => RadioButton.Checked).Checked == true)
                {
                    if (status == rdBtnAtivo.Text)
                    {


                        obj.situacao = "Ativo";

                    }
                    if (status == rdBtnInativo.Text)
                    {

                        obj.situacao = "Inativo";

                    }

                   

                    
                    obj.telComercial = txtComercial.Text.Trim();
                    obj.telResidencial = txtResidencial.Text.Trim();
                    obj.celular = txtCelular.Text.Trim();
                    obj.email = txtEmail.Text;
                    obj.idPessoa = int.Parse(txtCodigo.Text);

                    PessoaController dao = new PessoaController();
                    dao.alterarPessoa(obj);
                    
                    BindingSource bs = new BindingSource();
                    PessoaController dao1 = new PessoaController();
                    bs.DataSource = dao1.listarPessoa();
                    tabelaPessoa.DataSource = bs;
                }

            }
            catch (Exception erro)
            {


                MessageBox.Show("Aconteceu o erro: " + erro);

            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }


        private void tabelaPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCodigo.Text = txtCodigo.Text.Trim();
            txtCodigo.Text = tabelaPessoa.CurrentRow.Cells[0].Value.ToString();
            txtNome_NomeFantasia.Text = tabelaPessoa.CurrentRow.Cells[1].Value.ToString();
            dtNasc_DcPessoa.Text = tabelaPessoa.CurrentRow.Cells[2].Value.ToString();
            txtNome_NomeFantasia.Text = tabelaPessoa.CurrentRow.Cells[3].Value.ToString();
            txtRazaoSocial.Text = tabelaPessoa.CurrentRow.Cells[4].Value.ToString();
            txtInscricaoEstadual_RG.Text = tabelaPessoa.CurrentRow.Cells[5].Value.ToString();
            txtCPF_CNPJ.Text = tabelaPessoa.CurrentRow.Cells[6].Value.ToString();
            gBxStatus.Text = gBxStatus.Text.Trim();
            gBxStatus.Text = tabelaPessoa.CurrentRow.Cells[7].Value.ToString();
            txtComercial.Text = tabelaPessoa.CurrentRow.Cells[8].Value.ToString();
            txtResidencial.Text = tabelaPessoa.CurrentRow.Cells[9].Value.ToString();
            txtCelular.Text = tabelaPessoa.CurrentRow.Cells[10].Value.ToString();
            txtEmail.Text = tabelaPessoa.CurrentRow.Cells[11].Value.ToString();

            
            

            tabPessoas.SelectedTab = tabPage1;

            BindingSource bs = new BindingSource();
            PessoaController dao1 = new PessoaController();
            bs.DataSource = dao1.listarPessoa();
            tabelaPessoa.DataSource = bs;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text.Trim();
            PessoaController dao = new PessoaController();
            tabelaPessoa.DataSource = dao.BuscarPessoaPorNome(nome);

            if(tabelaPessoa.Rows.Count == 0) 
            {
                tabelaPessoa.DataSource = dao.listarPessoa();
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";
            PessoaController dao = new PessoaController();
            tabelaPessoa.DataSource = dao.ListarPessoaPorNome(nome);

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCEP.Text.Trim();
                string xml = "https://viacep.com.br/ws/"+cep+"/xml/";
                DataSet dados = new DataSet();

                dados.ReadXml(xml);
                txtLogradouro.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }

        private void btnPesquisa2_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text.Trim();
            PessoaController dao = new PessoaController();
            tabelaPessoa.DataSource = dao.BuscarPessoaPorNome(nome);

            if (tabelaPessoa.Rows.Count == 0)
            {
                tabelaPessoa.DataSource = dao.listarPessoa();
            }
        }
    }
}
