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
    public class EstagiarioDAO
    {
        public void AdicionarEstagiario(Estagiario estagiario)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO ESTAGIARIOS(NOME_ESTAGIARIO, CURSO, PERIODO, TELEFONE, DATA_INICIO) VALUES(@NOME, @CURSO, @PERIODO, @TELEFONE, @DATAINICIO);";
            comando.Parameters.Add(new MySqlParameter("NOME", estagiario.Nome));
            comando.Parameters.Add(new MySqlParameter("CURSO", estagiario.NomeCurso));
            comando.Parameters.Add(new MySqlParameter("PERIODO", estagiario.Periodo));
            comando.Parameters.Add(new MySqlParameter("TELEFONE", estagiario.Telefone));
            comando.Parameters.Add(new MySqlParameter("DATAINICIO", estagiario.DataInicio));
            comando.ExecuteNonQuery();
        }

        public DataTable GetEstagiarios()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ESTAGIARIOS;";
            DbDataReader reader = DAOUtils.GetReader(comando);
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        public void ExcluirEstagiarios(int ID)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM ESTAGIARIOS WHERE ID_ESTAGIARIO = @ID;";
            comando.Parameters.Add(new MySqlParameter("ID", ID));
            comando.ExecuteNonQuery();
        }

        public void AlterarEstagiario(Estagiario estagiario)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE ESTAGIARIOS SET NOME_ESTAGIARIO = @NOME, CURSO = @CURSO, PERIODO = @PERIODO, TELEFONE = @TELEFONE, DATA_INICIO = @DATA_INICIO WHERE ID_ESTAGIARIO = @ID;";
            comando.Parameters.Add(new MySqlParameter("NOME", estagiario.Nome));
            comando.Parameters.Add(new MySqlParameter("CURSO", estagiario.NomeCurso));
            comando.Parameters.Add(new MySqlParameter("PERIODO", estagiario.Periodo));
            comando.Parameters.Add(new MySqlParameter("TELEFONE", estagiario.Telefone));
            comando.Parameters.Add(new MySqlParameter("DATA_INICIO", estagiario.DataInicio));
            comando.Parameters.Add(new MySqlParameter("Id",estagiario.ID));
            comando.ExecuteNonQuery();
        }
    }
}
