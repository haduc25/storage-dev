using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Startup_Run
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey regis = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            regis.SetValue("Hello Everyone !", Application.ExecutablePath.ToString());
            MessageBox.Show("Saved", "Infomation");
        }
        void cout() 
        {
            int a = 1,b=0;
            while (a == 1) 
            {
                b++;
                MessageBox.Show("hello= " + b);
                if(b == 20) { a = 0; }
            }
        }
    }
}
