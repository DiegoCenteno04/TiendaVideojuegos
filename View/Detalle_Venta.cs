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

    public partial class Detalle_Venta : Form
    {
        SqlConnection conex = new SqlConnection("Server=localhost;Database=TiendaVideojuegos;User Id=Administrador;Password=Admin123;");
        SqlDataAdapter adapt;
        public Detalle_Venta()
        {
            InitializeComponent();
            ObtenerRegistro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuEmpleado menu = new menuEmpleado();
            menu.Show();
            this.Hide();
        }

        private void ObtenerRegistro()
        {
            conex.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select*from DetalleVentas", conex);
            adapt.Fill(dt);
            tabladetalle.DataSource = dt;
            conex.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtID.Text.Trim());
            int Id2 = int.Parse(txtID2.Text.Trim());
            int Id3 = int.Parse((txtID3.Text.Trim()));
            string cantidad = txtCantidad.Text.Trim();
            string subtotal = txtSub.Text.Trim();
            

            if (string.IsNullOrWhiteSpace(cantidad) || string.IsNullOrWhiteSpace(subtotal))
            {
                MessageBox.Show("El título y el género no pueden estar vacíos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Detalle nuevoDetalle = new Detalle
            {
                Id = Id,
                Id2 = Id2,
                Id3 = Id3,
                Cantidad = cantidad,
                Subtotal = subtotal
            };

            try
            {

                // 3. Obtener la cadena de conexión
                // Reutilizamos la lógica de ConexionBDD para obtener la connection string
                ConexionBDD conexion = new ConexionBDD();
                string connectionString = conexion.GetConnection().ConnectionString;

                // 4. Crear una instancia del Controlador
                DetalleControllers controller = new DetalleControllers(connectionString);

                // 5. Llamar al método del controlador para agregar el videojuego
                bool agregadoExitosamente = controller.AgregarNuevoDetalle(nuevoDetalle);

                if (agregadoExitosamente)
                {
                    MessageBox.Show("proveedor agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Opcional: Limpiar los campos después de agregar
                    txtID.Clear();
                    txtID2.Clear();
                    txtID3.Clear();
                    txtCantidad.Clear();
                    txtSub.Clear();

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
    }
}
