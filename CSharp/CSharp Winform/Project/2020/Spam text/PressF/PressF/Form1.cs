using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer_check.Start();
        }
        int interval, time_seconds, check = 0, temp = 0, time_default = 1, load1;
        int value = 111111, test = 0, kt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            on_();
        }
        void on_()
        {
            try
            {
                timer1.Start();
                timer_auto.Enabled = true;
                tb_text.ReadOnly = true;
                time_seconds = time_default; //<==
                // time_seconds = int.Parse(textbox1.Text); Neu k dung time default
                interval = int.Parse(tb_interval.Text);
                timer_auto.Interval = time_seconds * interval;

            }
            catch (Exception ex)
            {
                timer_auto.Enabled = false;
                MessageBox.Show("Info of Error:\n" + ex, "Error!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            off_();
        }
        void off_()
        {
            timer_auto.Enabled = false;
            tb_text.ReadOnly = false;
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(test == 0) { SendKeys.Send(tb_text.Text); }
            if (test == 1) { SendKeys.Send(tb_text.Text + " [" + temp + "]"); temp++; }
            SendKeys.Send("{ENTER}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textbox1.Text = "1"; Neu k dung time default
            tb_interval.Text = "1000";
            tb_text.ReadOnly = false;
            lb_text.Text = "Text and Mode: ";
            cb_mode.Checked = false;
            tb_time.Text = "5"; // so giay
            // timing1 = 1; // so giay
            load1 = int.Parse(tb_time.Text);
            //timer1.Start();
        }

        void check_mode()
        {
            if(cb_mode.Checked)
            {
                test = 1;
                lb_text.Text = "Text and Mode: Number";
            }
            else
            {
                test = 0;
                lb_text.Text = "Text and Mode: Normal";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_temp.Text = "";
            temp = 0;
            tb_time.Text = "5";



        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            check++;
            //value++;
            tb_checking.Text = check.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            load1--;
            tb_time.Text = load1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            status();
            check_mode();
            if (kt == 0) { dcmm();}
           //tb_text.Text = value.ToString();
            if (check == 9999 || check > 9999) { check = 0; }
            if(temp == 9999 || temp > 9999) { temp = 0; }
        }
        void status()
        {
            if(timer_auto.Enabled == true) { lb_status.Text = "Online !"; } else { lb_status.Text = "Offline !"; }
            //load1 = int.Parse(tb_time.Text);
        }
        void dcmm()
        {
            if (load1 == 0 || load1 < 0)
            {
                timer1.Stop();
                off_();
                kt = 1;
            }
            else { }
            //editttttttttt
        }
    }
}
