using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Ex (for fun) : Click 100 lần
            //int n = 100;
            //for (int i = 0; i <n; i++)
            //{
            //    MessageBox.Show("Click Here");
            //}
            ////Ex 1: Hiện tiêu đề thông báo
            //MessageBox.Show("Thanks for Click","Notification");
            ////Ex 2: Hiện tiêu đề thông báo,Yêu cầu,Icon,Style
            //MessageBox.Show("Thanks for Click", "Notification", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
            ////Ex 3:Yes,No,Cancel
            DialogResult KetQua = MessageBox.Show("Thanks for Click", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            ////Case 1: Với If,Else
            //if(KetQua == System.Windows.Forms.DialogResult.Yes)
            //{
            //    MessageBox.Show("You Chose Yes");
            //}
            //else
            //{
            //    MessageBox.Show("You Chose No");
            //}
            ////Case 2: Switch,Case
            switch (KetQua){
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("You Chose Retry");
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.OK:
                    MessageBox.Show("You Chose Ok");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("You Chose Yes");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("You Chose Cancel");
                    break;
                case DialogResult.No:
                    MessageBox.Show("You Chose No");
                    break;
                case DialogResult.None:
                    break;
            } 
        }
    }
}
