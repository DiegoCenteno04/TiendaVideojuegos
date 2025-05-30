using System;
using System.Data.SqlClient;
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

        // Elimina esta línea, ya no se usa ni inicializa.
        // private readonly ConexionBDD conexion;

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

                    conn.Open(); // Aquí se abre la conexión
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
            catch (SqlException ex) // Captura errores específicos de SQL Server
            {
                Console.WriteLine("Error de base de datos en validación: " + ex.Message);
                // Aquí podrías lanzar una excepción personalizada o mostrar un mensaje de error al usuario.
                // Por ahora, al retornar 'null', el formulario mostrará "Usuario o contraseña incorrecta".
                // Para depuración, es útil ver el mensaje completo.
            }
            catch (Exception ex) // Captura cualquier otra excepción
            {
                Console.WriteLine("Error inesperado en validación: " + ex.Message);
            }
            return user;
        }
    }
}