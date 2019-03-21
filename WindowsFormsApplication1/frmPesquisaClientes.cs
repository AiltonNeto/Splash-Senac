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
    public partial class frmPesquisaClientes : Form
    {

        private List<Telefone> listaContatos = new List<Telefone>();

        public frmPesquisaClientes()
        {
            InitializeComponent();
        }

        private void frmPesquisaClientes_Load(object sender, EventArgs e)
        {

            configurarListas();

        }

        private void configurarListas()
        {
            gridClientes.AutoGenerateColumns = false;
            gridClientes.AllowUserToAddRows = false;
            gridClientes.DataSource = CarregarClientes();

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Código";
            column1.HeaderText = "Código";
            column1.DataPropertyName = "Id";
            gridClientes.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Nome";
            column2.HeaderText = "Nome";
            column2.DataPropertyName = "NomeFantasia";
            gridClientes.Columns.Add(column2);            
            
        }



        private List<Cliente> CarregarClientes()
        {
            List<Cliente> lstClientes = new List<Cliente>();

            var DadosCliente = new Cliente();

            DadosCliente.Id = 1;
            DadosCliente.NomeFantasia = "Ailton Neto 1";
            lstClientes.Add(DadosCliente);

            DadosCliente = new Cliente();
            DadosCliente.Id = 2;
            DadosCliente.NomeFantasia = "Ailton Neto 2";
            lstClientes.Add(DadosCliente);

            DadosCliente = new Cliente();
            DadosCliente.Id = 3;
            DadosCliente.NomeFantasia = "Ailton Neto 3";
            lstClientes.Add(DadosCliente);

            return lstClientes;
        }

        private List<Telefone> InserirContatos()
        {            
            
            var novoContato = new Telefone();
            novoContato.contato = txtTelefone.Text;
            listaContatos.Add(novoContato);            
            return listaContatos;
        }


        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            lbContatos.DataSource = null;
            if (txtTelefone.Text == "(  )     -")
            {
                MessageBox.Show("Insira um telefone!","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbContatos.DataSource = InserirContatos();
        }        


    }
}
