namespace TiendaVideojuegos.View
{
    partial class ProductosEmpleados
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            txtimagen = new TextBox();
            label10 = new Label();
            txtcantidad = new TextBox();
            label9 = new Label();
            txtprecio = new TextBox();
            label8 = new Label();
            txtdescripcion = new TextBox();
            txtnombre = new TextBox();
            txtID4 = new TextBox();
            txtID3 = new TextBox();
            txtID2 = new TextBox();
            txtID = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            tablaproducto = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaproducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1308, 80);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.Image = Properties.Resources.return_up_back_icon_234820;
            button1.Location = new Point(-2, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 80);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(626, 25);
            label1.Name = "label1";
            label1.Size = new Size(259, 26);
            label1.TabIndex = 0;
            label1.Text = "Productos Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 13);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "IDProducto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 64);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "IDCategoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(33, 116);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 6;
            label5.Text = "IDPlataforma:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(33, 172);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 8;
            label6.Text = "IDEstadoProducto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(33, 229);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 9;
            label7.Text = "NombreProducto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 286);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 12;
            label4.Text = "Descripcion:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(txtimagen);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtcantidad);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtprecio);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtdescripcion);
            panel3.Controls.Add(txtnombre);
            panel3.Controls.Add(txtID4);
            panel3.Controls.Add(txtID3);
            panel3.Controls.Add(txtID2);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 577);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // txtimagen
            // 
            txtimagen.Location = new Point(33, 528);
            txtimagen.Margin = new Padding(3, 2, 3, 2);
            txtimagen.Name = "txtimagen";
            txtimagen.Size = new Size(206, 23);
            txtimagen.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(34, 494);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 21;
            label10.Text = "Imagen:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(32, 459);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(206, 23);
            txtcantidad.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(33, 425);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 19;
            label9.Text = "Cantidad:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(32, 385);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(206, 23);
            txtprecio.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(32, 353);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 17;
            label8.Text = "PrecioUnitario:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(33, 313);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(206, 23);
            txtdescripcion.TabIndex = 16;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(33, 255);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(206, 23);
            txtnombre.TabIndex = 15;
            // 
            // txtID4
            // 
            txtID4.Location = new Point(33, 198);
            txtID4.Margin = new Padding(3, 2, 3, 2);
            txtID4.Name = "txtID4";
            txtID4.Size = new Size(206, 23);
            txtID4.TabIndex = 14;
            // 
            // txtID3
            // 
            txtID3.Location = new Point(33, 141);
            txtID3.Margin = new Padding(3, 2, 3, 2);
            txtID3.Name = "txtID3";
            txtID3.Size = new Size(206, 23);
            txtID3.TabIndex = 13;
            // 
            // txtID2
            // 
            txtID2.Location = new Point(33, 93);
            txtID2.Margin = new Padding(3, 2, 3, 2);
            txtID2.Name = "txtID2";
            txtID2.Size = new Size(206, 23);
            txtID2.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(33, 30);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(206, 23);
            txtID.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(tablaproducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(268, 80);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 577);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._1486564412_plus_81511;
            button2.Location = new Point(84, 472);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 59);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tablaproducto
            // 
            tablaproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaproducto.Location = new Point(19, 64);
            tablaproducto.Margin = new Padding(3, 2, 3, 2);
            tablaproducto.Name = "tablaproducto";
            tablaproducto.RowHeadersWidth = 51;
            tablaproducto.Size = new Size(918, 395);
            tablaproducto.TabIndex = 0;
            // 
            // ProductosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 657);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductosEmpleados";
            Text = "ProductosEmpleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaproducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Panel panel3;
        private Panel panel2;
        private DataGridView tablaproducto;
        private TextBox txtdescripcion;
        private TextBox txtnombre;
        private TextBox txtID4;
        private TextBox txtID3;
        private TextBox txtID2;
        private TextBox txtID;
        private TextBox txtcantidad;
        private Label label9;
        private TextBox txtprecio;
        private Label label8;
        private Button button2;
        private TextBox txtimagen;
        private Label label10;
    }
}