using System;
using System.Collections.Generic;
using System.Data; // Necesario para DataTable
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.DataAccess
{
    public class EmpleadoDAO
    {
        private readonly string connectionString;

        public EmpleadoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AgregarEmpleado(Empleado nuevoEmpleado)
        {
            string query = @"INSERT INTO Empleados (IdEmpleado,IdCargo, IdEstadoEmpleado,  Nombre, Apellido, Telefono, CorreoElectronico)
                             VALUES (@Id1, @Id2, @Id3, @Nombre, @Apellido, @Telefono, @Correo)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Agrega los parámetros para la inserción
                    cmd.Parameters.AddWithValue("@Id1", nuevoEmpleado.Id1);
                    cmd.Parameters.AddWithValue("@Id2", nuevoEmpleado.Id2);
                    cmd.Parameters.AddWithValue("@Id3", nuevoEmpleado.Id3);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", nuevoEmpleado.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", nuevoEmpleado.Correo);
                   

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
