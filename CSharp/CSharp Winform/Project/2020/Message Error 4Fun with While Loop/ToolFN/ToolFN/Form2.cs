using System;
using System.Windows.Forms;

namespace ToolFN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int length = 1;
        private void Form2_Load(object sender, EventArgs e)
        {
            while(length == 1)
            {
                MessageBox.Show("ERROR: You can't close it !","Ha Duc",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
