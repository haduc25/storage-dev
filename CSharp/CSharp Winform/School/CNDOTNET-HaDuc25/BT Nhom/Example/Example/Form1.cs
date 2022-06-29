using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_path.Text = filePath;
        }
        public string filePath = @"C:\ViDu1.txt";

        private void bt_fullp_Click(object sender, EventArgs e)
        {
            checking();
            string nameFile = Path.GetFullPath(filePath);
            bt_rs.Text = "" + nameFile.ToString();
        }

        private void bt_direc_Click(object sender, EventArgs e)
        {
            checking();
            string directoryName = Path.GetDirectoryName(filePath);
            bt_rs.Text = "" + directoryName.ToString();
        }

        private void bt_filen_Click(object sender, EventArgs e)
        {
            checking();
            string nameFile = Path.GetFileName(filePath);
            bt_rs.Text = "" + nameFile.ToString();
        }

        private void bt_ext_Click(object sender, EventArgs e)
        {
            checking();
            string ext = Path.GetExtension(filePath);
            bt_rs.Text = "" + ext.ToString();
        }

        private void bt_filenwe_Click(object sender, EventArgs e)
        {
            checking();
            string nameFile = Path.GetFileNameWithoutExtension(filePath);
            bt_rs.Text = "" + nameFile.ToString();
        }


        void checking()
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Tep khong ton tai !\n" + filePath, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                using (FileStream fs = File.Create(filePath))
                {
                    Byte[] title = new UTF8Encoding(true).GetBytes("Hello World!");
                    fs.Write(title, 0, title.Length);
                    MessageBox.Show("Tao tep thanh cong!\n" + filePath, "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
