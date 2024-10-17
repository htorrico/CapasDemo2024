using Negocio;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        
        NegocioCliente negocioCliente = new NegocioCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Listar Desconectado
            try
            {               
                dgvClientes.DataSource = negocioCliente.ListarClientesDT();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de Conexión");
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Listar Conectado
            try
            {                
                dgvClientes.DataSource = negocioCliente.ListarClientesDR(txtFiltro.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Error de Conexión");
                throw;
            }
        }

        private void btnListarProcedimientos_Click(object sender, EventArgs e)
        {
            //Listar Conectado
            try
            {               
                dgvClientes.DataSource = negocioCliente.ListarClientesPA(txtContacto.Text,txtCompania.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Error de Conexión");
                throw;
            }
        }

        public void FuncionA()
        {
            //LOGICA NEGOCIO
        }

        public void FuncionB()
        {
            //LOGICA NEGOCIO
        }
    }
}
