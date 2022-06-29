using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tinh_Diem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            only_checking.Start();
        }
        double numb1 = 0, numb2 = 0, temp = 0, point1 = 0, point2 = 0;
        int check = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked == false && rd_2.Checked == false && rd_3.Checked == false) { label5.Text = "Chưa chọn % !"; label5.ForeColor = System.Drawing.Color.Red; }
            else { label5.Text = ""; }
            point();
            if (check == 9999 || check > 9999) { check = 0; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            check++;
            tb_checking.Text = check.ToString();
            checking();
        }
        void checking()
        {
            try
            {
                if (rd_1.Checked)
                {
                    point1 = 0.3;
                    point2 = 0.7;
                }
                else if(rd_2.Checked)
                {
                    point1 = 0.4;
                    point2 = 0.6;
                }
                else if(rd_3.Checked)
                {
                    point1 = 0.5;
                    point2 = 0.5;
                }
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void point()
        {
            /*
                A: từ 8,5 đến 10,0;

                B: từ 7,0 đến 8,4;

                C: từ 5,5 đến 6,9;

                D: từ 4,0 đến 5,4.
             */
            try
            {
                if (double.TryParse(tb_diem_lop.Text, out numb1) && double.TryParse(tb_diem_thi.Text, out numb2) && numb1 <= 10 && numb2 <= 10)
                {
                    temp = numb1 * point1 + numb2 * point2;
                    lb_result.Text = "Điểm: " + temp;
                    lb_result.ForeColor = Color.White;
                    //tich
                    if (temp > 3.9 && temp < 5.5)
                    {
                        lb_tong_ket.Text = "Bạn đã Qua Môn ! \n=> Tích D";
                        lb_tong_ket.ForeColor = Color.Yellow;
                    }
                    else if(temp >= 5.5 && temp < 6.9) 
                    {
                        lb_tong_ket.Text = "Bạn đã Qua Môn ! \n=> Tích C";
                        lb_tong_ket.ForeColor = Color.Yellow;
                    }
                    else if(temp >= 7 && temp < 8.5)
                    {
                        lb_tong_ket.Text = "Bạn đã Qua Môn ! \n=> Tích B";
                        lb_tong_ket.ForeColor = Color.Yellow;
                    }else if(temp >= 8.5)
                    {
                        lb_tong_ket.Text = "Bạn đã Qua Môn ! \n=> Tích A";
                        lb_tong_ket.ForeColor = Color.Yellow;
                    }else{ lb_tong_ket.Text = "Toang !"; lb_tong_ket.ForeColor = Color.Red; }
                }
                else
                {
                    if (numb1 > 10 || numb2 > 10)
                    {
                        lb_result.Text = "Điểm phải < 10 !";
                        lb_result.ForeColor = Color.Red; // change color
                    }
                    else
                    {
                        lb_result.Text = "Vui lòng nhập điểm !";
                        lb_result.ForeColor = Color.Red; // change color
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
