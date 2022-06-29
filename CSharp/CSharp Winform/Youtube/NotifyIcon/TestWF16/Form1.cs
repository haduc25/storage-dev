using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Sử dụng để nhập dữ liệu từ textbox hiển thị lên thông báo
            notifyIcon1.ShowBalloonTip(5000,"Thông báo Từ HiHi","alo",ToolTipIcon.Warning);
            ////notifyIcon1.ShowBalloonTip(Số thời gian hiển thị); Ex:5000 = 5s
            //notifyIcon1.ShowBalloonTip(5000);
        }

        private void textToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = toolStripTextBox1.Text;//Sử dụng liên kết giữa textbox và toolstriptextbox
        }
    }
}
