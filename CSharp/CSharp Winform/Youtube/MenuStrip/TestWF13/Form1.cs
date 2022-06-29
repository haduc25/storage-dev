using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void icon11ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ toolStripCombobox1
            string str = toolStripComboBox1.SelectedItem.ToString();
            label1.Text = str;
        }

        private void icon1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Click Here");
        }
    }
}
