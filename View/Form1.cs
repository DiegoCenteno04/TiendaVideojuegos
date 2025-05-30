using app_TiendaVideojuegos;
using TiendaVideojuegos.Controllers;
using TiendaVideojuegos.Model;

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

            if(string.IsNullOrWhiteSpace(username)|| string.IsNullOrWhiteSpace(password) ) {
                MessageBox.Show("Por favor, ingrese usuario y contraseña", "Campos Vacios");
            }
            ConexionBDD conexion = new ConexionBDD();
            LoginController controller = new LoginController(conexion.GetConnection().ConnectionString);

            Usuario user = controller.IniciarSecion(username, password);

            if (user != null)
            {
                MessageBox.Show("Boenvenido, "+ user.NombreUsuario + "!");
                menu Menu = new menu();
                Menu.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
