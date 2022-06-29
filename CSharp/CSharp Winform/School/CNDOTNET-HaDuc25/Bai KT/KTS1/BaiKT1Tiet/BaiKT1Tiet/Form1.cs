using System;
using System.Windows.Forms;


namespace BaiKT1Tiet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSach_Click(object sender, EventArgs e)
        {
            FormSACH fsach = new FormSACH();
            fsach.ShowDialog();
        }

        private void btMT_Click(object sender, EventArgs e)
        {
            FormMuon_Tra fmt = new FormMuon_Tra();
            fmt.ShowDialog();
        }

        private void btDG_Click(object sender, EventArgs e)
        {
            FormDocGia fdg = new FormDocGia();
            fdg.ShowDialog();
        }
    }
}
