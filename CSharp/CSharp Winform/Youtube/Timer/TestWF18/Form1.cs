using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF18
{
    public partial class Form1 : Form
    {
        Timer timer2; //Create timer
        public Form1()
        {
            InitializeComponent();
            timer2 = new Timer();
            timer2.Tick += Timer2_Tick;
            timer2.Interval = 100; //thời gian 100/1s
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region Ex1
            //if (!timer1.Enabled)
            //{
            //    button1.Text = "Stop";
            //    timer1.Start();
            //}
            //else
            //{
            //    button1.Text = "Start";
            //    timer1.Stop();
            //}
            #endregion
            #region Ex2
            timer1.Enabled = !timer1.Enabled;
            button1.Text = button1.Text == "Stop" ? "Start" : "Stop";
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            #region Ex2:
            timer2.Enabled = !timer2.Enabled;
            button2.Text = button2.Text == "Dừng" ? "Bắt Đầu" : "Dừng";
            #endregion
        }
        int i = 0;
        int n = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            #region Ex2
            n++;
            label2.Text = n.ToString();
            #endregion
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
