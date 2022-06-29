using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int a = 6, count = 0, forfun=0;
        private void button1_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 6;
            count = 0;
            forfun = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            restart();
            count++;
            textBox1.Text = "This's is Number: "+count.ToString();
        }
        void restart()
        {
            timer1.Start();
            a--;
            if (a == 0 || a < 0)
            {
                a = 6;
                timer1.Stop();
                Application.Restart();
            }
            label1.Text = "Restart Application in [" + a + "] seconds";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            forfun++;
            MessageBox.Show("4Fun Clicked: " + forfun.ToString() + " Times", "Clicked");
        }
        /*
         * Youtube: https://www.youtube.com/watch?v=fehVTLNQorQ
         */
    }
}
