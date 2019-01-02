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
    public partial class FrmExibirEstagiarioCheckComboBox : Form
    {
        public FrmExibirEstagiarioCheckComboBox()
        {
            InitializeComponent();
            CarregarCheckComboBox();
        }
        private void CarregarCheckComboBox()
        {
            EstagiarioDAO estagiarioDAO = new EstagiarioDAO();
            DataTable table = estagiarioDAO.GetEstagiarios();
            ClbEstagiarios.DataSource = table;
            ClbEstagiarios.DisplayMember = "NOME";
            ClbEstagiarios.ValueMember = "NOME_ESTAGIARIO";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ClbEstagiarios.CheckedIndices.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione ao menos um estagiário.");
            }
        }
    }
}
