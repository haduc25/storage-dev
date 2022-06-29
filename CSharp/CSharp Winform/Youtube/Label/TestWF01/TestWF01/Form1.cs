using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Newlabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Lable
        //Create 1 ham moi
        void Newlabel()
        {
            Label lb = new Label();
            lb.Text = "Hello Everyone";
            //Sử dụng this 
            this.Controls.Add(lb); //in,thêm vào form
            lb.BackColor = Color.Yellow;  //Đổi màu nền
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Good";
            //sử dụng để mở 1 form mới
            Test1 a = new Test1();
            a.Show(); //show(): có thể tạo nhiều form 
            //a.ShowDialog(); //showdialog(): yêu cầu thao tác trên form vừa tạo, sử dụng nhập info
            //Change info lable 2
            a.label2.Text = "So Good";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
            
        }
    }
}
