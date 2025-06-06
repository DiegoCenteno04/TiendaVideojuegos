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
    public partial class ProductosEmpleados : Form
    {
        SqlConnection conex = new SqlConnection("Server=localhost;Database=TiendaVideojuegos;User Id=Administrador;Password=Admin123;");
        SqlDataAdapter adapt;
        public ProductosEmpleados()
        {
            InitializeComponent();
            ObtenerRegistro();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(imagen))
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
    }
}
