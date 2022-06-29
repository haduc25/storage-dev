using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_With_Base64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Code En & De
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        private void btEncode_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = Base64Encode(textBox1.Text);
            MessageBox.Show("Encode Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btDecode_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Base64Decode(textBox2.Text);
            MessageBox.Show("Decode Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
