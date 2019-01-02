using Gerenciador_de_estágio.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Estagio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool VerificarLogin()
        {
            string usuario = TxbNome.Text;
            string senha = TxbSenha.Text;

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM USUARIOS WHERE NOME_USUARIO = @NOME AND SENHA = @SENHA;";
            comando.Parameters.Add(new MySqlParameter("NOME", usuario));
            comando.Parameters.Add((new MySqlParameter("SENHA", senha)));
            DbDataReader reader = DAOUtils.GetReader(comando);

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxbNome.Text != string.Empty && TxbSenha.Text != string.Empty)
            {
                if (VerificarLogin() == true)
                {
                    FrmPrincipal form = new FrmPrincipal();
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
