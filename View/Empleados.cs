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


namespace app_TiendaVideojuegos
{
    public partial class Empleados : Form
    {
        SqlConnection conex = new SqlConnection("Server=localhost;Database=TiendaVideojuegos;User Id=Administrador;Password=Admin123;");
        SqlDataAdapter adapt;
        DataTable dtVentas = new DataTable();
        public Empleados()
        {
            InitializeComponent();
            ObtenerRegistro();
            tablaempleados.CellClick += tablaempleado_CellClick;
        }

        private void tablaempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que el clic fue en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tablaempleados.Rows[e.RowIndex];

                // Carga los datos de la fila en tus TextBoxes.
                // Los nombres de las columnas DEBEN COINCIDIR con los nombres de las columnas en tu SELECT de ObtenerRegistro().
                // Por ejemplo, si tu columna en la DB se llama 'IdVenta', úsala aquí.

                txtID.Text = row.Cells["IdEmpleado"].Value.ToString(); // Asumo que IdVenta es el ID principal
                txtID2.Text = row.Cells["IdCargo"].Value.ToString(); // Asumo que IdCliente
                txtID3.Text = row.Cells["IdEstadoEmpleado"].Value.ToString(); // Asumo que IdEmpleado
                txtnombre.Text = row.Cells["Nombre"].Value.ToString();
                txtapellido.Text = row.Cells["Apellido"].Value.ToString();// Asumo FechaVenta
                txttelefono.Text = row.Cells["Telefono"].Value.ToString(); // Asumo TotalVenta
                txtcorreo.Text = row.Cells["CorreoElectronico"].Value.ToString(); // Asumo DescuentoVenta

                // Deshabilita el TextBox del ID principal para que no se pueda modificar al actualizar
                // (Opcional, pero recomendado si es una clave primaria autogenerada o inmutable)
                txtID.Enabled = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Hide();
        }

        private void ObtenerRegistro()
        {
            conex.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select*from Empleados", conex);
            adapt.Fill(dt);
            tablaempleados.DataSource = dt;
            conex.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text.Trim());
            int Id2 = int.Parse(txtID2.Text.Trim());
            int Id3 = int.Parse(txtID3.Text.Trim());
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();
            string telefono = txttelefono.Text.Trim();
            string correo = txtcorreo.Text.Trim();
            string direccion = txttelefono.Text.Trim();



            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("El título y el género no pueden estar vacíos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado nuevoEmpleado = new Empleado
            {
                Id1 = Id,
                Id2 = Id2,
                Id3 = Id3,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Correo = correo,

            };

            try
            {

                // 3. Obtener la cadena de conexión
                // Reutilizamos la lógica de ConexionBDD para obtener la connection string
                ConexionBDD conexion = new ConexionBDD();
                string connectionString = conexion.GetConnection().ConnectionString;

                // 4. Crear una instancia del Controlador
                EmpleadoControllers controller = new EmpleadoControllers(connectionString);

                // 5. Llamar al método del controlador para agregar el videojuego
                bool agregadoExitosamente = controller.AgregarNuevoEmpleado(nuevoEmpleado);

                if (agregadoExitosamente)
                {
                    MessageBox.Show("proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Limpiar los campos después de agregar
                    txtID.Clear();
                    txtID2.Clear();
                    txtID3.Clear();
                    txtnombre.Clear();
                    txtapellido.Clear();
                    txttelefono.Clear();
                    txtcorreo.Clear();

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

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Validaciones para IDs (mantienen int.TryParse)
            int idEmpleado;
            if (!int.TryParse(txtID.Text.Trim(), out idEmpleado))
            {
                MessageBox.Show("El ID de Venta es obligatorio y debe ser un número válido para actualizar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCargo;
            if (!int.TryParse(txtID2.Text.Trim(), out idCargo))
            {
                MessageBox.Show("El ID de Cliente debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEstadoEmpleado;
            if (!int.TryParse(txtID3.Text.Trim(), out idEstadoEmpleado))
            {
                MessageBox.Show("El ID de Empleado debe ser un número válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            // *** CAMBIOS AQUÍ: Leemos directamente como string ***
            string nombre = txtnombre.Text.Trim();
            string Apellido = txtapellido.Text.Trim();
            string Telefono = txttelefono.Text.Trim();
            string correo = txtcorreo.Text.Trim();

            // Validación de campos obligatorios para strings
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(Apellido) || string.IsNullOrWhiteSpace(Telefono) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("La fecha, el total y el descuento son obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            


            string queryUpdate = @"UPDATE Empleados
                                 SET 
                                     IdCargo = @Idcargo,
                                     IdEstadoEmpleado = @IdEstadoEmpleado,
                                     Nombre = @Nombre,
                                     Apellido = @Apellido,
                                     Telefono = @Telefono,
                                     CorreoElectronico = @CorreoElectronico
                                 WHERE IdEmpleado = @IdEmpleado";

            try
            {
                using (SqlCommand cmd = new SqlCommand(queryUpdate, conex))
                {
                    cmd.Parameters.AddWithValue("@IdCargo", idCargo);
                    cmd.Parameters.AddWithValue("@IdEstadoEmpleado", idEstadoEmpleado);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    // *** CAMBIOS AQUÍ: Pasamos los strings directamente a los parámetros SQL ***
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", correo);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado); // El ID es necesario para el WHERE

                    conex.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Venta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Clear();
                        txtID2.Clear();
                        txtID3.Clear();
                        txtnombre.Clear();
                        txtapellido.Clear();
                        txttelefono.Clear();
                        txtcorreo.Enabled = true;

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
