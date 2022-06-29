using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF15
{
    public partial class Form1 : Form
    {
        ContextMenuStrip Context_Menu; //Khai báo/cú pháp ContextMenuStrip <Name>
        public Form1()
        {
            InitializeComponent();
            Context_Menu = new ContextMenuStrip();
            var item = new ToolStripButton() {Text = "Click Here"};
            item.Click += item_Click;//Tạo Even Click
            Context_Menu.Items.Add(item); //Add vào Form
        }

        private void item_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //press any key
            Context_Menu.Show(this, this.PointToClient(MousePosition));
            // Context_Menu.Show(vị trí) Ex: 0,0... 
            // PointToClient(MousePosition): tại vị trí của con trỏ chuột
        }
    }
}
