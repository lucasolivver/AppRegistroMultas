using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AppRegistroMultas.Models;
using System.Reflection;

namespace AppRegistroMultas.Contexto
{
    public class VeiculoContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;


        public VeiculoContext()
        {
            dados_conexao = "server=localhost;port=3306;database=bd_registro_multa2;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);

        }

        public List<Veiculo> ListarVeiculos() 
        {

            List<Veiculo> listaVeiculosParaExportar = new List<Veiculo>();
            string sql = "SELECT * FROM VEICULO";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao); 
                conexao.Open();
                MySqlDataReader dados = comando.ExecuteReader();

                
                while (dados.Read())
                {
                    Veiculo veiculo = new Veiculo();
                    veiculo.Id = Convert.ToInt32(dados["Id"]);
                    veiculo.Modelo = dados["Modelo"].ToString();
                    veiculo.Marca = dados["Marca"].ToString();
                    veiculo.Placa = dados["Placa"].ToString();
                    listaVeiculosParaExportar.Add(veiculo);

                }
                conexao.Close();
            }
             
            catch(Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
            return listaVeiculosParaExportar;


        }

        public void InserirVeiculo(Veiculo veiculo)
        {
            
            string sql = "INSERT INTO VEICULO (Modelo, Marca, Placa) VALUES (@Modelo, @Marca, @Placa)";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                comando.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                comando.Parameters.AddWithValue("@Marca", veiculo.Marca);
                comando.Parameters.AddWithValue("@Placa", veiculo.Placa);

                conexao.Open(); 
                int linhasAfetadas = comando.ExecuteNonQuery(); 

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir veiculo" + ex.Message);

            }
            finally
            {
                conexao.Close();
            }



        }
        public void AtualizarVeiculo(Veiculo veiculo)
        {
            
            string sql = "UPDATE VEICULO SET Modelo = @Modelo, Marca = @Marca, Placa = @Placa WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                
                comando.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                comando.Parameters.AddWithValue("@Marca", veiculo.Marca);
                comando.Parameters.AddWithValue("@Placa", veiculo.Placa);
                comando.Parameters.AddWithValue("@Id", veiculo.Id);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery(); 

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Veiculo atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma Veiculo foi atualizado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Veiculo: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        } 
        public void DeletarVeiculo(Veiculo veiculo)
        {

            string sql = "DELETE FROM MULTA WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                comando.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                comando.Parameters.AddWithValue("@Marca", veiculo.Marca);
                comando.Parameters.AddWithValue("@Placa", veiculo.Placa);
                comando.Parameters.AddWithValue("@Id", veiculo.Id);
                conexao.Open(); 
                int linhasAfetadas = comando.ExecuteNonQuery(); 

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Veiculo deletado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma Veiculo foi deletado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar Veiculo: " + ex.Message);
            }
            finally
            {
                conexao.Close(); 
            }
        } 


    }
}


