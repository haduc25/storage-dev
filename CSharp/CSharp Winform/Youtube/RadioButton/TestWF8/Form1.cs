using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void KetQua(Label lb, Panel pn)
        {
           RadioButton rdo = null;
            foreach (RadioButton empty in pn.Controls)
            {
                if(empty != null)
                if (empty.Checked)
                {
                        rdo = empty;
                        break;
                }
            }
            if (rdo != null){
                lb.Text = rdo.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KetQua(label1,panel1);
            KetQua(label2, panel2);
            KetQua(label3, panel3);
        }
        //Auto vs CheckedChanged
        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton; //Esp kiểu
                if (radio.Checked)
            {
                label1.Text = radio.Text;
            }
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton; //Esp kiểu
                if (radio.Checked)
            {
                label2.Text = radio.Text;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton; //Esp kiểu
                if (radio.Checked)
            {
                label3.Text = radio.Text;
            }
        }
    }
}
