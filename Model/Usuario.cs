using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.DataAccess;

namespace TiendaVideojuegos.Model
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public int IdRol { get; set; }
        public string NombreUsuario { get; set; }
        public string UserName { get; set; }
        public string PasswordUser { get; set; }
    }
}
