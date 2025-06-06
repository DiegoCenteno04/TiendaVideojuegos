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
            panel1 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            IDVenta = new DataGridViewTextBoxColumn();
            IDCliente = new DataGridViewTextBoxColumn();
            IDEmpleado = new DataGridViewTextBoxColumn();
            Metodopago = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label4 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
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
            panel1.Size = new Size(1233, 565);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(352, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(850, 388);
            panel4.TabIndex = 2;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._1486564412_plus_815111;
            button2.Location = new Point(351, 287);
            button2.Name = "button2";
            button2.Size = new Size(215, 85);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDVenta, IDCliente, IDEmpleado, Metodopago, Fecha, Total });
            dataGridView1.Location = new Point(33, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 262);
            dataGridView1.TabIndex = 0;
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
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 478);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 381);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 12;
            label4.Text = "Total:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(36, 404);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(217, 27);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(36, 330);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(217, 27);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(38, 305);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 9;
            label7.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(38, 229);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 8;
            label6.Text = "IDMetodo de pago:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(38, 252);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(38, 154);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 6;
            label5.Text = "IDEmpleado:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 85);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "IDCliente:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(38, 17);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "IDVenta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
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
            button1.Click += button1_Click;
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
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 565);
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
        private Button button2;
        private Label label4;
        private TextBox textBox6;
    }
}