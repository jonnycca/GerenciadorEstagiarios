using Gerenciador_de_estágio.DAO;
using Gerenciador_Estagio.Classes;
using Gerenciador_Estagio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Estagio
{
    public partial class FrmAdicionarAtividades : Form
    {
        Atividades atividades;
        public FrmAdicionarAtividades(Atividades atividades = null)
        {
            this.atividades = atividades;
            InitializeComponent();
            CarregarComboBoxEstadoAtividade();
            CarregarCombobox();
        }

        public FrmAdicionarAtividades()
        {
            InitializeComponent();
            CarregarCombobox();
            CarregarComboBoxEstadoAtividade();
        }


        private bool VerificarTextBox()
        {
            FrmExibirEstagiarioCheckComboBox form = new FrmExibirEstagiarioCheckComboBox();
            if (TxbTitulo.Text != string.Empty && TxbDescricaoProblema.Text != string.Empty && CbxSetor.Text != string.Empty && TxbDescricaoSolucao.Text != string.Empty && TxbDataAtividade.Text != string.Empty && CbxEstadoAtividade.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CarregarCombobox()
        {
            this.CbxSetor.Items.Insert(0, "Administrativo");
            this.CbxSetor.Items.Insert(1,"Biblioteca");
            this.CbxSetor.Items.Insert(2, "Bloco A");
            this.CbxSetor.Items.Insert(3, "Bloco B");
            this.CbxSetor.Items.Insert(4, "Bloco C");
            this.CbxSetor.Items.Insert(5, "Bloco D");
            this.CbxSetor.Items.Insert(6, "Manutenção");
            this.CbxSetor.Items.Insert(7, "NEAP");
            this.CbxSetor.Items.Insert(8, "Nucleo jurídico");
        }

        private void CarregarComboBoxEstadoAtividade()
        {
            this.CbxEstadoAtividade.Items.Insert(0, "Pendente");
            this.CbxEstadoAtividade.Items.Insert(1, "Concluída");
        }

        private void BtnAdcionarEstagiarios_Click(object sender, EventArgs e)
        {
            FrmExibirEstagiarioCheckComboBox form = new FrmExibirEstagiarioCheckComboBox();
            form.ShowDialog();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            AtividadesDAO atividadesDAO = new AtividadesDAO();
            if (VerificarTextBox() == true)
            {
                if (this.atividades == null)
                {
                    Atividades atividade = new Atividades
                    {
                        Titulo_Atividade = TxbTitulo.Text,
                        Descricao_Problema = TxbDescricaoProblema.Text,
                        Setor_Atuado = CbxSetor.Text,
                        Descricao_Solucao = TxbDescricaoSolucao.Text,
                        DataAtividade = Convert.ToDateTime(TxbDataAtividade.Text),
                        Estado = CbxEstadoAtividade.Text
                    };
                    atividadesDAO.AdicionarAtividade(atividade);
                }
                else
                {
                    this.atividades.Titulo_Atividade = TxbTitulo.Text;
                    this.atividades.Descricao_Problema = TxbDescricaoProblema.Text;
                    this.atividades.Setor_Atuado = CbxSetor.Text;
                    this.atividades.Descricao_Solucao = TxbDescricaoSolucao.Text;
                    this.atividades.DataAtividade = Convert.ToDateTime(TxbDataAtividade.Text);
                    this.atividades.Estado = CbxEstadoAtividade.Text;
                }
                atividadesDAO.AlterarAtividades(atividades);
                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdicionarAtividades_Load(object sender, EventArgs e)
        {
            if (this.atividades != null)
            {
                TxbTitulo.Text = atividades.Titulo_Atividade;
                TxbDescricaoProblema.Text = atividades.Descricao_Problema;
                TxbDescricaoSolucao.Text = atividades.Descricao_Solucao;
                TxbDataAtividade.Text = atividades.DataAtividade.ToString();
                CbxEstadoAtividade.Text = atividades.Estado;
                CbxSetor.Text = atividades.Setor_Atuado;
            }
            else
            {
                TxbTitulo.Text = string.Empty;
                TxbDescricaoProblema.Text = string.Empty;
                TxbDescricaoSolucao.Text = string.Empty;
                TxbDataAtividade.Text = string.Empty;
                CbxEstadoAtividade.Text = string.Empty;
                CbxSetor.Text = string.Empty;
            }
        }
    }
}
