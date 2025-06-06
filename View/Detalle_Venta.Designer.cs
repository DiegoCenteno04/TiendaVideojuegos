namespace TiendaVideojuegos.View
{
    partial class Detalle_Venta
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
            panel2 = new Panel();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSub = new TextBox();
            txtCantidad = new TextBox();
            txtID3 = new TextBox();
            txtID2 = new TextBox();
            txtID = new TextBox();
            panel3 = new Panel();
            tabladetalle = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabladetalle).BeginInit();
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
            panel1.Size = new Size(975, 80);
            panel1.TabIndex = 0;
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
            label1.Location = new Point(446, 25);
            label1.Name = "label1";
            label1.Size = new Size(213, 26);
            label1.TabIndex = 0;
            label1.Text = "Detalle De Ventas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSub);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(txtID3);
            panel2.Controls.Add(txtID2);
            panel2.Controls.Add(txtID);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 374);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._1486564412_plus_81511;
            button2.Location = new Point(74, 297);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(175, 71);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(39, 242);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 9;
            label6.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(45, 193);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(39, 136);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "ID Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(39, 79);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "ID Venta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(39, 26);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 5;
            label2.Text = "ID Detalle De Venta:";
            // 
            // txtSub
            // 
            txtSub.Location = new Point(39, 259);
            txtSub.Margin = new Padding(3, 2, 3, 2);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(235, 23);
            txtSub.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(42, 210);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(232, 23);
            txtCantidad.TabIndex = 3;
            // 
            // txtID3
            // 
            txtID3.Location = new Point(39, 153);
            txtID3.Margin = new Padding(3, 2, 3, 2);
            txtID3.Name = "txtID3";
            txtID3.Size = new Size(235, 23);
            txtID3.TabIndex = 2;
            // 
            // txtID2
            // 
            txtID2.Location = new Point(39, 96);
            txtID2.Margin = new Padding(3, 2, 3, 2);
            txtID2.Name = "txtID2";
            txtID2.Size = new Size(235, 23);
            txtID2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(39, 43);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(235, 23);
            txtID.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(tabladetalle);
            panel3.Location = new Point(346, 106);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(605, 292);
            panel3.TabIndex = 2;
            // 
            // tabladetalle
            // 
            tabladetalle.BackgroundColor = SystemColors.ButtonFace;
            tabladetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabladetalle.Location = new Point(19, 22);
            tabladetalle.Margin = new Padding(3, 2, 3, 2);
            tabladetalle.Name = "tabladetalle";
            tabladetalle.RowHeadersWidth = 51;
            tabladetalle.Size = new Size(564, 247);
            tabladetalle.TabIndex = 0;
            // 
            // Detalle_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 454);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Detalle_Venta";
            Text = "Detalle_Venta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabladetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSub;
        private TextBox txtCantidad;
        private TextBox txtID3;
        private TextBox txtID2;
        private TextBox txtID;
        private Panel panel3;
        private DataGridView tabladetalle;
        private Button button1;
        private Button button2;
    }
}