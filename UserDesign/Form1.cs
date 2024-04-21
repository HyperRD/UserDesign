namespace UserDesign
{
    public partial class Form1 : Form
    {

        public Color? ColorFondo { get; private set; }
        public float? TamanoTexto { get; private set; }
        public string TipoLetra { get; private set; }


        public Form1()
        {
            InitializeComponent();
            slidePanel.Height = button1.Height;
            slidePanel.Top = button1.Top;
            home1.BringToFront();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            slidePanel.Height = button2.Height;
            slidePanel.Top = button2.Top;
            salon1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            slidePanel.Height = button5.Height;
            slidePanel.Top = button5.Top;
            tienda1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidePanel.Height = button1.Height;
            slidePanel.Top = button1.Top;
            home1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidePanel.Height = button3.Height;
            slidePanel.Top = button3.Top;
            barber1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidePanel.Height = button4.Height;
            slidePanel.Top = button4.Top;
            firstCustom1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string mensaje = "Trabajadores del proyecto:\n\n" +
                "1. Julio Batista\n" +
                "2. Junior Cedeño\n" +
                "3. Brawly Luribel";

            MessageBox.Show(mensaje, "Trabajadores del Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
