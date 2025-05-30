using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class LoginController
    {
        private readonly UsuarioDAO usuarioDAO;
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
