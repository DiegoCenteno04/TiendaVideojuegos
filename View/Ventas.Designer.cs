namespace TiendaVideojuegos.View
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            panel1 = new Panel();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            IDVenta = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            IDEmpleado = new DataGridViewTextBoxColumn();
            Metodopago = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 562);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(352, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(850, 388);
            panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDVenta, IDCliente, IDEmpleado, Metodopago, Fecha, Total });
            dataGridView1.Location = new Point(31, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 271);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 475);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(43, 15);
            label4.Name = "label4";
            label4.Size = new Size(88, 31);
            label4.TabIndex = 4;
            label4.Text = "Ventas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 136);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "IDCliente:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 68);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "IDVenta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1233, 87);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.ForeColor = Color.DarkRed;
            button1.Image = Properties.Resources.return_up_back_icon_234820;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(105, 87);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(577, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 48);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(33, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 206);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 6;
            label5.Text = "IDEmpleado:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(33, 303);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 280);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 8;
            label6.Text = "IDMetodo de pago:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 356);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 9;
            label7.Text = "Fecha:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(31, 381);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(217, 27);
            textBox5.TabIndex = 10;
            // 
            // IDVenta
            // 
            IDVenta.HeaderText = "IDVenta";
            IDVenta.MinimumWidth = 6;
            IDVenta.Name = "IDVenta";
            IDVenta.Width = 125;
            // 
            // IDCliente
            // 
            IDCliente.HeaderText = "IDCliente";
            IDCliente.MinimumWidth = 6;
            IDCliente.Name = "IDCliente";
            IDCliente.Width = 125;
            // 
            // IDEmpleado
            // 
            IDEmpleado.HeaderText = "IDEmpleado";
            IDEmpleado.MinimumWidth = 6;
            IDEmpleado.Name = "IDEmpleado";
            IDEmpleado.Width = 125;
            // 
            // Metodopago
            // 
            Metodopago.HeaderText = "Metodo pago";
            Metodopago.MinimumWidth = 6;
            Metodopago.Name = "Metodopago";
            Metodopago.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._1486564412_plus_81511;
            button2.Location = new Point(153, 316);
            button2.Name = "button2";
            button2.Size = new Size(67, 69);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.emblemunreadable_934871;
            button3.Location = new Point(401, 316);
            button3.Name = "button3";
            button3.Size = new Size(69, 69);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(628, 316);
            button4.Name = "button4";
            button4.Size = new Size(73, 69);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 566);
            Controls.Add(panel1);
            Name = "Ventas";
            Text = "Editor_Productos";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox5;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn IDVenta;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn IDEmpleado;
        private DataGridViewTextBoxColumn Metodopago;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Total;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}