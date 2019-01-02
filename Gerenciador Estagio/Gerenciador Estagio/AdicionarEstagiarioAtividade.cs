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
    public partial class AdicionarEstagiarioAtividade : Form
    {
        public AdicionarEstagiarioAtividade()
        {
            InitializeComponent();
        }

        private void AdicionarEstagiarioAtividade_Load(object sender, EventArgs e)
        {
            CarregarListBox();
        }

        private void CarregarListBox()
        {
            EstagiarioDAO estagiariosDAO = new EstagiarioDAO();
            ClbEstagiarios.DataSource = estagiariosDAO.GetEstagiarios();
            ClbEstagiarios.Refresh();
        }
    }
}
