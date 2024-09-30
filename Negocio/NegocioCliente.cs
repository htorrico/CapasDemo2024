using Datos;
using System.Data.SqlClient;
using System.Data;
namespace Negocio
{
    public class NegocioCliente
    {
        DatosCliente datosCliente = new DatosCliente();

        public DataTable ListarClientesDT()
        {
            return datosCliente.ListarClientesDT();
        }

        public List<Cliente> ListarClientesDR(string filtro)
        {          
            return datosCliente.ListarClientesDR(filtro);
        }

        public List<Cliente> ListarClientesPA(string contacto, string compania)
        {

            return datosCliente.ListarClientesPA(contacto, compania);
        }
        public List<Cliente> ListarClientesMayores18PA(string contacto, string compania)
        {
            //ENTITY FRAMEWORK CORE (ORM)


            List<Cliente> clientes= datosCliente.ListarClientesPA(contacto, compania);
            List<Cliente> mayores = new List<Cliente>();
            //Lógica de Negocio
            foreach (var item in clientes)
            {
                if (item.Edad>18)
                {
                    mayores.Add(item);
                }
            }
            return mayores;

        }

        public List<Cliente> ListarClientesMenores18PA(string contacto, string compania)
        {

            List<Cliente> clientes = datosCliente.ListarClientesPA(contacto, compania);
            List<Cliente> mayores = new List<Cliente>();
            //Lógica de Negocio
            foreach (var item in clientes)
            {
                if (item.Edad < 18)
                {
                    mayores.Add(item);
                }
            }
            return mayores;

        }
    }
}
