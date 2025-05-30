using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class LoginController
    {
        private readonly UsuarioDAO usuarioDAO;

        // Ahora recibe la cadena de conexión directamente, como antes.
        // La obtención de la cadena de conexión desde ConfigurationManager se hace en ConexionBDD.
        public LoginController(string connectionString)
        {
            usuarioDAO = new UsuarioDAO(connectionString);
        }

        public Usuario IniciarSecion(string username, string password)
        {
            return usuarioDAO.validarlogign(username, password);
        }
    }
}