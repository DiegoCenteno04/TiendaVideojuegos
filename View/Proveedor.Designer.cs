namespace TiendaVideojuegos.View
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel2 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 564);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1133, 119);
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
            label1.Location = new Point(522, 28);
            label1.Name = "label1";
            label1.Size = new Size(219, 54);
            label1.TabIndex = 2;
            label1.Text = "Proveedor";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(111, 119);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1133, 631);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre de Proveedor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "IdProveedor:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(22, 188);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Telefono:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 27);
            textBox3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(22, 274);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 6;
            label5.Text = "Correo:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 297);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 27);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(22, 363);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 8;
            label6.Text = "Direccion:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(19, 386);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(273, 27);
            textBox5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(444, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(609, 360);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._1486564412_plus_815111;
            button2.Location = new Point(468, 532);
            button2.Name = "button2";
            button2.Size = new Size(114, 78);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.emblemunreadable_934871;
            button3.Location = new Point(829, 532);
            button3.Name = "button3";
            button3.Size = new Size(105, 78);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 674);
            Controls.Add(panel2);
            Name = "Proveedor";
            Text = "Proveedor";
            Load += Proveedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}