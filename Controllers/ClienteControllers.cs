using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class ClienteControllers
    {
        private readonly ClienteDAO clienteDAO;

        public ClienteControllers(string connectionString)
        {
            clienteDAO = new ClienteDAO(connectionString);
        }

        public bool AgregarNuevoCliente(Cliente cliente)
        {
            return clienteDAO.AgregarCliente(cliente);
        }
    }
}
