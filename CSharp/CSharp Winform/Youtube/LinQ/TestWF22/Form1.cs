using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF22
{
    public partial class Form1 : Form
    {
        //Để Sử dụng LinQ phải kế thừa từ :IEnumerable<T> , (bôi đen List+F12)
        List<Food> DSFood; //Create List
        public Form1()
        {
            InitializeComponent();
            LoadFood(); //Call Hàm
        }
        void LoadFood() //DS Đặt trong Form 1
        {
            //Create Danh Sách
            DSFood = new List<Food>();
            DSFood.Add(new Food("Dog", "10"));
            DSFood.Add(new Food("Cat", "09"));
            DSFood.Add(new Food("Monkey", "08"));
            DSFood.Add(new Food("Pig", "07"));
            DSFood.Add(new Food("Bird", "06"));
            DSFood.Add(new Food("Fish", "05"));
            DSFood.Add(new Food("Chicken", "04"));
            DSFood.Add(new Food("Duck", "03"));
            DSFood.Add(new Food("Shark", "02"));
            DSFood.Add(new Food("Tom", "01"));
            DSFood.Add(new Food("Jerry", "00"));

            comboBox1.DataSource = DSFood;
            comboBox1.DisplayMember = "NameFood1"; //call namefood1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ex1
            //List<Food> KQ = new List<Food>();
            //foreach (Food item in DSFood)
            //{
            //    if(item.NameFood1 == textBox1.Text)
            //    {
            //        KQ.Add(item);
            //    }
            //}
            //comboBox2.DataSource = KQ;
            //comboBox2.DisplayMember = "NameFood1";
            #endregion
            #region Ex2 : Sử Dụng LinQ
            List<Food> KQ = new List<Food>();
            //KQ = DSFood.Where(a => a.NameFood1 == textBox1.Text).ToList();            //Where(Tên biến tạm thời)
            //KQ = DSFood.Select(a => a).ToList(); //lấy hết tất cả từ combo1 sang combo2
            var KQ1 = DSFood.Select(a => a.NameFood1).ToList(); //lấy tên từ combobox1 qua 2
            var KQ2 = DSFood.Select(a => a.PriceFood1).ToList(); //lấy giá từ combobox1 qua 2
            //Tolist(): nếu =null => lỗi có thể thay thế  = singleordefault()
            var KQ3 = DSFood.Skip(5).Take(2).ToList(); //Skip,Take
            //Skip(5): Bỏ qua 5 cái đầu
            //Take(2): Lấy 2 cái sau khi bỏ qua 5 cái đầu
            KQ = DSFood.OrderBy(b => Convert.ToInt32(b.PriceFood1)).ToList();//ép kiểu string về int
            comboBox2.DataSource = KQ1;
            comboBox2.DisplayMember = "NameFood1";
            comboBox3.DataSource = KQ2;
            comboBox3.DisplayMember = "PriceFood1";
            comboBox4.DataSource = KQ3;
            comboBox4.DisplayMember = "NameFood1";
            comboBox5.DataSource = KQ;
            comboBox5.DisplayMember = "NameFood1";
            #endregion
        }
    }
    public class Food
    {
        //Bôi đen hàm+Sử dụng phím tắt Ctrl+R+E(tạo nhanh get,set)
        private string NameFood;
        private string PriceFood;

        public string NameFood1 { get => NameFood; set => NameFood = value; }
        public string PriceFood1 { get => PriceFood; set => PriceFood = value; }
        //Create Hàm dựng
        public Food()
        {

        }
        public Food(string NameFood, string PriceFood)
        {
            this.NameFood1 = NameFood;
            this.PriceFood1 = PriceFood;
        }
    }
}
