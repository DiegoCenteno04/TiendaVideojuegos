using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace TiendaVideojuegos.DataAccess
{
    internal class conexion
    {
        //Conexion base de datos 
        private static string connectionString = "Server=localhost; Database=; UserId =; Password=;TrustServerCertificate=True";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
