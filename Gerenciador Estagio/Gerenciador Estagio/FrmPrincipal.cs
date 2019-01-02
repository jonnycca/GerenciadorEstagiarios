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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarEstagiario form = new FrmCadastrarEstagiario();
            form.ShowDialog();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExibirEstagiario form = new FrmExibirEstagiario(false, false);
            form.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExibirEstagiario form = new FrmExibirEstagiario(true, false);
            form.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExibirEstagiario form = new FrmExibirEstagiario(false, true);
            form.ShowDialog();
        }
    }
}
