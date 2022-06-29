using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "Enabled";
            Button bt = new Button();
            bt.Text = "Hello Everyone";
            bt.AutoSize = true;
            //Random rand = new Random();
            //bt.Location = new Point(rand.Next(0, panel1.Size.Width), rand.Next(0, panel1.Size.Height));
            //panel
            //panel1.Controls.Add(bt); //Thêm vào Form
            //flowLayoutPanel : có thể sắp xếp
            flowLayoutPanel1.Controls.Add(bt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Disable";
            panel1.Enabled = !panel1.Enabled; //Enabled vs panel
            flowLayoutPanel1.Enabled = !flowLayoutPanel1.Enabled;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
