using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pcName = System.Environment.MachineName;
            textBox1.Text = pcName;
            string user = System.Environment.UserName;
            textBox3.Text = user;
            //ip
            textBox2.Text = get_ID();
        }
        private string get_ID() 
        {
            string Address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using(WebResponse response = request.GetResponse())
                using(StreamReader stream =new StreamReader(response.GetResponseStream())) 
            {
                Address = stream.ReadToEnd();
            }
            int first = Address.IndexOf("Address: ") + 9;
            int last = Address.IndexOf("</body>");
            Address = Address.Substring(first, last - first);
            return Address;
        }
    }
}
