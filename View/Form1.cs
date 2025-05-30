using app_TiendaVideojuegos;
using TiendaVideojuegos.Controllers;
using TiendaVideojuegos.Model;
using System.Windows.Forms;

namespace TiendaVideojuegos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contrase�a", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConexionBDD conexion = new ConexionBDD();
                LoginController controller = new LoginController(conexion.GetConnection().ConnectionString);

                Usuario user = controller.IniciarSecion(username, password);

                if (user != null)
                {
                    MessageBox.Show("Bienvenido, " + user.NombreUsuario + "!", "Inicio de Sesi�n Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- INICIO DE LA L�GICA PARA DETECTAR EL IdRol ---
                    if (user.IdRol == 1) // Si el rol es 1 (Admin)
                    {
                        menu MenuAdmin = new menu(); // Aseg�rate de que 'menu' es el formulario para el admin
                        MenuAdmin.Show();
                    }
                    else if (user.IdRol == 2) // Si el rol es 2 (Empleado/Usuario normal)
                    {
                        // Aseg�rate de que 'menuEmpleado' est� en el namespace correcto (TiendaVideojuegos.View)
                        TiendaVideojuegos.View.menuEmpleado MenuEmpleado = new TiendaVideojuegos.View.menuEmpleado();
                        MenuEmpleado.Show();
                    }
                    else
                    {
                        // Si hay otros roles no contemplados o un IdRol inesperado
                        MessageBox.Show("Tu tipo de rol no est� asignado a un men� espec�fico.", "Rol no reconocido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Opcional: Podr�as redirigirlos a un men� por defecto o mantenerlos en el login.
                        return; // No ocultar el formulario de login si no se redirige.
                    }
                    // --- FIN DE LA L�GICA PARA DETECTAR EL IdRol ---

                    this.Hide(); // Oculta el formulario de login despu�s de abrir el nuevo formulario
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a incorrecta.", "Error de Inicio de Sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error de configuraci�n de la base de datos: " + ex.Message, "Error de Configuraci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurri� un error inesperado al intentar iniciar sesi�n: " + ex.Message, "Error Cr�tico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento vac�o, puedes eliminarlo si no se usa.
        }
    }
}