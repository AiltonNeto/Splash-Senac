using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClientes frm = new frmCadClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mensagem = MessageBox.Show("Deseja Sair do Sistema?","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

           if (Convert.ToString(mensagem) == "Yes")
            {
                Close();
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre formSobre = new frmSobre();
            formSobre.MdiParent = this;
            formSobre.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaClientes frm_pesquisa_clientes = new frmPesquisaClientes();
            frm_pesquisa_clientes.MdiParent = this;
            frm_pesquisa_clientes.Show();

        }
    }
}
