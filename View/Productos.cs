using app_TiendaVideojuegos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaVideojuegos.Controllers;
using TiendaVideojuegos.Model;
using System.Data.SqlClient;


namespace TiendaVideojuegos.View
{
    public partial class Productos : Form
    {
        SqlConnection conex = new SqlConnection("Server=localhost;Database=TiendaVideojuegos;User Id=Administrador;Password=Admin123;");
        SqlDataAdapter adapt;
        DataTable dtVentas = new DataTable();
        public Productos()
        {
            InitializeComponent();
            ObtenerRegistro();
            tablaproducto.CellClick += tablaproducto_CellClick;
        }

        private void tablaproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que el clic fue en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tablaproducto.Rows[e.RowIndex];

                // Carga los datos de la fila en tus TextBoxes.
                // Los nombres de las columnas DEBEN COINCIDIR con los nombres de las columnas en tu SELECT de ObtenerRegistro().
                // Por ejemplo, si tu columna en la DB se llama 'IdVenta', úsala aquí.

                txtID.Text = row.Cells["IdProducto"].Value.ToString(); // Asumo que IdVenta es el ID principal
                txtID2.Text = row.Cells["IdCategoria"].Value.ToString(); // Asumo que IdCliente
                txtID3.Text = row.Cells["IdPlataforma"].Value.ToString(); // Asumo que IdEmpleado
                txtID4.Text = row.Cells["IdEstadoProducto"].Value.ToString();
                txtnombre.Text = row.Cells["NombreProducto"].Value.ToString();// Asumo FechaVenta
                txtdescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtprecio.Text = row.Cells["PrecioUnitario"].Value.ToString();
                txtcantidad.Text = row.Cells["Cantidad"].Value.ToString();
                txtimagen.Text = row.Cells["Imagen"].Value.ToString(); // Asumo TotalVenta
                // Asumo DescuentoVenta

                // Deshabilita el TextBox del ID principal para que no se pueda modificar al actualizar
                // (Opcional, pero recomendado si es una clave primaria autogenerada o inmutable)
                txtID.Enabled = false;
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void ObtenerRegistro()
        {
            conex.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select*from Productos", conex);
            adapt.Fill(dt);
            tablaproducto.DataSource = dt;
            conex.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text.Trim());
            int Id2 = int.Parse(txtID2.Text.Trim());
            int Id3 = int.Parse(txtID3.Text.Trim());
            int Id4 = int.Parse(txtID4.Text.Trim());
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string precio = txtprecio.Text.Trim();
            int cantidad = int.Parse(txtcantidad.Text.Trim());
            string imagen = txtimagen.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(precio) || string.IsNullOrWhiteSpace(imagen))
            {
                MessageBox.Show("El título y el género no pueden estar vacíos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto nuevoProducto = new Producto
            {
                Id1 = Id,
                Id2 = Id2,
                Id3 = Id3,
                Id4 = Id4,
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Cantidad = cantidad,
                imagen = imagen
            };

            try
            {

                // 3. Obtener la cadena de conexión
                // Reutilizamos la lógica de ConexionBDD para obtener la connection string
                ConexionBDD conexion = new ConexionBDD();
                string connectionString = conexion.GetConnection().ConnectionString;

                // 4. Crear una instancia del Controlador
                ProductoControllers controller = new ProductoControllers(connectionString);

                // 5. Llamar al método del controlador para agregar el videojuego
                bool agregadoExitosamente = controller.AgregarNuevoProducto(nuevoProducto);

                if (agregadoExitosamente)
                {
                    MessageBox.Show("proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Limpiar los campos después de agregar
                    txtID.Clear();
                    txtID2.Clear();
                    txtID3.Clear();
                    txtID4.Clear();
                    txtnombre.Clear();
                    txtdescripcion.Clear();
                    txtprecio.Clear();
                    txtcantidad.Clear();
                    txtimagen.Clear();

                    ObtenerRegistro();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el proveedor. Verifique los datos o la conexión a la base de datos.", "Error al Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (FormatException)
            {
                // Este catch es específico para errores de conversión de texto a número (ej. Id)
                MessageBox.Show("El ID debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Este catch general mostrará cualquier otra excepción.
                // Es crucial para la depuración.
                MessageBox.Show("Ocurrió un error inesperado al agregar el proveedor: " + ex.Message, "Error Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // También imprime en la ventana de Salida de Visual Studio (Output window)
                Console.WriteLine("Error DETALLADO: " + ex.ToString());// Para ver el stack trace completo en la ventana de Salida
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idproducto;
            if (!int.TryParse(txtID.Text.Trim(), out idproducto))
            {
                MessageBox.Show("El ID de Venta es obligatorio y debe ser un número válido para actualizar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCategoria;
            if (!int.TryParse(txtID2.Text.Trim(), out idCategoria))
            {
                MessageBox.Show("El ID de Venta es obligatorio y debe ser un número válido para actualizar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPlataforma;
            if (!int.TryParse(txtID3.Text.Trim(), out idPlataforma))
            {
                MessageBox.Show("El ID de Venta es obligatorio y debe ser un número válido para actualizar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstado;
            if (!int.TryParse(txtID4.Text.Trim(), out idEstado))
            {
                MessageBox.Show("El ID de Venta es obligatorio y debe ser un número válido para actualizar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // *** CAMBIOS AQUÍ: Leemos directamente como string ***
            string nombre = txtnombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string precio = txtprecio.Text.Trim();
            string cantidad = txtcantidad.Text.Trim();
            string imagen = txtimagen.Text.Trim();

            // Validación de campos obligatorios para strings
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(precio) || string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(imagen))
            {
                MessageBox.Show("La fecha, el total y el descuento son obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            string queryUpdate = @"UPDATE Productos
                                 SET 
                                     IdCategoria = @IdCategoria,
                                     IdPlataforma = @IdPlataforma,
                                     IdEstadoProducto = @IdEstadoProducto,
                                     NombreProducto = @NombreProducto,
                                     Descripcion = @Descripcion,
                                     PrecioUnitario = @PrecioUnitario,
                                     Cantidad = @Cantidad,
                                     Imagen = @Imagen
                                 WHERE IdProducto = @IdProducto";

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryUpdate, conex))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idproducto);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("@IdPlataforma", idPlataforma);
                    cmd.Parameters.AddWithValue("@IdEstadoProducto", idEstado);
                    cmd.Parameters.AddWithValue("@NombreProducto", nombre);
                    // *** CAMBIOS AQUÍ: Pasamos los strings directamente a los parámetros SQL ***
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", precio);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Imagen", imagen); // El ID es necesario para el WHERE

                    conex.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Venta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID2.Clear();
                        txtID3.Clear();
                        txtID4.Clear();
                        txtnombre.Clear();
                        txtdescripcion.Clear();
                        txtprecio.Clear();
                        txtcantidad.Clear();
                        txtimagen.Clear();
                        txtID.Enabled = true;

                        ObtenerRegistro();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la venta. Asegúrese de que el ID de Venta existe.", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos al actualizar venta: " + ex.Message + "\nCódigo de error: " + ex.Number, "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("SQL Error (Actualizar Venta): " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al actualizar venta: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("General Error (Actualizar Venta): " + ex.ToString());
            }
            finally
            {
                if (conex.State == ConnectionState.Open)
                {
                    conex.Close();
                }
            }
        }

    }
}
