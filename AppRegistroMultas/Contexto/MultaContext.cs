using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppRegistroMultas.Models;
using System.Reflection;
using Mysqlx.Crud;

namespace AppRegistroMultas.Contexto
{
    public class MultaContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;



        public MultaContext()
        {
            dados_conexao = "server=localhost;port=3306;database=bd_registro_multa2;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);

        }

        public List<Multa> ListarMultas()
        {

            List<Multa> listaMultasParaExportar = new List<Multa>();
            string sql = "SELECT * FROM MULTA";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao); 
                conexao.Open();
                MySqlDataReader dados = comando.ExecuteReader();

               
                while (dados.Read())
                {
                    Multa multa = new Multa();
                    multa.Id = Convert.ToInt32(dados["Id"]);
                    multa.Descricao = dados["Descricao"].ToString();
                    multa.ValorMulta = Convert.ToDecimal(dados["ValorMulta"]);
                    multa.VeiculoId = Convert.ToInt32(dados["VeiculoId"]);
                    listaMultasParaExportar.Add(multa);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
            return listaMultasParaExportar;


        }

        public void InserirMulta(Multa multa)
        {
            
            string sql = "INSERT INTO MULTA (Descricao, ValorMulta, VeiculoId) VALUES (@Descricao, @ValorMulta, @VeiculoId)";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", multa.VeiculoId);

                conexao.Open(); 
                int linhasAfetadas = comando.ExecuteNonQuery(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Multa" + ex.Message);

            }
            finally
            {
                conexao.Close();
            }



        }

        public void AtualizarMulta(Multa multa)
        {
            
            string sql = "UPDATE MULTA SET Descricao = @Descricao, ValorMulta = @ValorMulta, veiculoId = @VeiculoId WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

               
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", multa.VeiculoId);
                comando.Parameters.AddWithValue("@Id", multa.Id); 

                conexao.Open(); 
                int linhasAfetadas = comando.ExecuteNonQuery(); 

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Multa atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma Multa foi atualizado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Multa: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        } 
        public void DeletarMulta(Multa multa)
        {
            
            string sql = "DELETE FROM MULTA WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", multa.VeiculoId);
                comando.Parameters.AddWithValue("@Id", multa.Id);

                conexao.Open(); 
                int linhasAfetadas = comando.ExecuteNonQuery(); 

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Multa deletada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar multa: " + ex.Message);
            }
            finally
            {
                conexao.Close(); 
            }
        } 


    }
}
