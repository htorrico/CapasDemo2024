using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCliente
    {
        public DataTable ListarClientesDT()
        {
            SqlConnection connection = new SqlConnection(AccesoDatos.cadena);

            connection.Open();

            SqlCommand command = new SqlCommand("Select * from clientes", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }

        public List<Cliente> ListarClientesDR(string filtro)
        {
            
            SqlConnection connection = new SqlConnection(AccesoDatos.cadena);

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from clientes where NombreContacto like '%" + filtro + "%'", connection);


            List<Cliente> listaClientes = new List<Cliente>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                Cliente cliente = new Cliente();
                cliente.IdCLiente = reader["idcliente"].ToString();
                cliente.NombreContacto = reader["nombrecontacto"].ToString();
                listaClientes.Add(cliente);


            }
            connection.Close();

            return listaClientes;

        }

        public List<Cliente> ListarClientesPA(string contacto, string compania)
        {
            
            SqlConnection connection = new SqlConnection(AccesoDatos.cadena);
            connection.Open();

            SqlCommand command = new SqlCommand("USP_ListarClientes", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParameter1 = new SqlParameter("@contacto", SqlDbType.VarChar, 50);
            sqlParameter1.Value = contacto;

            SqlParameter sqlParameter2 = new SqlParameter("@compania", SqlDbType.VarChar, 50);
            sqlParameter2.Value = compania;


            command.Parameters.Add(sqlParameter1);
            command.Parameters.Add(sqlParameter2);

            List<Cliente> listaClientes = new List<Cliente>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {


                Cliente cliente = new Cliente();         
                cliente.IdCLiente = reader["idcliente"].ToString();
                cliente.NombreContacto = reader["nombrecontacto"].ToString();
                    listaClientes.Add(cliente);
           
            }
            connection.Close();


            

            return listaClientes;
        }
        
    }
}
