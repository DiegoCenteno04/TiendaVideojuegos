using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVideojuegos.View
{
    public partial class menuEmpleado : Form
    {
        public menuEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosEmpleados productosEmpleados = new ProductosEmpleados();
            productosEmpleados.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Detalle_Venta detalle_Venta = new Detalle_Venta();
            detalle_Venta.Show();
            this.Hide();
        }
    }
}
