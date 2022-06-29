using System;
using System.Linq;
using System.Windows.Forms;

namespace RandCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        void Randcode(int Hello)
        {
            Random rand = new Random();
            char[] letters = "qwertyuioplkjhgfdsazxcvbnmMNBVCXZASDFGHJKLPOIUYTREWQ0123456789".ToArray();
            string output;
            output = null;
            for (int i = 0; i < Hello; i++)
            {
                output += letters[rand.Next(0,letters.Length)];
            }
            textBox1.Text = output;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            button3.Text = "Copy";
            lbClick.Text = ("Click: "+a.ToString());
            int Value = 0;
            if(Int32.TryParse(textBox2.Text,out Value))
            {
                textBox2.Text = Value.ToString();
            }
            else
            {
                a--;
                lbClick.Text = "ERROR";
                textBox2.Text = "Number !";
            }
            Randcode(Value);
        }
        void Rand1() 
        {
            Random rand1 = new Random();
            int result = rand1.Next(50000000,100000000);
            textBox4.Text = ""+result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rand1();
        }

        private void lbClick_Click(object sender, EventArgs e)
        {
            a = 0;
            lbClick.Text = ("Reset Click: " + a.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Copyted";
            Clipboard.SetText(textBox1.Text);
        }
    }
}
