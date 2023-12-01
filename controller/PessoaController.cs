using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_Padaria.conexao;
using TCC_Padaria.model;
using Microsoft.OData.Edm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TCC_Padaria.controller
{
    public class PessoaController 
    {
        private MySqlConnection conexao;
        public PessoaController() 
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region cadastrarPessoa
        public void cadastrarPessoa(Pessoa obj)
        {
            try
            {

                string sql = @"insert into pessoa(idPessoa,Nome,
                            Datacriacao,Nomefantasia,Razaosocial,IE_RG,
                            CPF_CNPJ,Situacao,Telcomercial
                            ,Telresidencial,Celular,email)
                            VALUES(@idPessoa,@Nome,@Datacriacao,
                            @Nomefantasia,@Razaosocial,
                            @IE_RG,@CPF_CNPJ,@Situacao,@Telcomercial,
                            @Telresidencial,@Celular,@email)";



                MySqlCommand executacmd = new MySqlCommand(sql ,conexao);
                executacmd.Parameters.AddWithValue("@idPessoa", obj.idPessoa);
                executacmd.Parameters.AddWithValue("@Nome",obj.nome);
                executacmd.Parameters.AddWithValue("@Datacriacao", obj.dataCriacao);
                executacmd.Parameters.AddWithValue("@Nomefantasia", obj.nomeFantasia);
                executacmd.Parameters.AddWithValue("@Razaosocial", obj.razaoSocial);
                executacmd.Parameters.AddWithValue("@IE_RG", obj.IE_RG);
                executacmd.Parameters.AddWithValue("@CPF_CNPJ", obj.CPF_CNPJ);
                executacmd.Parameters.AddWithValue("@Situacao", obj.situacao);
                executacmd.Parameters.AddWithValue("@Telcomercial", obj.telComercial);
                executacmd.Parameters.AddWithValue("@Telresidencial", obj.telResidencial);
                executacmd.Parameters.AddWithValue("@Celular", obj.celular);
                executacmd.Parameters.AddWithValue("@email", obj.email);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                

                MessageBox.Show("Pessoa cadastrada com sucesso! ");

                conexao.Close();

            }
            catch (Exception erro) 
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }
        #endregion
        
       
        #region altearPessoa
        public void alterarPessoa(Pessoa obj)
        {
            try
            {
                string sql = @"UPDATE pessoa SET Nome = @Nome,Datacriacao = @Datacriacao,Nomefantasia = @Nomefantasia,Razaosocial = @Razaosocial,IE_RG = @IE_RG,CPF_CNPJ = @CPF_CNPJ,Situacao = @Situacao,Telcomercial = @Telcomercial,Telresidencial = @Telresidencial,Celular = @Celular,email = @email WHERE idPessoa = @idPessoa";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                executacmd.Parameters.AddWithValue("@Nome", obj.nome);
                executacmd.Parameters.AddWithValue("@Datacriacao", obj.dataCriacao);
                executacmd.Parameters.AddWithValue("@Nomefantasia", obj.nomeFantasia);
                executacmd.Parameters.AddWithValue("@Razaosocial", obj.razaoSocial);
                executacmd.Parameters.AddWithValue("@IE_RG", obj.IE_RG);
                executacmd.Parameters.AddWithValue("@CPF_CNPJ", obj.CPF_CNPJ);
                executacmd.Parameters.AddWithValue("@Situacao", obj.situacao);
                executacmd.Parameters.AddWithValue("@Telcomercial", obj.telComercial);
                executacmd.Parameters.AddWithValue("@Telresidencial", obj.telResidencial);
                executacmd.Parameters.AddWithValue("@Celular", obj.celular);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@idPessoa", obj.idPessoa);



                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Pessoa alterada com sucesso! ");

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }
        #endregion

        #region excluirPessoa
        public void excluirPessoa(Pessoa obj)
        {
            try
            {

                string sql = @"DELETE FROM pessoa WHERE idPessoa=@idPessoa";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idPessoa", obj.idPessoa);

                conexao.Open();
                executacmd.ExecuteNonQuery();



                MessageBox.Show("Pessoa excluída com sucesso! ");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }
        #endregion

        #region listarPessoa
        public DataTable listarPessoa()
        {
            try
            {
                DataTable tabelapessoa = new DataTable();

                string sql = @"SELECT * FROM pessoa";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelapessoa);

                conexao.Close() ;

                return tabelapessoa;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }
        #endregion

        #region BuscarPessoaPorNome

        public DataTable BuscarPessoaPorNome(string nome)
        {
            try
            {
                DataTable tabelapessoa = new DataTable();

                string sql = @"SELECT * FROM pessoa where Nome = @Nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelapessoa);

                conexao.Close();

                return tabelapessoa;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }

        #endregion

        #region ListarPessoaPorNome

        public DataTable ListarPessoaPorNome(string nome)
        {
            try
            {
                DataTable tabelapessoa = new DataTable();

                string sql = @"SELECT * FROM pessoa where Nome like @Nome";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelapessoa);

                conexao.Close();

                return tabelapessoa;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }

        #endregion
    }
}
  


