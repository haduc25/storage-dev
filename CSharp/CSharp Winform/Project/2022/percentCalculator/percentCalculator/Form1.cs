namespace percentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double percent = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
               double numb1 = Convert.ToDouble(textBox1.Text.Trim());
               double numb2 = Convert.ToDouble(textBox2.Text.Trim());
               percent = ((numb1 * 100) / numb2);
            }
            textBox3.Text = percent.ToString();
        }
    }
}