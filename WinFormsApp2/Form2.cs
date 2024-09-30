using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        string cadena = AccesoDatos.cadena;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
            try
            {
            
                SqlConnection connection = new SqlConnection(cadena);

                connection.Open();

                SqlCommand command = new SqlCommand("USP_InsertarCategorias", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter1 = new SqlParameter("@idcategoria", SqlDbType.Int);
                sqlParameter1.Value = Convert.ToInt32( txtIdCatgoria.Text);

                SqlParameter sqlParameter2 = new SqlParameter("@nombrecategoria", SqlDbType.VarChar, 100);
                sqlParameter2.Value = txtNombre.Text;

                SqlParameter sqlParameter3 = new SqlParameter("@descripcion", SqlDbType.VarChar, 200);
                sqlParameter3.Value = txtDescrpcion.Text;

                SqlParameter sqlParameter4 = new SqlParameter("@Activo", SqlDbType.Bit);
                sqlParameter4.Value =txtActivo.Text=="1";
                
                SqlParameter sqlParameter5 = new SqlParameter("@CodCategoria", SqlDbType.VarChar, 50);
                sqlParameter5.Value = txtCodigo.Text;

                

                command.Parameters.Add(sqlParameter1);
                command.Parameters.Add(sqlParameter2);
                command.Parameters.Add(sqlParameter3);
                command.Parameters.Add(sqlParameter4);
                command.Parameters.Add(sqlParameter5);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Registro Exitoso");

            }
            catch (Exception)
            {
                MessageBox.Show("Error de Conexión");
                throw;
            }
        }
    }
}
