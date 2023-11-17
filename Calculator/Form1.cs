namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            if (textBox1.Text != String.Empty)
            {

            }
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            ketQua = a + b;
            textBox3.Text = ketQua.ToString();
        }
    }
}