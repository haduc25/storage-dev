using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep(); //Sử dụng với Style Blocks và Continuous
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.PerformLayout(); //Sử dụng với Style Marquee
            //Auto Start
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        //    if(Int32.Parse(textBox1.Text)<100)
        //    if (Int32.Parse(textBox1.Text)>0) 
        //    {
        //        progressBar1.Value = Int32.Parse(textBox1.Text);
        //        //progressBar1.Value = Int32.Parse(textBox1.Text);
        //        // textBox1.Text = progressBar1.Value;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error","Đã đạt giới hạn của ProgressBar");
        //    }

        }
        void Test()
        {
            if (Int32.Parse(textBox1.Text) < 101)
            {
                progressBar1.Value = Int32.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Đã đạt giới hạn của ProgressBar", "Error");
            }
            if (Int32.Parse(textBox1.Text) > 0)
                {
                    progressBar1.Value = Int32.Parse(textBox1.Text);
                    //progressBar1.Value = Int32.Parse(textBox1.Text);
                    // textBox1.Text = progressBar1.Value;
                }
                else
                {
                    MessageBox.Show("Value hiện tại của ProgressBar là: 0", "Error");
                }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}
