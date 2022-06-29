using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Process1()
        {
            Process[] Arr = Process.GetProcesses(); //Sử dụng thư viện using System.Diagnostics;
            //GetProcesses() lấy list process
            //Process[] processArr Mảng process
            foreach (Process item in Arr)
            {
                textBox1.Text = item.ProcessName + "\n" + textBox1.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");        //Chạy 1 chương trình với process
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\TestWF20.exe");       //Chạy 1 App với process
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string link = @"www.youtube.com";
            Process.Start(link);
            //Với liên kết k thể hide
            //@ : lấy đường dẫn tuyệt đối, cho máy hiểu k có kí tự đặc biệt nào
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process prc = new Process();
            prc.StartInfo.FileName = Application.StartupPath+ "\\TestWF20.exe"; //Tên App
            prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; //Thiết lập chế độ
            //Hide : hiện trong task Manager
            prc.Start();

        }
    }
}
