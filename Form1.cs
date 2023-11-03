namespace U3_Practica_3
{
    public partial class Form1 : Form
    {
        float num, Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);

            num = float.Parse(textBox1.Text);
            Total += num;
            textBox1.Clear();
            textBox1.Focus();

        }
    }
}