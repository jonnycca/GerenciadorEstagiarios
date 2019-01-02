using Gerenciador_de_estágio.DAO;
using Gerenciador_Estagio.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Estagio.DAO
{
    public class AtividadesDAO
    {
        public void AdicionarAtividade(Atividades atividades)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO ATIVIDADES(TITULO, PROBLEMA_RESOLVER, DESCRICAO_SOLUCAO, SETOR, DATA_REGISTRO, ESTADO) VALUES(@titulo, @problema, @descricao_solucao, @setor, @data, @estado);";
            comando.Parameters.Add(new MySqlParameter("titulo",atividades.Titulo_Atividade));
            comando.Parameters.Add(new MySqlParameter("problema", atividades.Descricao_Problema));
            comando.Parameters.Add(new MySqlParameter("descricao_solucao", atividades.Descricao_Solucao));
            comando.Parameters.Add(new MySqlParameter("setor", atividades.Setor_Atuado));
            comando.Parameters.Add(new MySqlParameter("data", atividades.DataAtividade));
            comando.Parameters.Add(new MySqlParameter("estado", atividades.Estado));
            comando.ExecuteNonQuery();
        }

        public DataTable ExibirAtividades()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ATIVIDADES;";
            DbDataReader reader = comando.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

/*        public void InserirEstagiarioNaAtividade(string titulo, int idEstagiario)
        {
            int resultado;
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT ID FROM ATIVIDADES WHERE TITULO LIKE @titulo%;";
            comando.Parameters.Add(new MySqlParameter("titulo", titulo));
            resultado = Convert.ToInt16(comando.ExecuteScalar());
            comando.CommandText = "INSERT INTO TRABALHO VALUES(@idatividade, @idestagiario);";
            comando.Parameters.Add(new MySqlParameter("idatividade", resultado));
            comando.Parameters.Add(new MySqlParameter("idestagiario", idEstagiario)); ;
            comando.ExecuteNonQuery();
        }
        */
        public void ExcluirAtividades(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM ATIVIDADES WHERE ID_ATIVIDADE = @ID";
            comando.Parameters.Add(new MySqlParameter("ID", id));
            comando.ExecuteNonQuery();
        }

        public void AlterarAtividades(Atividades atividades)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE ATIVIDADES SET TITULO = @TITULO, PROBLEMA_RESOLVER = @PROBLEMA_RESOLVER, DESCRICAO_SOLUCAO = @DESCRICAO_SOLUCAO, SETOR = @SETOR, DATA_REGISTRO = @DATA_REGISTRO, ESTADO = @ESTADO WHERE ID_ATIVIDADE = @ID;";
            comando.Parameters.Add(new MySqlParameter("TITULO", atividades.Titulo_Atividade));
            comando.Parameters.Add(new MySqlParameter("PROBLEMA_RESOLVER", atividades.Descricao_Problema));
            comando.Parameters.Add(new MySqlParameter("DESCRICAO_SOLUCAO", atividades.Descricao_Solucao));
            comando.Parameters.Add(new MySqlParameter("SETOR", atividades.Setor_Atuado));
            comando.Parameters.Add(new MySqlParameter("DATA_REGISTRO", atividades.DataAtividade));
            comando.Parameters.Add(new MySqlParameter("ESTADO", atividades.Estado));
            comando.Parameters.Add(new MySqlParameter("ID", atividades.ID_ATIVIDADE));
            comando.ExecuteNonQuery();
        }
    }
}
