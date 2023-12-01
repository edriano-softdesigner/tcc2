using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_Padaria.conexao;
using TCC_Padaria.model;

namespace TCC_Padaria.controller
{
    public class EnderecoController
    {
        private MySqlConnection conexao;
        public EnderecoController()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region cadastrarEndereco
        public void cadastrarEndereco(Endereco obj)
        {
            try
            {

                string sql = @"insert into endereco(idEndereco,idPessoa,
                            idTPendereco,cep,Estado,Cidadade,
                            Logradouro,Numero,Bairro
                            ,Complemento,EnderecoPadrao)
                            VALUES (@idEndereco,@idPessoa,
                            @idTPendereco,@cep,@Estado,@Cidade,
                            @Logradouro,@Numero,@Bairro
                            ,@Complemento,@EnderecoPadrao)";



                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idEndereco", obj.idEndereco);
                executacmd.Parameters.AddWithValue("@idPessoa", obj.idPessoa);
                executacmd.Parameters.AddWithValue("@idTPendereco", obj.idTPendereco);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@Estado", obj.estado);
                executacmd.Parameters.AddWithValue("@Cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@Logradouro", obj.logradouro);
                executacmd.Parameters.AddWithValue("@Numero", obj.numero);
                executacmd.Parameters.AddWithValue("@Bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@Complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@EnderecoPadrao", obj.enderecoPadrao);
               

                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Endereco cadastrado com sucesso! ");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }
        #endregion

        #region altearEndereco
        public void alterarEndereco(Endereco obj)
        {
            try
            {

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
        #endregion
    }
}
