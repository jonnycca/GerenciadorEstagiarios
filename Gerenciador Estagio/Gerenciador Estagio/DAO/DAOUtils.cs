using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_estágio.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            DbConnection conexao = new MySqlConnection(@"Server=localHost;Database=gerenciadordeestagio;Uid=root;Pwd=123456;");
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetReader(DbCommand comando)
        {
            DbDataReader reader = comando.ExecuteReader();
            return reader;
        }

    }
}
