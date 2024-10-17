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
        void Demo()
        {
            //LogicaNegocio
        }

        void Demo2()
        {
            //LogicaNegocio
        }

        void Demo3()
        {
            //LogicaNegocio
        }
         void Demo4()
        {
            //LogicaNegocio
        }
          void Demo5()
        {
            //LogicaNegocio
        }
            void Demo6()
        {
            //LogicaNegocio
        }

             void Demo7()
        {
            //LogicaNegocio
        }
        void Demo8()
        {
            //LogicaNegocio
        }

        void Demo10()
        {
            //LogicaNegocio Nuevo
        }
    }
}
