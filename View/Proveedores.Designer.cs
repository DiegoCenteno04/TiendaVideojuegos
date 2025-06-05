
namespace TiendaVideojuegos.View
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            panel1 = new Panel();
            txtdireccion = new TextBox();
            label6 = new Label();
            txtcorreo = new TextBox();
            label5 = new Label();
            txttelefono = new TextBox();
            label4 = new Label();
            txtnombre = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel2 = new Panel();
            button3 = new Button();
            btnagregar = new Button();
            tablaproveedor = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaproveedor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(txtdireccion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtcorreo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txttelefono);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtnombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 86);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 423);
            panel1.TabIndex = 0;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(17, 290);
            txtdireccion.Margin = new Padding(3, 2, 3, 2);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(239, 23);
            txtdireccion.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(19, 272);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 8;
            label6.Text = "Direccion:";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(19, 223);
            txtcorreo.Margin = new Padding(3, 2, 3, 2);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(237, 23);
            txtcorreo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(19, 206);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 6;
            label5.Text = "Correo:";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(19, 158);
            txttelefono.Margin = new Padding(3, 2, 3, 2);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(237, 23);
            txttelefono.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(19, 141);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Telefono:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(19, 98);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(237, 23);
            txtnombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(19, 25);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "IdProveedor:";
            label3.Click += label3_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(17, 43);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(239, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(19, 81);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre de Proveedor:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(991, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 21);
            label1.Name = "label1";
            label1.Size = new Size(177, 45);
            label1.TabIndex = 2;
            label1.Text = "Proveedor";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(97, 89);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnagregar);
            panel2.Controls.Add(tablaproveedor);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(991, 473);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.emblemunreadable_934871;
            button3.Location = new Point(725, 399);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(92, 58);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.Image = Properties.Resources._1486564412_plus_815111;
            btnagregar.Location = new Point(410, 399);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(100, 58);
            btnagregar.TabIndex = 11;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // tablaproveedor
            // 
            tablaproveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaproveedor.Columns.AddRange(new DataGridViewColumn[] { id, nombre, telefono, correo, direccion });
            tablaproveedor.Location = new Point(388, 111);
            tablaproveedor.Margin = new Padding(3, 2, 3, 2);
            tablaproveedor.Name = "tablaproveedor";
            tablaproveedor.RowHeadersWidth = 51;
            tablaproveedor.Size = new Size(533, 270);
            tablaproveedor.TabIndex = 10;
            tablaproveedor.CellContentClick += this.tablaproveedor_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // nombre
            // 
            nombre.HeaderText = "NombreProveedor";
            nombre.Name = "nombre";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 506);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Proveedores";
            Text = "Proveedor";
            Load += Proveedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaproveedor).EndInit();
            ResumeLayout(false);
        }


        private void tablaproveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel2;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Label label4;
        private TextBox txtnombre;
        private TextBox txtdireccion;
        private Label label6;
        private TextBox txtcorreo;
        private Label label5;
        private TextBox txttelefono;
        private Button button3;
        private Button btnagregar;
        private DataGridView tablaproveedor;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn direccion;
    }
}