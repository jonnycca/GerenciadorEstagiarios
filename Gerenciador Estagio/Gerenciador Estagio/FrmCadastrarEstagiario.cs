using Gerenciador_Estagio.Classes;
using Gerenciador_Estagio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Estagio
{
    public partial class FrmCadastrarEstagiario : Form
    {
        Estagiario estagiario;
        public FrmCadastrarEstagiario(Estagiario estagiario = null)
        {
            this.estagiario = estagiario;
            InitializeComponent();
        }
        public FrmCadastrarEstagiario()
        {
            InitializeComponent();
        }

        private bool CamposPreenchidos()
        {//verificar se os campos estão preenchidos
            if (TxbNome.Text != string.Empty && TxbCurso.Text != string.Empty && TxbPeriodo.Text != string.Empty && TxbTelefone.Text != string.Empty && TxbDataInicio.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            EstagiarioDAO estagiarioDAO = new EstagiarioDAO();
            if (CamposPreenchidos() == true)
            {
                if (this.estagiario == null)
                {
                    Estagiario estagiario = new Estagiario
                    {
                        Nome = TxbNome.Text,
                        NomeCurso = TxbCurso.Text,
                        Periodo = Convert.ToInt32(TxbPeriodo.Text),
                        Telefone = TxbTelefone.Text,
                        DataInicio = Convert.ToDateTime(TxbDataInicio.Text)
                    };
                    estagiarioDAO.AdicionarEstagiario(estagiario);
                }
                else
                {
                    this.estagiario.Nome = TxbNome.Text;
                    this.estagiario.NomeCurso = TxbCurso.Text;
                    this.estagiario.Periodo = Convert.ToInt32(TxbPeriodo.Text);
                    this.estagiario.Telefone = TxbTelefone.Text;
                    this.estagiario.DataInicio = Convert.ToDateTime(TxbDataInicio.Text);
                    estagiarioDAO.AlterarEstagiario(estagiario);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
        }

        private void FrmCadastrarEstagiario_Load(object sender, EventArgs e)
        {
            if (this.estagiario != null)
            {
                TxbNome.Text = estagiario.Nome;
                TxbCurso.Text = estagiario.NomeCurso;
                TxbPeriodo.Text = estagiario.Periodo.ToString();
                TxbTelefone.Text = estagiario.Telefone;
                TxbDataInicio.Text = estagiario.DataInicio.ToString();
            }
            else
            {
                TxbNome.Text = string.Empty;
                TxbCurso.Text = string.Empty;
                TxbPeriodo.Text = string.Empty;
                TxbTelefone.Text = string.Empty;
                TxbDataInicio.Text = string.Empty;
            }
        }
    }
}
