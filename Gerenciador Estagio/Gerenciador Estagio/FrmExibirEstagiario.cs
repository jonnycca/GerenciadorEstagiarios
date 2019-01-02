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
    public partial class FrmExibirEstagiario : Form
    {
        public FrmExibirEstagiario(bool EstadoBtnExcluir, bool EstadoBtnAlterar)
        {
            InitializeComponent();
            BtnExcluir.Enabled = EstadoBtnExcluir;
            BtnAlterar.Enabled = EstadoBtnAlterar;
        }

        private void FrmExibirEstagiario_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)DgvEstagiarios.CurrentRow.Cells[0].Value;
            EstagiarioDAO estagiarioDAO = new EstagiarioDAO();
            estagiarioDAO.ExcluirEstagiarios(id);
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            EstagiarioDAO estagiarioDAO = new EstagiarioDAO();
            DataTable table = estagiarioDAO.GetEstagiarios();
            DgvEstagiarios.DataSource = table;
            DgvEstagiarios.Refresh();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Estagiario estagiario = new Estagiario
            {
                ID = (int)DgvEstagiarios.CurrentRow.Cells[0].Value,
                Nome = DgvEstagiarios.CurrentRow.Cells[1].Value.ToString(),
                NomeCurso = DgvEstagiarios.CurrentRow.Cells[2].Value.ToString(),
                Periodo = (int)DgvEstagiarios.CurrentRow.Cells[3].Value,
                Telefone = DgvEstagiarios.CurrentRow.Cells[4].Value.ToString(),
                DataInicio = (DateTime)DgvEstagiarios.CurrentRow.Cells[5].Value,
            };
            FrmCadastrarEstagiario form = new FrmCadastrarEstagiario(estagiario);
            form.ShowDialog();
            CarregarDataGridView();
        }

        private void FrmExibirEstagiario_Shown(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }
    }
}
