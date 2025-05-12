namespace app_TiendaVideojuegos
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            IdEmpleado = new DataGridViewTextBoxColumn();
            IdCargo = new DataGridViewTextBoxColumn();
            IdEstadoEmpleado = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(965, 125);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 22);
            label1.Name = "label1";
            label1.Size = new Size(381, 77);
            label1.TabIndex = 4;
            label1.Text = "Empleados";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdEmpleado, IdCargo, IdEstadoEmpleado, Nombre, Apellido, Telefono, Correo });
            dataGridView1.Location = new Point(406, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 321);
            dataGridView1.TabIndex = 2;
            // 
            // IdEmpleado
            // 
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Width = 75;
            // 
            // IdCargo
            // 
            IdCargo.HeaderText = "IdCargo";
            IdCargo.Name = "IdCargo";
            IdCargo.Width = 75;
            // 
            // IdEstadoEmpleado
            // 
            IdEstadoEmpleado.HeaderText = "IdEstadoEmpleado";
            IdEstadoEmpleado.Name = "IdEstadoEmpleado";
            IdEstadoEmpleado.Width = 115;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.Width = 200;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(1, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 509);
            panel2.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(158, 391);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(162, 23);
            textBox7.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(15, 395);
            label10.Name = "label10";
            label10.Size = new Size(75, 19);
            label10.TabIndex = 20;
            label10.Text = "Correo: ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(158, 350);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 23);
            textBox6.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 354);
            label9.Name = "label9";
            label9.Size = new Size(92, 19);
            label9.TabIndex = 18;
            label9.Text = "Telefono: ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(158, 306);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 23);
            textBox5.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 310);
            label8.Name = "label8";
            label8.Size = new Size(87, 19);
            label8.TabIndex = 16;
            label8.Text = "Apellido: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(11, 205);
            label7.Name = "label7";
            label7.Size = new Size(100, 38);
            label7.TabIndex = 15;
            label7.Text = "IdEstado\r\nEmpleado: ";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 220);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 23);
            textBox4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 172);
            label6.Name = "label6";
            label6.Size = new Size(85, 19);
            label6.TabIndex = 13;
            label6.Text = "IdCargo: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(84, 451);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 11;
            button1.Text = "     Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 262);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 266);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 9;
            label4.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(11, 124);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 8;
            label3.Text = "IdEmpleado: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(69, 41);
            label2.Name = "label2";
            label2.Size = new Size(215, 29);
            label2.TabIndex = 6;
            label2.Text = "Añadir Empleado";
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Red;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(69, 521);
            button5.Name = "button5";
            button5.Size = new Size(168, 52);
            button5.TabIndex = 5;
            button5.Text = "      Agregar";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkRed;
            label5.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(552, 164);
            label5.Name = "label5";
            label5.Size = new Size(231, 33);
            label5.TabIndex = 12;
            label5.Text = "Tabla Empleado";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(451, 558);
            button2.Name = "button2";
            button2.Size = new Size(160, 46);
            button2.TabIndex = 13;
            button2.Text = "     Actualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(701, 558);
            button3.Name = "button3";
            button3.Size = new Size(153, 46);
            button3.TabIndex = 14;
            button3.Text = "     Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(25, 22);
            button4.Name = "button4";
            button4.Size = new Size(75, 58);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(964, 634);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Empleados";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button5;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn IdCargo;
        private DataGridViewTextBoxColumn IdEstadoEmpleado;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}