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
    public partial class FrmExibirAtividades : Form
    {
        public FrmExibirAtividades(bool estadoBtnExcluir, bool estadoBtnAlterar)
        {
            InitializeComponent();
            CarregarDataGridView();
            BtnExcluir.Enabled = estadoBtnExcluir;
            BtnAlterar.Enabled = estadoBtnAlterar;
        }

        private void CarregarDataGridView()
        {
            AtividadesDAO atividadesDAO = new AtividadesDAO();
            DataTable table = atividadesDAO.ExibirAtividades();
            DgvAtividades.DataSource = table;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Atividades atividades = new Atividades
            {
                ID_ATIVIDADE = (int)DgvAtividades.CurrentRow.Cells[0].Value,
                Titulo_Atividade = DgvAtividades.CurrentRow.Cells[1].Value.ToString(),
                Descricao_Problema = DgvAtividades.CurrentRow.Cells[2].Value.ToString(),
                Descricao_Solucao = DgvAtividades.CurrentRow.Cells[3].Value.ToString(),
                Setor_Atuado = DgvAtividades.CurrentRow.Cells[4].Value.ToString(),
                DataAtividade = (DateTime)DgvAtividades.CurrentRow.Cells[5].Value,
                Estado = DgvAtividades.CurrentRow.Cells[5].Value.ToString()
            };
            FrmAdicionarAtividades form = new FrmAdicionarAtividades(atividades);
            form.ShowDialog();
            CarregarDataGridView();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)DgvAtividades.CurrentRow.Cells[0].Value;
            AtividadesDAO atividadesDAO = new AtividadesDAO();
            atividadesDAO.ExcluirAtividades(id);
            CarregarDataGridView();
        }
    }
}
