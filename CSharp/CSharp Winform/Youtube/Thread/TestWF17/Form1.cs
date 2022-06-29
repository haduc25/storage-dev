using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Ex1:
            Control.CheckForIllegalCrossThreadCalls = false; //Sử dụng để k check thread, cho phép thread sử dụng chung nhau
            //Control.CheckForIllegalCrossThreadCalls = false; không nên sử dụng nhiều dễ crack,bug
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ex1
            //Create Thread 
            ThreadStart thrst = new ThreadStart(Test);      //Cần 1 hàm void
            Thread thr = new Thread(thrst);     //Sử dụng thư viện System.Threading
            thr.Start();        //khởi chạy thread
            #endregion
        }
        void Test()
        {
            #region Ex1
            for (int i = 0; i <= Convert.ToInt32(textBox1.Text); i++) //Ép kiểu 
            {
                label1.Text = i.ToString();
            }
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Click Here"); //Ex1
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void MovePicture()
        {
            #region Ex2
            while (true)
            {
                if (checkBox1.Checked)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                    //Nếu check thì x-1;
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                    //Ngược lại
                }
                Thread.Sleep(Speed);
            }
            #endregion
        }
        int Speed = 100; //Khai báo hàm speed hỗ trợ sleep Ex2
        private void button3_Click(object sender, EventArgs e)
        {
            #region Ex2
            //Ex2 Viết Tắt
            Thread thr1 = new Thread(MovePicture);
            //Thread.Sleep(Speed);
            thr1.IsBackground = true; //nếu form tắt thread tắt theo
            //Thread.Sleep(5000);
            thr1.Start();
            #endregion
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            #region Ex2
            if (int.TryParse(textBox2.Text,out Speed))
            {
            }
            #endregion
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
