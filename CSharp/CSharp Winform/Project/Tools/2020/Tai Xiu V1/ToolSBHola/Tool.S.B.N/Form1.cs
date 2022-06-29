using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool.S.B.N
{
    public partial class Form1 : Form
    {
        int n = 1;
        int m = 0;
        int o = 0;
        int l = 0;
        public Form1()
        {
            int Step1 = 100;
            int Time1 = 20000;
            int Interval1 = 100;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            comboBox1.Enabled = !comboBox1.Enabled;
            textBox2.Enabled = !textBox2.Enabled;
            ToolTip tool = new ToolTip();
            tool.SetToolTip(button1, "Hello Everyone");
            tool.SetToolTip(button2, "Check Code Now");
            tool.SetToolTip(button3, "Click Youtube");
            tool.SetToolTip(button4, "Coming Soon");
            tool.SetToolTip(button5, "Click Gmail");
            tool.SetToolTip(button6, "Tutorial");
            progressBar1.Step = Step1;
            progressBar1.Maximum = Time1;
            progressBar1.Value = 0;
            timer1.Interval = Interval1;
        }
        void AddBT()
        {
            Button bt = new Button();
            bt.Text = "Ahihi";
            this.Controls.Add(bt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Result 85%
            #region Button1
            AddBT();
            //Test1();
            progressBar1.Value = 0;
            label9.Text = (n).ToString() + "/20";
            n++;
            if (n >= 21)
            {
                MessageBox.Show("Giới hạn là 20 lần", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                // button1.Enabled = false;   
                label10.Text = "Giới hạn là 20 lần";
                label14.Text = "";
            }
            Result();
            #endregion
        }
        void Result()
        {
            #region Button1
            int Value1 = 0;
            int Value2 = 0;
            int Value3 = 407000;
            int Value4 = Value3 + 99999;
            if (Int32.TryParse(comboBox1.Text, out Value1) && Int32.TryParse(textBox2.Text, out Value2))
            {
                if (2 < Convert.ToInt32(comboBox1.Text) && Convert.ToInt32(comboBox1.Text) < 19 && Value3 < Convert.ToInt32(textBox2.Text) && Convert.ToInt32(textBox2.Text) < Value4)
                {
                    Value3++;
                    timer1.Start();
                    label14.Text = "Loading...!";
                    Thread thrd = new Thread(Tong);
                    thrd.Start();
                    label11.Text = "";
                    label6.Text = "Success !";
                }
                else
                {

                    MessageBox.Show("Number hoặc Count (#) không phù hợp!\n Vui lòng chọn lại! ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    n--;
                    m++;
                    LockStart();
                }
                void LockStart()
                {
                    if (m == 5)
                    {
                        DialogResult OK1 = MessageBox.Show("Lock Start !!!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        button1.Enabled = !button1.Enabled;
                        label13.Text = "Lock Start !!!";
                        if (OK1 == System.Windows.Forms.DialogResult.OK)
                        {
                            Gmail();
                        }
                    }
                }
            }
            else
            {
                label11.Text = "Vui Lòng Chọn Số !";
                n--;
                l++;
                LockStart1();
            }
            #endregion
        }
        void LockStart1()
        {
            if (l == 20)
            {
                DialogResult OK2 = MessageBox.Show("Lock Start !!!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                button1.Enabled = !button1.Enabled;
                label13.Text = "Lock Start !!!";
                if (OK2 == System.Windows.Forms.DialogResult.OK)
                {
                    Gmail();
                }
            }
        }
        void Tong()
        {
            #region Button1

            Random rand = new Random(); //Tạo Rand
            int Kq = rand.Next(3, 19);//Sử dụng Rand
            //MessageBox.Show("Result: " + Kq);
            if (Kq >= 11)
            {
                label1.Text = "Tài ("+ Kq +")";
            }
            else
            {
                label1.Text = "Xỉu ("+ Kq +")";
            }
            #endregion
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You Click Check");
            CheckCode();
        }
        //Code
        void CheckCode()
        {
            string Error = "EJGogWaHenMeHGG";
            string Error1 = "8wHFJcUyhSaaUxu";
            string Code = "YesQE1S7uCjWMI4"; //real
            string Code1 = "jO2lkS4waTCTY1M";
            string Code2 = "lw7lQ8lZattHCK6";
            string Code3 = "blGo7STMiE6pq5E";
            string Code4 = "1zrh90NzwSmL9Fg";
            string Code5 = "1ji2ZQh0n1rdaMI";
            string Code6 = "xVFFpYiroLPcuLd";
            string Code7 = "IiX0DT0kJJsUxt8";
            string Code8 = "IbLriU5fU144hVa";
            string Code9 = "jZuopwGoHGvMjiU";
            string Code10 = "i8uArSQlUPt8xZX";
            string Code11 = "7dKnvJxh8XRa6lC";
            string Code12 = "hSiR8o1yj2hmgcM";
            string Code13 = "OgKB1ycZOPZXIxd";
            string Code14 = "SM7EhIPxBsqbc3F";
            string Code15 = "46bw1xU6iBdHI5X";
            string Code16 = "dlzKgNMepSOsseE";
            string Code17 = "rcEfExHAncVf1zM";
            string Code18 = "CDwSEnip0pvQSab";
            string Code19 = "0tBRNqpTXxHt5ca";
            void MHN()
            {
                comboBox1.Enabled = !comboBox1.Enabled;
                textBox2.Enabled = !textBox2.Enabled;
                button2.Enabled = !button2.Enabled;
                button1.Enabled = true;
                textBox1.ReadOnly = true;
            }
            if (textBox1.Text == Code || textBox1.Text == Code1 || textBox1.Text == Code2 || textBox1.Text == Code3 || textBox1.Text == Code4 || textBox1.Text == Code5 || textBox1.Text == Code6 || textBox1.Text == Code7 || textBox1.Text == Code8 || textBox1.Text == Code9 || textBox1.Text == Code10 || textBox1.Text == Code11 || textBox1.Text == Code12 || textBox1.Text == Code13 || textBox1.Text == Code14 || textBox1.Text == Code15 || textBox1.Text == Code16 || textBox1.Text == Code17 || textBox1.Text == Code18 || textBox1.Text == Code19)
            {
                label4.Text = "Success !";
                MHN();
            }
            else
            {
                label4.Text = "Vui Lòng Nhập Mã !";
                o++;
                MessageBox.Show("Mã không chính xác hoặc đã được sử dụng!\nVui lòng nhập lại! ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                LockCheck();
            }
            if ((textBox1.Text == Error) || (textBox1.Text == Error1))
            {
                label4.Text = "Mã đã được sử dụng !";
                o++;
                LockCheck();
            }
            else 
            {}
        }
        void LockCheck()
        {
            if (o == 10)
            {
                button2.Enabled = !button2.Enabled;
                DialogResult OK3 = MessageBox.Show("Lock Check !!!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBox1.ReadOnly = true;
                label4.Text = "Bạn nhập mã sai quá nhiều\n'Check' đã bị khóa!";
                if (OK3 == System.Windows.Forms.DialogResult.OK)
                {
                    Gmail();
                }
            }
        }
        void Youtube()
        {
            string LinkYoutube = @"https://www.youtube.com/channel/UCei-tSXy69Qr9AnrtpRObog";
            Process.Start(LinkYoutube);
            MessageBox.Show("Hi Luv•u", "Youtube: ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Youtube 100%
            Youtube();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon", "Version Pro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Gmail();
            Youtube1();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Gmail();
        }
        void Gmail()
        {
            string LinkGmail = @"https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            Process.Start(LinkGmail);
            MessageBox.Show("Hereisjobbro1@gmail.com", "Gmail Me: ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        void Quit()
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit Tool.S.B.N?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true; //Hàm Hủy Even
            }
            else 
            {
                MessageBox.Show("💓Thanks for Anything !💓", "Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gmail();
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Youtube();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tutorial();
            MessageBox.Show("1.Nhập Code\n(Để lấy code Vui lòng liên hệ qua Gmail)\n2.Chọn Check Code \n3.Để tăng tỉ lệ chính xác lựa chọn số gần nhất kết quả\n(Xem video hương dẫn chi tiết tại Youtube)\nVD:\nNumber: Số gần nhất sau phiên kết quả.\n*Bắt buộc phải chọn số\n4.Nhập #\n5.Chờ đến phiên đặt cửa (Wait Refrest)\n6.Chọn Start\n7.Check Kết Quả\n*Lưu ý:\n-Nhập đúng Code\n-Chọn đúng Number\n-Mỗi code chỉ được sử dụng 1 lần\n-Mỗi code sẽ chỉ được Start 20 lần\n(để tăng số lần có thể mua thêm Code hoặc phiên bản Pro)\n-TỈ LỆ ĐÚNG CHỈ TỪ 85%-90% CHO NÊN VẪN SẼ CÓ 2-3 PHIÊN LÀ SẼ RA SAI KẾT QUẢ !\n*A some quetion !\nHow to get code?\n-Contact me: Youtube,Gmail\nHow to download?\nHow to install?\n-Just watch video on Youtube, Click button (Youtube) or button (Hướng Dẫn),(Tutorial)\n-End-\nCảm ơn vì đã sử dụng, Chúc bạn may mắn !\n💓Thanks for Anything !💓", "Hướng Dẫn !");
        }

        private void versionProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon", "Version Pro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Gmail();
            Youtube1();
        }
        void Youtube1() 
        { string LinkVideo1 = @"https://youtu.be/nkSbqtMif8E";
            Process.Start(LinkVideo1);
        }
        
        void Zalo()
        {
            string LinkZalo = @"https://id.zalo.me/account?continue=https%3A%2F%2Fchat.zalo.me%2F";
            Process.Start(LinkZalo);
            MessageBox.Show("0936813561", "Zalo: ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void zaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zalo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum && n <= 20)
            {
                timer1.Stop();
                button1.Enabled = true;
                comboBox1.Enabled = true;
                textBox2.Enabled = true;
                label14.Text = "";
            }
            else
            {
                comboBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = false;
                timer1.Start();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Quit();
        }

        private void oppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 1.0.0 \nProducer by: Hi Luv\nRelease year: 2020\nSupport: Coming Soon\nContact Me: Youtube,Gmail,Zalo\n💓Thanks for Anything !💓 ", "Info Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void Tutorial() 
        {
            string Tutorial = @"https://youtu.be/f7doBRHZROE";
            Process.Start(Tutorial);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Tutorial();
            MessageBox.Show("1.Nhập Code\n(Để lấy code Vui lòng liên hệ qua Gmail)\n2.Chọn Check Code \n3.Để tăng tỉ lệ chính xác lựa chọn số gần nhất kết quả\n(Xem video hương dẫn chi tiết tại Youtube)\nVD:\nNumber: Số gần nhất sau phiên kết quả.\n*Bắt buộc phải chọn số\n4.Nhập #\n5.Chờ đến phiên đặt cửa (Wait Refrest)\n6.Chọn Start\n7.Check Kết Quả\n*Lưu ý:\n-Nhập đúng Code\n-Chọn đúng Number\n-Mỗi code chỉ được sử dụng 1 lần\n-Mỗi code sẽ chỉ được Start 20 lần\n(để tăng số lần có thể mua thêm Code hoặc phiên bản Pro)\n-TỈ LỆ ĐÚNG CHỈ TỪ 85%-90% CHO NÊN VẪN SẼ CÓ 2-3 PHIÊN LÀ SẼ RA SAI KẾT QUẢ !\n*A some quetion !\nHow to get code?\n-Contact me: Youtube,Gmail\nHow to download?\nHow to install?\n-Just watch video on Youtube, Click button (Youtube) or button (Hướng Dẫn),(Tutorial)\n-End-\nCảm ơn vì đã sử dụng, Chúc bạn may mắn !\n💓Thanks for Anything !💓", "Hướng Dẫn !");
        }
    }
}