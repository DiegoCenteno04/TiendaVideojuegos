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
            button2 = new Button();
            tablaventa = new DataGridView();
            panel3 = new Panel();
            label8 = new Label();
            txtdescuento = new TextBox();
            label4 = new Label();
            txttotal = new TextBox();
            txtfecha = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtID4 = new TextBox();
            label5 = new Label();
            txtID3 = new TextBox();
            label3 = new Label();
            txtID2 = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaventa).BeginInit();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 504);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(tablaventa);
            panel4.Location = new Point(308, 98);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(744, 291);
            panel4.TabIndex = 2;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._1486564412_plus_815111;
            button2.Location = new Point(84, 214);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(188, 64);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tablaventa
            // 
            tablaventa.BackgroundColor = SystemColors.ControlLight;
            tablaventa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaventa.Location = new Point(29, 14);
            tablaventa.Margin = new Padding(3, 2, 3, 2);
            tablaventa.Name = "tablaventa";
            tablaventa.RowHeadersWidth = 51;
            tablaventa.Size = new Size(688, 196);
            tablaventa.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtdescuento);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txttotal);
            panel3.Controls.Add(txtfecha);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtID4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtID3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtID2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtID);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 65);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 439);
            panel3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(33, 345);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 14;
            label8.Text = "Descuento:";
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(33, 362);
            txtdescuento.Margin = new Padding(3, 2, 3, 2);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(190, 23);
            txtdescuento.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 286);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "Total:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(32, 303);
            txttotal.Margin = new Padding(3, 2, 3, 2);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(190, 23);
            txttotal.TabIndex = 11;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(32, 248);
            txtfecha.Margin = new Padding(3, 2, 3, 2);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(190, 23);
            txtfecha.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(33, 229);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 9;
            label7.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(33, 172);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 8;
            label6.Text = "IDMetodo de pago:";
            // 
            // txtID4
            // 
            txtID4.Location = new Point(33, 189);
            txtID4.Margin = new Padding(3, 2, 3, 2);
            txtID4.Name = "txtID4";
            txtID4.Size = new Size(189, 23);
            txtID4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(33, 116);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 6;
            label5.Text = "IDEmpleado:";
            // 
            // txtID3
            // 
            txtID3.Location = new Point(33, 134);
            txtID3.Margin = new Padding(3, 2, 3, 2);
            txtID3.Name = "txtID3";
            txtID3.Size = new Size(189, 23);
            txtID3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 64);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "IDCliente:";
            // 
            // txtID2
            // 
            txtID2.Location = new Point(33, 81);
            txtID2.Margin = new Padding(3, 2, 3, 2);
            txtID2.Name = "txtID2";
            txtID2.Size = new Size(189, 23);
            txtID2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 13);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "IDVenta:";
            // 
            // txtID
            // 
            txtID.Location = new Point(33, 30);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(189, 23);
            txtID.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 65);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.ForeColor = Color.DarkRed;
            button1.Image = Properties.Resources.return_up_back_icon_234820;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(92, 65);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(505, 14);
            label1.Name = "label1";
            label1.Size = new Size(113, 39);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(401, 222);
            button3.Name = "button3";
            button3.Size = new Size(160, 46);
            button3.TabIndex = 14;
            button3.Text = "     Actualizar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 478);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ventas";
            Text = "Editor_Productos";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaventa).EndInit();
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
        private DataGridView tablaventa;
        private Button button1;
        private Label label1;
        private Label label3;
        private TextBox txtID2;
        private Label label2;
        private TextBox txtID;
        private TextBox txtfecha;
        private Label label7;
        private Label label6;
        private TextBox txtID4;
        private Label label5;
        private TextBox txtID3;
        private Button button2;
        private Label label4;
        private TextBox txttotal;
        private Label label8;
        private TextBox txtdescuento;
        private Button button3;
    }
}