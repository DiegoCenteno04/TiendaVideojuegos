using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TiendaVideojuegos.Model;
using System.Data; // Necesario para DataTable
using System.Windows.Forms;

namespace TiendaVideojuegos.DataAccess
{
    public class ProveedorDAO
    {
        private readonly string connectionString;

        public ProveedorDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AgregarProveedor(Proveedor nuevoProveedor)
        {
            string query = @"INSERT INTO Proveedores (IdProveedor, NombreProveedor, Telefono, CorreoElectronico, Direccion)
                             VALUES (@Id, @Nombre, @Telefono, @Correo, @Direccion)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Agrega los parámetros para la inserción
                    cmd.Parameters.AddWithValue("@Id", nuevoProveedor.Id);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoProveedor.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoProveedor.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", nuevoProveedor.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", nuevoProveedor.Direccion);

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
