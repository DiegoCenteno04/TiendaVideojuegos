using TiendaVideojuegos.View;

namespace app_TiendaVideojuegos
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConexionBDD connection = new ConexionBDD();
            var conn = connection.GetConnection();

            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Proveedores provee = new Proveedores();
            provee.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
