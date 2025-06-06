using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.Model;
using System.Data.SqlClient;


namespace TiendaVideojuegos.DataAccess
{
    public class ProductoDAO
    {
        private readonly string connectionString;

        public ProductoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AgregarProducto(Producto nuevoProducto)
        {
            string query = @"INSERT INTO Productos (IdProducto, IdCategoria, IdPlataforma, IdEstadoProducto, NombreProducto, Descripcion, PrecioUnitario, Cantidad, Imagen)
                             VALUES (@Id1, @Id2, @Id3,@Id4, @Nombre, @Descripcion, @Precio, @Cantidad, @Imagen)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Agrega los parámetros para la inserción
                    cmd.Parameters.AddWithValue("@Id1", nuevoProducto.Id1);
                    cmd.Parameters.AddWithValue("@Id2", nuevoProducto.Id2);
                    cmd.Parameters.AddWithValue("@Id3", nuevoProducto.Id3);
                    cmd.Parameters.AddWithValue("@Id4", nuevoProducto.Id4);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoProducto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", nuevoProducto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", nuevoProducto.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", nuevoProducto.Cantidad);
                    cmd.Parameters.AddWithValue("@Imagen", nuevoProducto.imagen);

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
