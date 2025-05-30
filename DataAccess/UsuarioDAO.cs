using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.DataAccess
{
    internal class UsuarioDAO
    {
        private readonly string connectionString;

        public UsuarioDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private readonly ConexionBDD conexion;

        public Usuario validarlogign(string username, string password)
        {
            Usuario user = null;

            string query = @"SELECT IdUsuario, IdRol, NombreUsuario, UserName, ContrasenaUsuario
                        FROM Usuarios
                        WHERE UserName = @username AND ContrasenaUsuario = @password";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Usuario()
                        {
                            IdUser = Convert.ToInt32(reader["IdUsuario"]),
                            IdRol = Convert.ToInt32(reader["IdRol"]),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            UserName = reader["UserName"].ToString(),
                            PasswordUser = reader["ContrasenaUsuario"].ToString()
                        };
                    }
                    
                }
            }
            }
            catch(Exception ex) {
                Console.WriteLine("Error en validacion" + ex.Message);
            }
            return user;
        }
    }
}
