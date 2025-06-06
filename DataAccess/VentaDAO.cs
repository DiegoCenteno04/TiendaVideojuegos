using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.Model;
using System.Data.SqlClient;

namespace TiendaVideojuegos.DataAccess
{
    public class VentaDAO
    {
        private readonly string connectionString;

        public VentaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AgregarVenta(Venta nuevoVenta)
        {
            string query = @"INSERT INTO Ventas (IdVenta, IdCliente, IdEmpleado, IdMetodoPago, Fecha, Total, Descuento)
                             VALUES (@Id1, @Id2, @Id3,@Id4, @Fecha, @Total, @Descuento)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Agrega los parámetros para la inserción
                    cmd.Parameters.AddWithValue("@Id1", nuevoVenta.Id1);
                    cmd.Parameters.AddWithValue("@Id2", nuevoVenta.Id2);
                    cmd.Parameters.AddWithValue("@Id3", nuevoVenta.Id3);
                    cmd.Parameters.AddWithValue("@Id4", nuevoVenta.Id4);
                    cmd.Parameters.AddWithValue("@Fecha", nuevoVenta.fecha);
                    cmd.Parameters.AddWithValue("@Total", nuevoVenta.total);
                    cmd.Parameters.AddWithValue("@Descuento", nuevoVenta.descuento);
                    

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
