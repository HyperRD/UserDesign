namespace UserDesign
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            slidePanel = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            button7 = new Button();
            home1 = new Home();
            salon1 = new salon();
            barber1 = new barber();
            firstCustom1 = new firstCustom();
            tienda1 = new Tienda();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(slidePanel);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 602);
            panel1.TabIndex = 0;
            // 
            // slidePanel
            // 
            slidePanel.BackColor = Color.FromArgb(192, 0, 0);
            slidePanel.Location = new Point(3, 100);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(10, 56);
            slidePanel.TabIndex = 4;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 348);
            button5.Name = "button5";
            button5.Size = new Size(212, 56);
            button5.TabIndex = 4;
            button5.Text = "Tienda";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(12, 286);
            button4.Name = "button4";
            button4.Size = new Size(215, 56);
            button4.TabIndex = 3;
            button4.Text = "Comida";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 224);
            button3.Name = "button3";
            button3.Size = new Size(215, 56);
            button3.TabIndex = 2;
            button3.Text = "Barberia";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 162);
            button2.Name = "button2";
            button2.Size = new Size(212, 56);
            button2.TabIndex = 1;
            button2.Text = "Salon";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(19, 100);
            button1.Name = "button1";
            button1.Size = new Size(202, 56);
            button1.TabIndex = 0;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(224, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 16);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 0, 0);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(329, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 155);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 97);
            label1.Name = "label1";
            label1.Size = new Size(89, 36);
            label1.TabIndex = 0;
            label1.Text = "Gaps";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(474, 22);
            label2.Name = "label2";
            label2.Size = new Size(387, 51);
            label2.TabIndex = 3;
            label2.Text = "Gestor de plantillas ";
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(1058, 30);
            button8.Name = "button8";
            button8.Size = new Size(37, 33);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(1015, 30);
            button7.Name = "button7";
            button7.Size = new Size(37, 33);
            button7.TabIndex = 5;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // home1
            // 
            home1.BackColor = Color.White;
            home1.Location = new Point(224, 162);
            home1.Name = "home1";
            home1.Size = new Size(859, 400);
            home1.TabIndex = 7;
            // 
            // salon1
            // 
            salon1.Location = new Point(224, 162);
            salon1.Name = "salon1";
            salon1.Size = new Size(875, 440);
            salon1.TabIndex = 8;
            // 
            // barber1
            // 
            barber1.Location = new Point(224, 162);
            barber1.Name = "barber1";
            barber1.Size = new Size(890, 430);
            barber1.TabIndex = 9;
            // 
            // firstCustom1
            // 
            firstCustom1.AutoScroll = true;
            firstCustom1.Location = new Point(224, 162);
            firstCustom1.Name = "firstCustom1";
            firstCustom1.Size = new Size(859, 417);
            firstCustom1.TabIndex = 10;
            // 
            // tienda1
            // 
            tienda1.Location = new Point(224, 159);
            tienda1.Name = "tienda1";
            tienda1.Size = new Size(900, 420);
            tienda1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1126, 602);
            Controls.Add(tienda1);
            Controls.Add(firstCustom1);
            Controls.Add(barber1);
            Controls.Add(salon1);
            Controls.Add(home1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Panel slidePanel;
        private Button button8;
        private Button button7;
        private Home home1;
        private salon salon1;
        private barber barber1;
        private firstCustom firstCustom1;
        private Tienda tienda1;
    }
}
