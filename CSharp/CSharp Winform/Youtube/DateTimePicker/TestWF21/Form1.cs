using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.ShowUpDown = true; //tắt hiển thị dd/mm/yyyy
            DateTime date = dateTimePicker1.Value; //giá trị 
            date.AddDays(-5); //Cộng trừ ngày
          //  DateTime.Now; //lấy thời gian hiện tại
        }
    }
}
