using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.Model;
using System.Data; // Necesario para DataTable
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TiendaVideojuegos.DataAccess
{
    public class ClienteDAO
    {
        private readonly string connectionString;

        public ClienteDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AgregarCliente(Cliente nuevoCliente)
        {
            string query = @"INSERT INTO Clientes (IdCliente, Nombre, Apellido, Telefono, CorreoElectronico, Direccion)
                             VALUES (@Id, @Nombre, @Apellido, @Telefono, @Correo, @Direccion)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Agrega los parámetros para la inserción
                    cmd.Parameters.AddWithValue("@Id", nuevoCliente.Id);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", nuevoCliente.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", nuevoCliente.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", nuevoCliente.Direccion);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta la inserción

                    return rowsAffected > 0; // Retorna true si se insertó al menos una fila
                }
            }
            catch (SqlException ex)
            {
                // *** CAMBIO AQUÍ: Muestra cualquier otro error directamente ***
                // *** CAMBIO AQUÍ: Muestra el mensaje de error de SQL Server directamente ***
                MessageBox.Show("Error de base de datos en DAO: " + ex.Message + "\nCódigo de error: " + ex.Number, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("SQL Error (DAO): " + ex.ToString()); // Para ver el stack trace completo
                return false;
            }
            catch (Exception ex)
            {
                // *** CAMBIO AQUÍ: Muestra cualquier otro error directamente ***
                MessageBox.Show("Error inesperado en DAO: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("General Error (DAO): " + ex.ToString()); // Para ver el stack trace completo
                return false;
            }

        }
    }
}
