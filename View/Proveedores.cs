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
using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Controllers;
using TiendaVideojuegos.Model;
using System.Data.SqlClient;

namespace TiendaVideojuegos.View
{
    public partial class Proveedores : Form
    {
        SqlConnection conex = new SqlConnection("Server=localhost;Database=TiendaVideojuegos;User Id=Administrador;Password=Admin123;");
        SqlDataAdapter adapt;
        DataTable dtVentas = new DataTable();
        public Proveedores()
        {
            InitializeComponent();
            ObtenerRegistro();
            tablaproveedor.CellClick += tablaproveedor_CellClick;

        }

        private void tablaproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que el clic fue en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tablaproveedor.Rows[e.RowIndex];

                // Carga los datos de la fila en tus TextBoxes.
                // Los nombres de las columnas DEBEN COINCIDIR con los nombres de las columnas en tu SELECT de ObtenerRegistro().
                // Por ejemplo, si tu columna en la DB se llama 'IdVenta', úsala aquí.

                txtId.Text = row.Cells["IdProveedor"].Value.ToString(); // Asumo que IdVenta es el ID principal
                txtnombre.Text = row.Cells["NombreProveedor"].Value.ToString(); // Asumo que IdCliente
                txttelefono.Text = row.Cells["Telefono"].Value.ToString(); // Asumo que IdEmpleado
                txtcorreo.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txtdireccion.Text = row.Cells["Direccion"].Value.ToString();// Asumo FechaVenta
                
                // Asumo DescuentoVenta

                // Deshabilita el TextBox del ID principal para que no se pueda modificar al actualizar
                // (Opcional, pero recomendado si es una clave primaria autogenerada o inmutable)
                txtId.Enabled = false;
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
            adapt = new SqlDataAdapter("select*from Proveedores", conex);
            adapt.Fill(dt);
            tablaproveedor.DataSource = dt;
            conex.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text.Trim());
            string nombre = txtnombre.Text.Trim();
            string telefono = txttelefono.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string direccion = txtdireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("El título y el género no pueden estar vacíos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Proveedor nuevoProveedor = new Proveedor
            {
                Id = Id,
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo,
                Direccion = direccion
            };

            try
            {

                // 3. Obtener la cadena de conexión
                // Reutilizamos la lógica de ConexionBDD para obtener la connection string
                ConexionBDD conexion = new ConexionBDD();
                string connectionString = conexion.GetConnection().ConnectionString;

                // 4. Crear una instancia del Controlador
                ProveedorControllers controller = new ProveedorControllers(connectionString);

                // 5. Llamar al método del controlador para agregar el videojuego
                bool agregadoExitosamente = controller.AgregarNuevoProveedor(nuevoProveedor);

                if (agregadoExitosamente)
                {
                    MessageBox.Show("proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Limpiar los campos después de agregar
                    txtId.Clear();
                    txtnombre.Clear();
                    txttelefono.Clear();
                    txtcorreo.Clear();
                    txtdireccion.Clear();

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
            int idProveedor;
            if (!int.TryParse(txtId.Text.Trim(), out idProveedor))
            {
                MessageBox.Show("El ID de Venta es obligatorio y debe ser un número válido para actualizar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // *** CAMBIOS AQUÍ: Leemos directamente como string ***
            string nombre = txtnombre.Text.Trim();
            string Telefono = txttelefono.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string direccion = txtdireccion.Text.Trim();

            // Validación de campos obligatorios para strings
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(Telefono) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("La fecha, el total y el descuento son obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            string queryUpdate = @"UPDATE Proveedores
                                 SET 
                                     
                                     NombreProveedor = @NombreProveedor,
                                     Telefono = @Telefono,
                                     CorreoElectronico = @CorreoElectronico,
                                     Direccion = @Direccion
                                 WHERE IdProveedor = @IdProveedor";

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryUpdate, conex))
                {
                    cmd.Parameters.AddWithValue("@Idproveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@NombreProveedor", nombre);
                    // *** CAMBIOS AQUÍ: Pasamos los strings directamente a los parámetros SQL ***
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                    cmd.Parameters.AddWithValue("@Direccion", direccion); // El ID es necesario para el WHERE

                    conex.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Venta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnombre.Clear();
                        txttelefono.Clear();
                        txtcorreo.Clear();
                        txtdireccion.Clear();
                        txtId.Enabled = true;

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
