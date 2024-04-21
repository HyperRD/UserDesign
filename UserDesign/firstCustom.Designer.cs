namespace UserDesign
{
    partial class firstCustom
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstCustom));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 52.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(394, 105);
            label1.TabIndex = 0;
            label1.Text = "RD$300";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(78, -204);
            label2.Name = "label2";
            label2.Size = new Size(100, 34);
            label2.TabIndex = 1;
            label2.Text = "Solo a";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(62, 135);
            label3.Name = "label3";
            label3.Size = new Size(326, 65);
            label3.TabIndex = 2;
            label3.Text = "Hamburguesa";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(102, 200);
            label4.Name = "label4";
            label4.Size = new Size(245, 23);
            label4.TabIndex = 3;
            label4.Text = "Con cebolla, tomate y Ketchup";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 239);
            label5.Name = "label5";
            label5.Size = new Size(342, 120);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(430, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 52.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(403, 464);
            label6.Name = "label6";
            label6.Size = new Size(394, 105);
            label6.TabIndex = 6;
            label6.Text = "RD$750\r\n";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(78, 334);
            button1.Name = "button1";
            button1.Size = new Size(291, 37);
            button1.TabIndex = 7;
            button1.Text = "Usar esta plantilla";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(445, 447);
            label7.Name = "label7";
            label7.Size = new Size(100, 34);
            label7.TabIndex = 8;
            label7.Text = "Solo a";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(446, 555);
            label8.Name = "label8";
            label8.Size = new Size(322, 65);
            label8.TabIndex = 9;
            label8.Text = "Pizza Grande";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Fluent Icons", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveBorder;
            label9.Location = new Point(464, 620);
            label9.Name = "label9";
            label9.Size = new Size(270, 23);
            label9.TabIndex = 10;
            label9.Text = "Con peperoni y bordes con queso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 671);
            label10.Name = "label10";
            label10.Size = new Size(342, 120);
            label10.TabIndex = 11;
            label10.Text = resources.GetString("label10.Text");
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(443, 776);
            button2.Name = "button2";
            button2.Size = new Size(291, 37);
            button2.TabIndex = 12;
            button2.Text = "Usar esta plantilla";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 513);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(375, 331);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 844);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 29);
            panel1.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(62, 24);
            label11.Name = "label11";
            label11.Size = new Size(100, 34);
            label11.TabIndex = 15;
            label11.Text = "Solo a";
            // 
            // firstCustom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "firstCustom";
            Size = new Size(799, 363);
            Load += firstCustom_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label11;
    }
}
