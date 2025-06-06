namespace TiendaVideojuegos.View
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            txtimagen = new TextBox();
            label6 = new Label();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            label5 = new Label();
            label2 = new Label();
            txtdescripcion = new TextBox();
            txtnombre = new TextBox();
            txtID4 = new TextBox();
            txtID3 = new TextBox();
            txtID2 = new TextBox();
            txtID = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            tablaproducto = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaproducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.BackgroundImage = Properties.Resources._49754;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-2, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(562, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 45);
            label1.TabIndex = 9;
            label1.Text = "Productos";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(3, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(97, 80);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(txtimagen);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtcantidad);
            panel2.Controls.Add(txtprecio);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtdescripcion);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(txtID4);
            panel2.Controls.Add(txtID3);
            panel2.Controls.Add(txtID2);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(-2, 74);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 448);
            panel2.TabIndex = 1;
            // 
            // txtimagen
            // 
            txtimagen.Location = new Point(200, 406);
            txtimagen.Margin = new Padding(3, 2, 3, 2);
            txtimagen.Name = "txtimagen";
            txtimagen.Size = new Size(232, 23);
            txtimagen.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(86, 406);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 52;
            label6.Text = "Imagen: ";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(200, 365);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(232, 23);
            txtcantidad.TabIndex = 51;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(200, 331);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(232, 23);
            txtprecio.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(86, 369);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 49;
            label5.Text = "Cantidad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(108, 335);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 48;
            label2.Text = "Precio: ";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(200, 292);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(232, 23);
            txtdescripcion.TabIndex = 47;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(200, 245);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(232, 23);
            txtnombre.TabIndex = 46;
            // 
            // txtID4
            // 
            txtID4.Location = new Point(200, 192);
            txtID4.Margin = new Padding(3, 2, 3, 2);
            txtID4.Name = "txtID4";
            txtID4.Size = new Size(232, 23);
            txtID4.TabIndex = 45;
            // 
            // txtID3
            // 
            txtID3.Location = new Point(200, 142);
            txtID3.Margin = new Padding(3, 2, 3, 2);
            txtID3.Name = "txtID3";
            txtID3.Size = new Size(232, 23);
            txtID3.TabIndex = 44;
            // 
            // txtID2
            // 
            txtID2.Location = new Point(200, 91);
            txtID2.Margin = new Padding(3, 2, 3, 2);
            txtID2.Name = "txtID2";
            txtID2.Size = new Size(232, 23);
            txtID2.TabIndex = 43;
            // 
            // txtID
            // 
            txtID.Location = new Point(200, 33);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(232, 23);
            txtID.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(47, 146);
            label10.Name = "label10";
            label10.Size = new Size(128, 19);
            label10.TabIndex = 41;
            label10.Text = "IdPlataforma: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(48, 91);
            label9.Name = "label9";
            label9.Size = new Size(117, 19);
            label9.TabIndex = 40;
            label9.Text = "IdCategoria: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 37);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 36;
            label3.Text = "IdProductos: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(62, 291);
            label8.Name = "label8";
            label8.Size = new Size(113, 19);
            label8.TabIndex = 39;
            label8.Text = "Descripcion: ";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(17, 249);
            label4.Name = "label4";
            label4.Size = new Size(162, 19);
            label4.TabIndex = 37;
            label4.Text = "Nombre Producto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(17, 196);
            label7.Name = "label7";
            label7.Size = new Size(175, 19);
            label7.TabIndex = 38;
            label7.Text = "IdEstado Producto : ";
            // 
            // tablaproducto
            // 
            tablaproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaproducto.Location = new Point(600, 114);
            tablaproducto.Margin = new Padding(3, 2, 3, 2);
            tablaproducto.Name = "tablaproducto";
            tablaproducto.RowHeadersWidth = 51;
            tablaproducto.Size = new Size(455, 287);
            tablaproducto.TabIndex = 2;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._1486564412_plus_81511;
            button2.Location = new Point(600, 409);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 59);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(863, 423);
            button3.Name = "button3";
            button3.Size = new Size(160, 46);
            button3.TabIndex = 15;
            button3.Text = "     Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 519);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tablaproducto);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Productos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaproducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private TextBox txtdescripcion;
        private TextBox txtnombre;
        private TextBox txtID4;
        private TextBox txtID3;
        private TextBox txtID2;
        private TextBox txtID;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label8;
        private Label label4;
        private Label label7;
        private DataGridView tablaproducto;
        private Label label1;
        private Button button2;
        private TextBox txtcantidad;
        private TextBox txtprecio;
        private Label label5;
        private Label label2;
        private TextBox txtimagen;
        private Label label6;
        private Button button3;
    }
}