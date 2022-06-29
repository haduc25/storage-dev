using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWF9
{
    public partial class Form1 : Form
    {
        List<SinhVien> ListSV; //Ex4
        public Form1()
        {
            InitializeComponent();

            #region Ex3:
            DSFood = new List<Food>()
            {
                new Food(){NameFood = "Tomato",Price = 2000},
                new Food(){NameFood = "Orange",Price = 1000},
                new Food(){NameFood = "Banana",Price = 5000},
                new Food(){NameFood = "Apple",Price = 200000}
            };
            comboBox1.DataSource = DSFood;
            comboBox1.DisplayMember = "NameFood";
            comboBox2.DataSource = DSFood;
            comboBox2.DisplayMember = "Price";
            AddBinding();
            #endregion
            #region Ex4:
            ListSV = new List<SinhVien>();
            ListSV.Add(new SinhVien()
            {
                HoTen = "Hà Minh Đức",
                DSSV = new List<string>() { "CNTT", "ATTT","TKDH"}
            });
            ListSV.Add(new SinhVien()
            {
                HoTen = "Hà Đức",
                DSSV = new List<string>() { "KHMT", "TKDH","TMDD"}
            });
            comboBox3.DataSource = ListSV;
            comboBox3.DisplayMember = "HoTen";
            #endregion
        }
        #region Ex1:
        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //SelectedIndexChanged: Lấy giá trị từ 0-n
            ComboBox cb = sender as ComboBox; //Ép Kiểu
            MessageBox.Show("You Click Selected IndexChanged " + cb.SelectedIndex.ToString());
        }

        private void comboBox5_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //SelectedValueChanged,SelectedItem: lấy giá trị của Item   
            ComboBox cb = sender as ComboBox; //Ép Kiểu
            MessageBox.Show("You Click Selected ValueChanged " + cb.SelectedItem);
        }
        //Sử dụng 1 trong 2 SelectedItem or DataSource
        #endregion
        #region Ex2:
        List<string> Animal;    //Tạo 1 list kiểu string Ex1
        #endregion
        #region Ex3: 
        List<Food> DSFood;   //Tạo 1 list kiểu Food  
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            #region Ex 2: Dùng button với combobox
            MessageBox.Show("You Click Here");
            Animal = new List<string>() { "==========Select==========", "Rabit", "Dog", "Cat", "Bird", "Monkey" };
            comboBox6.DataSource = Animal;
            #endregion
        }

        public class Food
        {
            #region Ex3:
            public string NameFood{get; set;}
            public float Price { get; set; }
            //Sử dụng SelectedValueChanged của cobobox kết hợp vs textbox Ex3
            #endregion
        }
        void AddBinding()
        {
            #region Ex 3:
            TextB1.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Price"));
            //Từ 'comboBox1.DataDource' lấy giá trị của'Price' đưa sang 'Text'
            #endregion
        }
        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Ex 4:
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                SinhVien sv = cb.SelectedValue as SinhVien;
                comboBox4.DataSource = sv.DSSV;
            }
            #endregion
        }
    }
    public class SinhVien
    {
        #region Ex4:
        public string HoTen { get; set; }
        public List<string> DSSV { get; set; }
        #endregion
    }
}
