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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();            

            
    }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = long.Parse(txtID.Text);
            cliente.CPF = txtCPF.Text;
            cliente.RG = long.Parse(txtRg.Text);
            cliente.DataNascimento = dateTimePicker1.Value;
            cliente.RazaoSocial = txtRazaoSocial.Text;
            cliente.NomeFantasia = txtNome.Text;
            cliente.Rua = txtRua.Text;
            cliente.Numero = txtNumeroCasa.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.UF = cbUF.Text;
            cliente.IBGE = txtIBGE.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.CEP = txtCEP.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtEmail.Text;
            cliente.Observacoes = txtObservacoes.Text;
            cliente.Pai = txtPai.Text;
            cliente.Mae = txtMae.Text;
            cliente.Conjuge = txtConjuge.Text;
            cliente.Referencia = txtReferencia.Text;
            cliente.TelefoneRef = txtTelRef.Text;
            cliente.Empresa = txtEmpresa_Ref.Text;
            cliente.Salario = double.Parse(txtSalario_Ref.Text);
            cliente.Limite = double.Parse(txtLimite_Ref.Text);



        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaClientes formPesquisar = new frmPesquisaClientes();
            formPesquisar.MdiParent = this.MdiParent;
            formPesquisar.Show();
        }
    }
}
