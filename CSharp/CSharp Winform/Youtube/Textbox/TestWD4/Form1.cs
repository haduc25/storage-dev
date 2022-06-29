using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWD4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox3.Text;
            //Ex1: Binh phuong cua 1 so
            //int num = Convert.ToInt32(textBox3.Text); // Ép kiểu
            //label1.Text = (num * num).ToString();

            //Ex2: Binh phuong cua 1 so (Điều kiện phải là số)
            ////int num = 0;
            ////if (Int32.TryParse(textBox3.Text, out num))
            ////{
            ////    label1.Text = (num * num).ToString();
            ////}
            ////else
            ////{
            ////    label1.Text = "Vui lòng nhập số !";
            ////}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Ex3:Auto
            //Sử dụng không c đến bottun vs enter
            int num = 0;
            if (Int32.TryParse(textBox3.Text, out num))
            {
                label1.Text = (num * num).ToString();
            }
            else
            {
                label1.Text = "Vui lòng nhập số !";
            }

        }
    }
}
