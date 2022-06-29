using System;
using System.Drawing;
using System.Windows.Forms;

namespace Label_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        void change()
        {
            Label lb = new Label();
            Random rand = new Random();
            Form1 form = new Form1();
            lb.Text = "25S";
            lb.AutoSize = true;
            lb.Location = new Point(rand.Next(0, form.Size.Width), rand.Next(0, form.Size.Height));
            lb.Size = new System.Drawing.Size(900, 26);
            lb.Font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold);
            this.Controls.Add(lb);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            change();
        }
    }
}
