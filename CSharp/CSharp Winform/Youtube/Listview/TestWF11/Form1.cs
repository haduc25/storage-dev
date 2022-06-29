using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWF11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }
        //Thêm Image
        ImageList ImageSmall;
        ImageList ImageLarge;
    void LoadImage()
        {
            //Thêm Image Small
            ImageSmall = new ImageList() { ImageSize = new Size(50, 50) }; //Size Image
            ImageSmall.Images.Add(new Bitmap(Application.StartupPath +"\\Image\\1.jpg"));
            ImageSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Image\\2.jpg"));
            ImageSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Image\\3.jpg"));
            //Thêm Image Large
            ImageSmall = new ImageList() { ImageSize = new Size(68, 68) }; //Size Image
            ImageSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Image\\1.jpg"));
            ImageSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Image\\2.jpg"));
            ImageSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Image\\3.jpg"));
        } 
    void LoadListView()
        {
            LoadImage(); //Chạy load image
            listView1.FullRowSelect = true;      //Sử dụng bôi đen all
            listView1.GridLines = true;         //Sử dụng có dòng kẻ bảng
            listView1.SmallImageList = ImageSmall;      //Sử dụng làm nhỏ Image
            listView1.LargeImageList = ImageLarge;      //Sử dụng làm lớn Image
            //Thêm Columns
            listView1.Columns.Add("Columns 1");
            listView1.Columns.Add("Columns 2");
            listView1.Columns.Add("Columns 3");
            // Thêm Item,SunItem
            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item 1";
            item1.ImageIndex = 0; //Thêm Image vào Iteam
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubIteam 1" }); //Add SubItem
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubIteam 2" }); //Add SubItem

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.ImageIndex = 1; //Thêm Image vào Iteam
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubIteam 3" }); //Add SubItem
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubIteam 4" }); //Add SubItem

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item 3";
            item3.ImageIndex = 2; //Thêm Image vào Iteam
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubIteam 5" }); //Add SubItem
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SubIteam 6" }); //Add SubItem

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true; //Thêm checkbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            listView1.CheckBoxes = false; //Thêm checkbox
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            listView1.CheckBoxes = false; //Thêm checkbox
        }
        }
    }

