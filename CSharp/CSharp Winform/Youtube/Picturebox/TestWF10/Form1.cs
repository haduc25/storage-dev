using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF10
{
    public partial class Form1 : Form
    {
        string extention = ".jpg"; //Ex:2
        public Form1()
        {
            #region Ex 2:
            InitializeComponent();
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            ImageName();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ex 1:
            //Copy file Resurces vào bin\debug
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\love sad 2.jpeg");
            #endregion
        }
        void ImageName()
        {
            #region Ex 2:
            List<string> ListImage = new List<string>() { "picture1", "eye blue", "love sad 1"}; //Tên image
            comboBox1.DataSource = ListImage;
            #endregion
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Ex 2:
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);
                pictureBox1.Image = bm;
            }
            #endregion
        }
    }
}
