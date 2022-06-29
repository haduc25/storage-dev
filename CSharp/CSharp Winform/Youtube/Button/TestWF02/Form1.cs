using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Button
        int i = 0;
        void AddButton()
        {
            Random rand = new Random(); //Create Random
            Button bt = new Button() { Text ="Error: "+i.ToString(), Location = new Point(rand.Next(0,this.Size.Width), rand.Next(0,this.Size.Height)) };
            //ToString: Create string
            //Location: Create vi tri 
            //rand.Next(a,b) : random trong khoang a-(b-1) 
            //Ex1:rand.Next(0, 100), rand.Next(0, 100))
            //Ex2:rand.Next(0,this.Size.Width), rand.Next(0,this.Size.Height) :random trong khoang cua form
            this.Controls.Add(bt);
            //Auto Create Bottun
            bt.Click += Bt_Click; //use Tab+Tab 
            i++;
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            //Ep Kieu
            Button bt = sender as Button;
            MessageBox.Show("Thanks for Click:\n"+bt.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Click Here !");
        }
    }
}
