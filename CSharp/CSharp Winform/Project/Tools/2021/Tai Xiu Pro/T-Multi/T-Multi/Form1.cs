using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace T_Multi
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Màu khá đẹp PaleGreen
        /// </summary>
        //edit form 2 send mess have tb gui den system
        private static int dead = 0, temp = 0, kt = 0, mkhs = 0, check_conn;
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
        }
        //check code
        void check_code()
        {
            string c = "eNy9o4YjQG"; //Mẫu
            string c1 = "ilzH2bjaEJ";
            string c2 = "SujQJupE4J";
            string c3 = "xC6H0HskXC";
            string c4 = "4dJpkdr6No";
            string c5 = "WvVxDgfH3m";
            string c6 = "IiyIX4v4F0";
            string c7 = "EcvEuqcY48";
            string c8 = "UZ8WyDVtud";
            string c9 = "JsF98fGvEO";
            string c10 = "QFRuf3PmxP";
            if (tb_checking.Text == c || tb_checking.Text == c1 || tb_checking.Text == c2 || tb_checking.Text == c3 || tb_checking.Text == c4 || tb_checking.Text == c5 || tb_checking.Text == c6 || tb_checking.Text == c7 || tb_checking.Text == c8 || tb_checking.Text == c9 || tb_checking.Text == c10)
            {
                if (tb_checking.Text == c || tb_checking.Text == c1)
                {
                    lb_err1.Text = "Mã kích hoạt đã được sử dụng !";
                    lb_err1.ForeColor = Color.Black;
                }
                else
                {
                    tb_checking.ReadOnly = true;
                    lb_err1.Text = "Kích hoạt thành công !";
                    lb_err1.ForeColor = Color.White;
                    kt = 2;
                }
            }
            else
            {
                lb_err1.Text = "Mã kích hoạt sai !";
                lb_err1.ForeColor = Color.Black;
                mkhs++;
                if (mkhs >= 5)
                {
                    lb_mkh.Enabled = true;
                    lb_mkh.Text = "Bạn chưa có mã kích hoạt ?";
                    lb_mkh.ForeColor = Color.Blue;
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
        //add
        void web_ben()
        {
            string web = @"https://benvip.club/";
            Process.Start(web);
        }
        void web_s7()
        {
            string web = @"https://s7club.net/";
            Process.Start(web);
        }
        void web_bom79()
        {
            string web = @"https://bom79.club/";
            Process.Start(web);
        }
        void web_zing888()
        {
            string web = @"https://zing888.club/";
            Process.Start(web);
        }
        void web_r68()
        {
            string web = @"https://gamebainohu.org/tai-r68-club/";
            Process.Start(web);
        }
        void web_hu86()
        {
            string web = @"https://quayhudanhbai.com/h86-club/";
            Process.Start(web);
        }
        void web_p99()
        {
            string web = @"https://gamebainohu.org/p99-club/";
            Process.Start(web);
        }
        void web_bali()
        {
            string web = @"https://doithuong247.com/bali-club/";
            Process.Start(web);
        }
        void web_zclub()
        {
            string web = @"https://zclub.vin/";
            Process.Start(web);
        }
        void web_9fun()
        {
            string web = @"https://9fun.club/";
            Process.Start(web);
        }
        void web_sumvip()
        {
            string web = @"https://taisum.club/";
            Process.Start(web);
        }
        void web_fun365()
        {
            string web = @"https://doithuong.us/fun365-club/";
            Process.Start(web);
        }
        void web_lux()
        {
            string web = @"http://lux39club.com/";
            Process.Start(web);
        }
        void web_socvip()
        {
            string web = @"https://taisocvip.vin/";
            Process.Start(web);
        }
        void web_trum88()
        {
            string web = @"https://taigame88.com/";
            Process.Start(web);
        }
        void web_suong()
        {
            string web = @"https://quayhudanhbai.com/suong-club/";
            Process.Start(web);
        }
        void web_live79()
        {
            string web = @"https://doithuong.us/live79-club/";
            Process.Start(web);
        }
        void web_g9()
        {
            string web = @"https://quayhudanhbai.com/g9-club/";
            Process.Start(web);
        }
        void web_vicwin()
        {
            string web = @"https://vicwin.vip/";
            Process.Start(web);
        }
        void web_loc86()
        {
            string web = @"https://nohu.to/tai-loc-86/";
            Process.Start(web);
        }
        void web_do99()
        {
            string web = @"https://dom99.club/";
            Process.Start(web);
        }
        void web_dep88()
        {
            string web = @"https://dep-88.club/";
            Process.Start(web);
        }
        void web_ting88()
        {
            string web = @"https://ting88.net/";
            Process.Start(web);
        }
        void web_hutop()
        {
            string web = @"https://gamebainohu.org/hutop-club/";
            Process.Start(web);
        }
        void web_iwin()
        {
            string web = @"https://iwin68.info/";
            Process.Start(web);
        }
        void web_may()
        {
            string web = @"https://lp.mayvn.vip/";
            Process.Start(web);
        }
        void web_top88()
        {
            string web = @"https://qc.top88.us/";
            Process.Start(web);
        }
        void web_vn88()
        {
            string web = @"https://www.vn88.app/signup";
            Process.Start(web);
        }
        void web_188bet()
        {
            string web = @"https://www.188dota.com/vi-vn/sign-up";
            Process.Start(web);
        }
        void web_w88()
        {
            string web = @"https://www.w88b.co/?affiliateID=71300";
            Process.Start(web);
        }
        void web_h99()
        {
            string web = @"https://doithuong.us/hu-99-club/";
            Process.Start(web);
        }
        void web_bachkim()
        {
            string web = @"https://bachkimvip.vin/";
            Process.Start(web);
        }
        void web_bum88()
        {
            string web = @"http://bum88.club/";
            Process.Start(web);
        }
        void web_zindo()
        {
            string web = @"http://zin66.club/";
            Process.Start(web);
        }
        void web_rankvip()
        {
            string web = @"https://quayhudanhbai.com/rankvip-club/";
            Process.Start(web);
        }
        void web_vinbet()
        {
            string web = @"http://vinbet.club/";
            Process.Start(web);
        }
        void web_bigwin()
        {
            string web = @"https://doithuongclub.com/bigwin99-club/";
            Process.Start(web);
        }
        void web_thantai68()
        {
            string web = @"https://gamebainohu.org/than-tai-68/";
            Process.Start(web);
        }
        void web_hu79()
        {
            string web = @"https://gamebainohu.org/than-tai-68/";
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
        //nhap,code
        #region Dang nhap
        #region Enter, Leave 
        //Enter
        //textBox
        private void tb_value_Enter(object sender, EventArgs e)
        {
            if (tb_value.Text == "Number of Turns") { tb_value.Text = ""; tb_value.ForeColor = Color.Yellow; }
            if (tb_value.Text == "Mã phiên") { tb_value.Text = ""; tb_value.ForeColor = Color.Yellow; }
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
            if (tb_value.Text == "" && cbb_language.Text == "English") { tb_value.Text = "Number of Turns"; tb_value.ForeColor = Color.White; }
            if (tb_value.Text == "" && cbb_language.Text == "Tiếng Việt") { tb_value.Text = "Mã phiên"; tb_value.ForeColor = Color.White; }
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
                bt_list.Text = "List of Videos";
                bt_webgame.Text = "Website Game";
                bt_active.Text = "Activation Code";
                bt_sub.Text = "SUBSCRIBE";
                bt_restart.Text = "Restart";
                bt_his.Text = "Playing History";
                tb_value.Text = "Number of Turns";
            }
            else if (cbb_language.Text == "Tiếng Việt")
            {
                lb_status.Text = "Trạng Thái Mạng:";
                bt_spin.Text = "Quay";
                tb_checking.Text = "Mã Kích Hoạt";
                bt_list.Text = "Danh Sách Video";
                bt_webgame.Text = "Trang Game";
                bt_active.Text = "Mã Kích Hoạt";
                bt_sub.Text = "ĐĂNG KÝ";
                bt_restart.Text = "Khởi động lại";
                bt_his.Text = "Lịch sử chơi";
                tb_value.Text = "Mã phiên";
            }
        }
        int rs;
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
                    if (cbb_language.Text == "English")
                    {
                        lb_netWork.Text = "Connected";
                        lb_netWork.ForeColor = System.Drawing.Color.FromArgb(64, 0, 0); // change color
                    }
                    if (cbb_language.Text == "Tiếng Việt")
                    {
                        lb_netWork.Text = "Đã kết nối";
                        lb_netWork.ForeColor = System.Drawing.Color.FromArgb(64, 0, 0); // change color
                    }
                    abcd();
                    check_conn = 1; //connect
                }
                else
                {
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
                    check_conn = 2;//diss
                }
                auto_1();
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }
        private void bt_spin_Click(object sender, EventArgs e)
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
            custom_ProG.Value = 0;
            if (custom_ProG.Value == custom_ProG.Minimum) { timer_what.Stop(); bt_spin.Enabled = true; bt_spin.Text = "Spin"; }
        }
        private void timer_wait_Tick(object sender, EventArgs e)
        {
            wait--;
            bt_spin.Text = "Wait " + wait + " second...";
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
            lb_mkh.Text = "";
            lb_mkh.Enabled = false;
            lb_netWork.Text = "";
            lb_err1.Text = "";
            lb_err2.Text = "";
            lb_result.Text = "";
            lb_more.Text = "";
            lb_ShowName.Text = "";
            bt_virus.FlatStyle = FlatStyle.Flat;
            bt_virus.FlatAppearance.BorderSize = 1;
            bt_virus.BackColor = Color.Ivory;
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
            if (check_conn == 1)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (check_conn == 2)
            { MessageBox.Show("Vui lòng kết nối Internet ", "Notice !", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                if (get == "B52club_(taib52.club)")
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
                if (get == "GamVip_(gamvip.com)")
                {
                    web_gam();
                }
                if (get == "Go88_(go88vn.vip)")
                {
                    web_go88();
                }
                if (get == "Hen88club_(hen88.club)")
                {
                    web_hen88();
                }
                if (get == "KingFun_(kingfun.info)")
                {
                    web_kingfun();
                }
                if (get == "ZoWin_(zowinvn.vip)")
                {
                    web_zowin();
                }
                if (get == "Nhat.Vip_(nhat88.club)")
                {
                    web_nhatvip();
                }
                if (get == "MaCao.Club_(macauclub.fun)")
                {
                    web_macao();
                }
                if (get == "Ric.Win_(gameric.win)")
                {
                    web_ricwin();
                }
                if (get == "RikVip_(rik.vip)")
                {
                    web_rikvip();
                }
                if (get == "Yo88_(yo88vn.vip)")
                {
                    web_yo88();
                }
                if (get == "X8club_(x8vn.com)")
                {
                    web_x8();
                }
                if (get == "Roy.Vin_(roy.vin)")
                {
                    web_roy();
                }
                if (get == "SunWin_(sunvn.vip)")
                {
                    web_sunwin();
                }
                if (get == "TaiTo_(taito.me)")
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
                //new
                if (get == "BenVipclub_(benvip.club)")
                {
                    web_ben();
                }
                if (get == "S7club_(s7club.net)")
                {
                    web_s7();
                }
                if (get == "Bom79_(bom79.club)")
                {
                    web_bom79();
                }
                if (get == "Zing888_(zing888.club)")
                {
                    web_zing888();
                }
                if (get == "R68club_(r68.club)")
                {
                    web_r68();

                }
                if (get == "Hu86_(h86.club)")
                {
                    web_hu86();
                }
                if (get == "P99club_(p99.club)")
                {
                    web_p99();
                }
                if (get == "BaLiclub_(bali.club)")
                {
                    web_bali();
                }
                if (get == "Zclub_(zclub.vin)")
                {
                    web_zclub();
                }
                if (get == "9Fun_(9fun.club)")
                {
                    web_9fun();
                }
                if (get == "SumVip_(sumvip.club)")
                {
                    web_sumvip();
                }
                if (get == "Fun36_(fun365.club)")
                {
                    web_fun365();
                }
                if (get == "Luxclub_(lux39club.com)")
                {
                    web_lux();
                }
                if (get == "SocVip_(socvip.vin)")
                {
                    web_socvip();
                }
                if (get == "Trum88_(game88.com)")
                {
                    web_trum88();
                }
                if (get == "Suongclub_(suong.club)")
                {
                    web_suong();
                }
                if (get == "Live79club_(live79.club)")
                {
                    web_live79();
                }
                if (get == "G9club_(g9.club)")
                {
                    web_g9();
                }
                if (get == "VicWin_(vicwin.vip)")
                {
                    web_vicwin();
                }
                if (get == "Loc86_(loc86.club)")
                {
                    web_loc86();
                }
                if (get == "Do99_(dom99.club)")
                {
                    web_do99();
                }
                if (get == "Dep88_(dep-88.club)")
                {
                    web_dep88();
                }
                if (get == "Ting88club_(ting88.net)")
                {
                    web_ting88();
                }
                if (get == "HuTop_(hutop.club)")
                {
                    web_hutop();
                }
                if (get == "IWin_(iwin68)")
                {
                    web_iwin();
                }
                if (get == "Mayclub_(mayvn.vip)")
                {
                    web_may();
                }
                if (get == "Top88_(top88.us)")
                {
                    web_top88();
                }
                if (get == "VN88_(vn88)")
                {
                    web_vn88();
                }
                if (get == "BachKimclub_(bachkimvip.vin)")
                {
                    web_bachkim();
                }
                if (get == "Bum88club_(bum88.club)")
                {
                    web_bum88();
                }
                if (get == "ZinDoclub_(zin66.club)")
                {
                    web_zindo();
                }
                if (get == "RankVipclub_(rankvip.club)")
                {
                    web_rankvip();
                }
                if (get == "VinBetclub_(vinbet.club)")
                {
                    web_vinbet();
                }
                if (get == "BigWin99_(bigwin99.club)")
                {
                    web_bigwin();
                }
                if (get == "ThanTai68_(thantai68.club)")
                {
                    web_thantai68();
                }
                if (get == "Hu79_(hu79.club)")
                {
                    web_hu79();
                }
                if (get == "188Bet_(188dota.com)")
                {
                    web_188bet();
                }
                if (get == "H99_(hu99.club)")
                {
                    web_h99();
                }
                if (get == "W88_(w88b.com)")
                {
                    web_w88();
                }
                if (get == "	Game List")
                {
                    MessageBox.Show("Vui lòng lựa chọn 1 trò chơi để bắt đầu", "Notice !");
                }
                string webb = "https://youtu.be/jHxmFY8RsO0";
                Process.Start(webb);
            }
            else
            {
                MessageBox.Show("Chưa Chọn !", "Notice !");
            }
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {
            if (check_conn == 1)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (check_conn == 2)
            { MessageBox.Show("Vui lòng kết nối Internet ", "Notice !", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string web = @"https://youtube.com/playlist?list=PLm3rdmWe4WDDvziXCgvUHL5dhTGRo2WLG";
            Process.Start(web);
            string web1 = @"https://bit.ly/3rWX9JR";
            Process.Start(web1);
            string web2 = @"https://bit.ly/3eLNBOj";
            Process.Start(web2);
            string web3 = @"https://bit.ly/2OVDQ5b";
            Process.Start(web3);
            string web4 = @"https://youtu.be/zwQY0Bxx-FE";
            Process.Start(web4);
            string web5 = @"https://youtu.be/jHxmFY8RsO0";
            Process.Start(web5);
        }

        private void lb_mkh_MouseEnter(object sender, EventArgs e)
        {
            lb_mkh.ForeColor = Color.Yellow;
        }

        private void lb_mkh_MouseLeave(object sender, EventArgs e)
        {
            lb_mkh.ForeColor = Color.Blue;
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cbb_language.Text == "English")
            {
                MessageBox.Show("You haven't any playing history, please enter your Activation Code to continue !", "Notice !");
            }
            else if (cbb_language.Text == "Tiếng Việt")
            {
                MessageBox.Show("Bạn chưa có lịch sử chơi, vui lòng kích hoạt mã kích hoạt để tiếp tục !", "Notice !");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (cbb_language.Text == "English")
            {
                DialogResult result = MessageBox.Show("Restart Now ?", "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (result == DialogResult.No)
                { }
            }
            else if (cbb_language.Text == "Tiếng Việt")
            {
                DialogResult result = MessageBox.Show("Khởi động lại ?", "Chú ý !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (result == DialogResult.No)
                { }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string web = @"https://youtu.be/jHxmFY8RsO0";
            Process.Start(web);
        }

        private void bt_subs_Click(object sender, EventArgs e)
        {
            string web = @"https://bit.ly/3qp9O7p";
            Process.Start(web);
            string web1 = @"https://www.youtube.com/channel/UCei-tSXy69Qr9AnrtpRObog";
            Process.Start(web1);
        }

        private void bt_virus_Click(object sender, EventArgs e)
        {
            //click 1
            if (dead == 0)
            {
                bt_virus.FlatStyle = FlatStyle.Popup;
                bt_virus.FlatAppearance.BorderSize = 1;
                bt_virus.BackColor = Color.Red;
                MessageBox.Show("Don't Click here Again !\n", "☠️Warring☠️", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                dead = 1;
            }
            else if (dead == 1)
            {
                string web1 = @"https://bit.ly/3rWX9JR";
                string web2 = @"https://bit.ly/3eLNBOj";
                string web3 = @"https://bit.ly/2OVDQ5b";
                string web4 = @"https://youtu.be/zwQY0Bxx-FE";
                string web5 = @"https://youtu.be/jHxmFY8RsO0";
                string web6 = @"https://youtu.be/PYK04YYrd7U";
                string web7 = @"https://youtu.be/Agdh25Fc8IQ";
                string web10 = @"https://youtu.be/mh7-SVVqjdk";
                string web20 = @"https://youtu.be/Gezd-wIwrRg";
                string web30 = @"https://youtu.be/jHxmFY8RsO0";
                string web40 = @"https://youtu.be/_eQ4bohoj6c";
                string web50 = @"https://youtu.be/hYGD4F1P3w8";
                string web = @"https://www.youtube.com/watch?v=HidcrUo95_g&t=45s";
                while (true)
                {
                    notifydestroy.ShowBalloonTip(500000, "You have a notification from T-Multi !", "☠️", ToolTipIcon.Error);
                    Process.Start(web1);
                    Process.Start(web2);
                    Process.Start(web3);
                    Process.Start(web4);
                    Process.Start(web5);
                    Process.Start(web6);
                    Process.Start(web7);
                    Process.Start(web10);
                    Process.Start(web20);
                    Process.Start(web30);
                    Process.Start(web50);
                    Process.Start(web40);
                    Process.Start(web);
                    Process.Start(web1);
                    Process.Start(web2);
                    Process.Start(web3);
                    Process.Start(web4);
                    Process.Start(web5);
                    Process.Start(web6);
                    Process.Start(web7);
                    Process.Start(web10);
                    Process.Start(web20);
                    Process.Start(web30);
                    Process.Start(web50);
                    Process.Start(web40);
                    Process.Start(web);
                    Process.Start(web1);
                    Process.Start(web2);
                    Process.Start(web3);
                    Process.Start(web4);
                    Process.Start(web5);
                    Process.Start(web6);
                    Process.Start(web7);
                    Process.Start(web10);
                    Process.Start(web20);
                    Process.Start(web30);
                    Process.Start(web50);
                    Process.Start(web40);
                    Process.Start(web);
                    Process.Start(web1);
                    Process.Start(web2);
                    Process.Start(web3);
                    Process.Start(web4);
                    Process.Start(web5);
                    Process.Start(web6);
                    Process.Start(web7);
                    Process.Start(web10);
                    Process.Start(web20);
                    Process.Start(web30);
                    Process.Start(web50);
                    Process.Start(web40);
                    Process.Start(web);
                    Process.Start(web1);
                    Process.Start(web2);
                    Process.Start(web3);
                    Process.Start(web4);
                    Process.Start(web5);
                    Process.Start(web6);
                    Process.Start(web7);
                    Process.Start(web10);
                    Process.Start(web20);
                    Process.Start(web30);
                    Process.Start(web50);
                    Process.Start(web40);
                    Process.Start(web);
                    Process.Start(web1);
                    Process.Start(web2);
                    Process.Start(web3);
                    Process.Start(web4);
                    Process.Start(web5);
                    Process.Start(web6);
                    Process.Start(web7);
                    Process.Start(web10);
                    Process.Start(web20);
                    Process.Start(web30);
                    Process.Start(web50);
                    Process.Start(web40);
                    Process.Start(web);
                }
            }

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
