using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HereisTest_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lockApplication();
            tickProgress1();
            tickProgress2();
        }
        //Lock
        private void lockApplication()
        {
            lbTBSuccess.Text = "";
            lbTBSuccess.Enabled = false;
            comboboxSever.Enabled = false;
            comboBoxLogin.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            textBoxAccount.Enabled = false;
            textBoxPasswork.Enabled = false;
            textBoxID.Enabled = false;
            textBox5.Enabled = false;
            checkBoxID.Enabled = false;
            checkBoxYes.Enabled = false;
            checkBoxNo.Enabled = false;
            btPass.Enabled = false;
            btCheck.Enabled = false;
            lbCheckCodeFail.Enabled = false;
            lbCheckCodeSuccess.Enabled = false;
            lbCheckInfo.Enabled = false;
            btUnlock.Enabled = false;
            progressBarLoading1.UseWaitCursor = false;
            progressBarLoading2.UseWaitCursor = false;
            lbSuccesful.Text = "";
            lbData.Text = "";
            tbPrice.ReadOnly = true;
            btCheckPrice.Enabled = false;
        }
        //Unlock
        private void unlockApplication()
        {
            comboboxSever.Enabled = true;
            comboBoxLogin.Enabled = true;
            comboBoxTimeLock.Enabled = true;
            comboBoxTimeLock.Enabled = true;
            textBoxAccount.Enabled = true;
            textBoxPasswork.Enabled = true;
            textBoxID.Enabled = true;
            textBox5.Enabled = true;
            checkBoxID.Enabled = true;
            checkBoxYes.Enabled = true;
            checkBoxNo.Enabled = true;
            btPass.Enabled = true;
            btCheck.Enabled = true;
            btCheckCode.Enabled = false;
            textBox4.ReadOnly = true;
        }
        int a = 0;
        //buttonPasswork
        private void btPass_Click(object sender, EventArgs e)
        {
            textOfbtPass();
        }
        //Passwork
        void textOfbtPass()
        {
            if (btPass.Text == "Show")
            {
                btPass.Text = "Hidden";
                textBoxPasswork.UseSystemPasswordChar = false;
            }
            else
            {
                btPass.Text = "Show";
                textBoxPasswork.UseSystemPasswordChar = true;
            }
        }
        //checkComboboxSever
        void checkcomboboxSever() 
        {
            if (comboboxSever.Text == "PUBG Mobile VNG" || comboboxSever.Text == "PUBG Mobile Global" || comboboxSever.Text == "PUBG Mobile Korean")
            {
                checkIDofbtCheck();
            }
            else
            {
                MessageBox.Show("'Sever' không hợp lệ, Vui lòng chọn lại_[123]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkInfoError();
            }
        }
        //CheckCombobox2
        void checkCombobox2()
        {
            if (comboBoxTimeLock.Text == "Khóa 10 năm" || comboBoxTimeLock.Text == "Khóa vĩnh viễn")
            {
                checkcomboboxSever();
            }
            else
            {
                MessageBox.Show("'Hạn khóa' không hợp lệ, Vui lòng chọn lại_[100]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkInfoError();
            }
        }
        //Combobox
        void checkCombobox1()
        {
            if (comboBoxLogin.Text == "Accout Google" || comboBoxLogin.Text == "Facebook" || comboBoxLogin.Text == "Twitter")
            {
                checkCombobox2();
            }
            else
            {
                MessageBox.Show("Đăng nhập không hợp lệ, Vui lòng chọn lại [101]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkInfoError();
            }
        }
        //ID
        void checkID()
        {
            int Value = 0;
            if (Int32.TryParse(textBoxID.Text, out Value))
            {
                if (999999999 < Convert.ToInt32(textBoxID.Text) && Convert.ToInt32(textBoxID.Text) < 9999999999)
                { }
                else
                {
                    MessageBox.Show("ID không phù hợp, vui lòng nhập lại[102]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textBoxID.Enabled == false)
                { }
                else
                {
                    MessageBox.Show("ID không phù hợp, vui lòng nhập lại[103]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //Lock application after Checklock Succesful
        void lockAppafterCheckSuccess()
        {
            comboboxSever.Enabled = false;
            btUnlock.Enabled = true;
            btCheck.Enabled = false;
            comboBoxLogin.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            textBoxAccount.ReadOnly = true;
            textBoxPasswork.ReadOnly = true;
            textBoxID.ReadOnly = true;
            textBox5.ReadOnly = true;
            checkBoxID.Enabled = false;
            lbCheckInfo.Text = "";
            lbSuccesful.Text = "Thành công";
        }
        //CheckID of btCheck Succesful
        void checkIDofbtCheck()
        {
            int Value = 0;
            if (Int32.TryParse(textBoxID.Text, out Value))
            {
                if (999999999 < Convert.ToInt32(textBoxID.Text) && Convert.ToInt32(textBoxID.Text) < 9999999999)
                {
                    lockAppafterCheckSuccess();
                }
                else
                {
                    MessageBox.Show("ID không phù hợp, vui lòng nhập lại[104]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textBoxID.Enabled == false)
                { lockAppafterCheckSuccess(); }
                else
                {
                    MessageBox.Show("ID không phù hợp, vui lòng nhập lại[105]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //Check Info Error
        void checkInfoError()
        {
            lbCheckInfo.Enabled = true;
            lbCheckInfo.Text = "Vui lòng nhập đủ thông tin !";
        }
        //START
        
        //END
        //Xử lí if,else
        void checkTextbox()
        {
            if (textBoxAccount.Text == "" || textBoxPasswork.Text == "" || textBoxID.Text == "" || checkBoxYes.Enabled == true || checkBoxNo.Enabled == true)
            {
                if (textBoxID.Text == "" && textBoxID.Enabled == true)
                {
                    MessageBox.Show("Chưa nhập 'ID' [127]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else
                {
                    if (textBoxID.Text == "" && textBoxID.Enabled == false)
                    {
                        checkCombobox1(); 
                    }
                    else { }
                }
                if (textBox5.Enabled == false)
                {
                    textBox5.Text = " ";
                }
                else { }
                if (textBoxAccount.Text == "")
                {
                    MessageBox.Show("Chưa nhập 'Tài khoản' [125]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else { }
                if (textBoxPasswork.Text == "")
                {
                    MessageBox.Show("Chưa nhập 'Mật khẩu' [126]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else { }
                checkID();
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Chưa nhập 'Tên NV' [128]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else { }
                if (checkBoxYes.Enabled == true || checkBoxNo.Enabled == true)
                {
                    MessageBox.Show("Vui lòng chọn sử dụng Script hay không ? [124]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else { }
            }
            else
            {
                if (textBoxAccount.Text != "" && textBoxPasswork.Text != "" && textBoxID.Text != "" && textBox5.Text != "")
                {
                    if (checkBoxYes.Checked == true || checkBoxNo.Checked == true)
                    {
                        checkCombobox1();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn sử dụng Script hay không ? [2]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkInfoError();
                    }
                }
                else { checkTextbox(); }
            }
        }
        //Check
        private void btCheck_Click(object sender, EventArgs e)
        {
            checkTextbox();
        }

        //CheckBox
        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBoxID.Checked = false;
            DialogResult dialogR;
            dialogR = MessageBox.Show("Bạn có chắc là Quên ID ? [106]", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogR == DialogResult.Yes)
            {
                checkBoxID.Checked = true;
                checkBoxID.Enabled = false;
                textBoxID.Enabled = false;
                textBoxID.Text = "";
            }
            else { }
            if (dialogR == DialogResult.No)
            {
                checkBoxID.Checked = false;
            }
            else { }
        }
        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBoxYes.Checked = false;
            DialogResult dialogR;
            dialogR = MessageBox.Show("Bạn có chắc muốn sử dụng Script ? [107]", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogR == DialogResult.Yes)
            {
                checkBoxYes.Checked = true;
                checkBoxYes.Enabled = false;
                checkBoxNo.Enabled = false;
            }
            else { }
            if (dialogR == DialogResult.No)
            {
                checkBoxYes.Checked = false;
            }
            else { }
        }
        private void checkBox4_Click(object sender, EventArgs e)
        {
            checkBoxNo.Checked = false;
            checkBoxNo.Checked = false;
            DialogResult dialogR;
            dialogR = MessageBox.Show("Bạn có chắc không muốn sử dụng Script ? [108]", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogR == DialogResult.Yes)
            {
                checkBoxNo.Checked = true;
                checkBoxNo.Enabled = false;
                checkBoxYes.Enabled = false;
            }
            else { }
            if (dialogR == DialogResult.No)
            {
                checkBoxNo.Checked = false;
            }
            else { }
        }
        //Reset
        void Reset()
        {
            checkBoxID.Enabled = true;
            checkBoxYes.Enabled = true;
            checkBoxNo.Enabled = true;
            textBoxAccount.Enabled = true;
            textBoxPasswork.Enabled = true;
            textBoxID.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            btCheck.Enabled = true;
            btUnlock.Enabled = true;
            unlockApplication();
        }
        //Lock Unlock
        void LockUnlockCode() 
        {
            btCheckCode.Enabled = false;
            textBox4.ReadOnly = true;
            MessageBox.Show("Bạn nhập sai quá nhiều nên sẽ tạm khóa, Vui lòng thử lại ! [129]","Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
            youtubeAll();
        }
        //YoutubeAll
        void youtubeAll() 
        {
            string LinkYT1 = @"https://youtu.be/tIZeb77JKD4";
            string LinkYT2 = @"https://youtu.be/UhEGa52-cAA";
            string LinkYT3 = @"https://youtu.be/iebE-S0ku-s";
            string LinkYT4 = @"https://youtu.be/8mVTyZLrpvg";
            string LinkYT5 = @"https://youtu.be/VYZPL3GuwhU";
            string LinkYT6 = @"https://youtu.be/6r1Rg0gAicg";
            Process.Start(LinkYT1);
            Process.Start(LinkYT2);
            Process.Start(LinkYT3);
            Process.Start(LinkYT4);
            Process.Start(LinkYT5);
            Process.Start(LinkYT6);
            MessageBox.Show("Youtube: Hi Luv", "Youtube Me: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void defaultForApp() 
        {
            btPass.Enabled = true;
            btCheck.Enabled = true;
            btCheckCode.Enabled = false;
            textBox4.ReadOnly = true;
            tbPrice.Text = "";
            textBoxID.Text = "";
            lbCheckCodeFail.Enabled = false;
            lbCheckCodeFail.Text = "";
            lbCheckCodeSuccess.Enabled = true;
            lbCheckCodeSuccess.Text = "Thành Công !";
            btCheckPrice.Enabled = false;
            btModeP.Enabled = false;
            tbPrice.ReadOnly = true;
        }
        void forNOScript() 
        {
            comboboxSever.Enabled = true;
            comboBoxLogin.Enabled = true;
            comboBoxTimeLock.Enabled = true;
            comboBoxTimeLock.Enabled = true;
            textBoxAccount.Enabled = true;
            textBoxPasswork.Enabled = true;
            textBoxID.Enabled = true;
            textBox5.Enabled = true;
            checkBoxID.Enabled = true;
            checkBoxYes.Enabled = false;
            checkBoxYes.Checked = false;
            checkBoxNo.Checked = true;
            checkBoxNo.Enabled = false;
            btPass.Enabled = true;
            btCheck.Enabled = true;
            btCheckCode.Enabled = false;
            textBox4.ReadOnly = true;
        }
        //CheckCode //code
        private void checkCode()
        {
            //Code[2509]
            //Main
            string Code01 = "OZCB0irMymiKZRn";
            string Code02 = "oUae4AUnIgdZaRj";
            string Code03 = "Ro5MPv38bF8TvDV";
            string Code04 = "MtKNNbMMPTgORPM";
            string Code05 = "xW0iNnUyDhdt810";
            string Code06 = "oHFAPE1XL6a32u5";
            string Code07 = "EcVyI0sPNwkMSZa";
            string Code08 = "GTvWkZBlnhJNlPC";
            string Code09 = "tCY57ED1Z8m6CGK";
            string Code10 = "V5gMGC9vx0bH2dK";
            string Code11 = "lpdRmUwHE3ptlG5";
            string Code12 = "LsJAh3pxMZuaoQX";
            string Code13 = "Ie6HJGmEfVsXAlz";
            string Code14 = "w3zx4X3ZGOdub7c";
            string Code15 = "FbWd2gM9tg5PpZq";
            string Code16 = "oWc0IVfiSBA5U4Z";
            string Code17 = "RKV4I8EAERL3bmf";
            string Code18 = "zUDXOlCv7VmeFOc";
            string Code19 = "vCh80nqscsWL2DN";
            string Code20 = "DazKc1qpsXz9nxK";
            //Code No Script
            string CodeNoScript1 = "CjxWQcvu19k48SA";
            string CodeNoScript2 = "RszVdxhbCqhxoUP";
            string CodeNoScript3 = "Sb7kwJ8R7e28fW7";
            string CodeNoScript4 = "Hal7r1ltn9B4ZVN";
            string CodeNoScript5 = "swrXu4DdltcNj2Z";
            string CodeNoScript6 = "UmjXOCqPf2HTEkl";
            string CodeNoScript7 = "RPlBrhfr045QY2j";
            string CodeNoScript8 = "tVELN3nqRgf1K9x";
            string CodeNoScript9 = "0Rbs4u5ck9nR6ah";
            string CodeNoScript10 = "wNhW99pG2FGQYkl";
            //Code Recybin
            string CodeUsed = "2Twy6nuO2QAil5C";
            //Codecase1:
             if (textBox4.Text == Code01 || textBox4.Text == Code02 || textBox4.Text == Code03 || textBox4.Text == Code04 || textBox4.Text == Code05 || textBox4.Text == Code06 || textBox4.Text == Code07 || textBox4.Text == Code08 || textBox4.Text == Code09 || textBox4.Text == Code10 || textBox4.Text == Code11 || textBox4.Text == Code12 || textBox4.Text == Code13 || textBox4.Text == Code14 || textBox4.Text == Code15 || textBox4.Text == Code16 || textBox4.Text == Code17 || textBox4.Text == Code18 || textBox4.Text == Code19 || textBox4.Text == Code20)
            {
                defaultForApp();
                unlockApplication();
            }
            else
            {
                //code su dung
                if(textBox4.Text == CodeUsed) 
                {
                    MessageBox.Show("Mã này đã được sử dụng vui lòng thử lại", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (textBox4.Text == "")
                {
                    lbCheckCodeSuccess.Enabled = false;
                    lbCheckCodeFail.Enabled = true;
                    lbCheckCodeFail.Text = "Vui lòng nhập mã !";
                    MessageBox.Show(" [" + a + "]_Bạn chưa nhập mã ! [130]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    a++;
                    if (a >= 21)
                    {
                        LockUnlockCode();
                    } 
                    else { }
                }
                else
                {
                    if (textBox4.Text == CodeNoScript1 || textBox4.Text == CodeNoScript2 || textBox4.Text == CodeNoScript3 || textBox4.Text == CodeNoScript4 || textBox4.Text == CodeNoScript5 || textBox4.Text == CodeNoScript6 || textBox4.Text == CodeNoScript7 || textBox4.Text == CodeNoScript8 || textBox4.Text == CodeNoScript9 || textBox4.Text == CodeNoScript10)
                    {
                        lbCheckCodeFail.Enabled = false;
                        lbCheckCodeSuccess.Enabled = true;
                        lbCheckCodeFail.Text = "";
                        //lbCheckCodeSuccess.Text = "Succces !!!";
                        defaultForApp();
                        forNOScript();

                    }
                    else 
                    {
                        lbCheckCodeSuccess.Enabled = false;
                        lbCheckCodeFail.Enabled = true;
                        lbCheckCodeFail.Text = "Mã vừa nhập không chính xác hoặc đã được sử dụng, vui lòng nhập lại ! [109]";
                        a++;
                        MessageBox.Show(" [" + a + "]_Code Unlock không phù hợp, vui lòng nhập lại [110]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (a >= 21)
                        {
                            LockUnlockCode();
                        }
                        else { }
                    }
                   
                }
            }
        }
        private void btCheckCode_Click(object sender, EventArgs e)
        {
            checkCode();
        }
        //Gmail
        void Gmail()
        {
            DialogResult dialogR;
            string LinkGmail = @"https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            dialogR = MessageBox.Show("Bạn có muốn mở gmail ? [111]", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogR == DialogResult.OK)
            {
                Process.Start(LinkGmail);
                MessageBox.Show("Hereisjobbro1@gmail.com", "Gmail Me: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { }
        }
        private void btGmail_Click(object sender, EventArgs e)
        {
            Gmail();
        }
        //Youtube
        void Youtube()
        {
            DialogResult dialogR;
            string LinkYoutube = @"https://www.youtube.com/channel/UCei-tSXy69Qr9AnrtpRObog?view_as=subscriber";
            dialogR = MessageBox.Show("Bạn có muốn mở youtube ? [112]", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogR == DialogResult.OK)
            {
                Process.Start(LinkYoutube);
                MessageBox.Show("Youtube: Hi Luv", "Youtube Me: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { }
        }
        private void btYoutube_Click(object sender, EventArgs e)
        {
            Youtube();
        }
        //Zalo
        void Zalo()
        {
            DialogResult dialogR;
            string LinkZalo = @"https://id.zalo.me/account?continue=https%3A%2F%2Fchat.zalo.me%2F";
            dialogR = MessageBox.Show("Bạn có muốn mở zalo ? [113]", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogR == DialogResult.OK)
            {
                Process.Start(LinkZalo);
                MessageBox.Show("0936813561", "Zalo Me: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { }
        }
        private void btZalo_Click(object sender, EventArgs e)
        {
            Zalo();
        }
        //Script
        private void btScript_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Script sử dụng để unlock thêm 1 số tính năng trong tài khoản khi bị khóa như:\n+Trang phục\n+Rank\n+Level\n+Skin súng\n+Nhiệm vụ\n+Bạn bè\n+Royale pass\n+BP\n+UC\n2.Khi bạn muốn sử dụng Script chỉ cần tìm đến Script và click vào 'Sử dụng'\nKhi bạn không sử dụng 'Script' tài khoản của bạn khi mở sẽ như ban đầu lập tài khoản", "Notification Script-[131]");
        }
        //Tutorial
        private void btTutorial_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("1.Nhập mã và chọn Kiểm tra mã\n*Mã vui lòng liên hệ qua Gmail hoặc Zalo\n2.Kiểm tra thành công bạn cần nhập nhưng thông tin về tài khoản của bạn như:\n+Sever\n+Hạn khóa\n+Phương thức đăng nhập\n+Tài khoản\n+Mật khẩu\n+Tên nhân vật\n+ID\n*Nếu bạn quên ID thì vui lòng chọn vào 'Quên'\n+Script\n*Script: khi bạn chọn 'Sử dụng' thì sẽ mở khóa thêm nhiều vật phẩm khác trong tài khoản, xem thêm vui lòng chọn 'Script' bên trên\n3.Sau khi đã nhập đủ thông tin vui lòng chọn vào kiểm tra\n4.Chọn 'Unlock Now' và đợi\n5.Sau khi đã xong các bước trên vui lòng khởi động lại game", "Notification Tutorial-[132]");
            
        }
        //Lưu ý
        private void btLuuY_Click(object sender, EventArgs e)
        {
            Reset();
        }
        //Tick
        int n1 = 1;
        int n2 = 1;
        int x1 = 0;
        int x2 = 0;
        //Check Max1
        void checkMaxProgress1()
        {
            if (progressBarLoading1.Value == progressBarLoading1.Maximum)
            {
                lbProgress1.Text = "Successful!";
                timer1.Stop();
                timer2.Start();
            }
        }
        //Check Max2
        void checkMaxProgress2()
        {
            if (progressBarLoading2.Value == progressBarLoading2.Maximum)
            {
                btUnlock.Text = "Mở khóa";
                lbProgress2.Text = "Successful!";
                timer2.Stop();
                timer3.Stop();
                progressBarLoading1.UseWaitCursor = false;
                progressBarLoading2.UseWaitCursor = false;
                lbData.Text = "";
                btSuccess.Text = "Thành Công";
                MessageBox.Show("Thành công! [114]\nKhởi động lại game để lưu thay đổi.", "Notification");
                lbTBSuccess.Enabled = true;
                lbTBSuccess.Text = "Vui lòng khởi động lại game";
               // youtubeAll();
            }
        }
        //tick1
        void tickProgress1()
        {
            //[2509201]
            progressBarLoading1.Step = 1;
            progressBarLoading1.Maximum = 1000;
            progressBarLoading1.Value = 0;
            timer1.Interval = 100;
        }
        //tick2
        void tickProgress2()
        {
            progressBarLoading2.Step = 1;//1
            progressBarLoading2.Maximum = 1000; //10000
            progressBarLoading2.Value = 0;
            timer1.Interval = 100;
        }
        //Check Timer1
        void checkMaxTimer1()
        {
            if (n1 ==10)
            {
                n1 = 0;
                x1++;
                if (x1 == 100)
                {
                    n1 = -999;
                }
                else
                { }
            }
            else
            { }
        }
        //Check Timer2
        void checkMaxTimer2()
        {
            if (n2 == 10) //100
            {
                n2 = 0;
                x2++;
                if (x2 == 100) //100
                {
                    n2 = -999;
                }
                else { }
            }
            else { }
        }
        //Timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarLoading1.ForeColor = Color.White;
            try
            {
                n1++;
                btUnlock.Enabled = false;
                progressBarLoading1.UseWaitCursor = true;
                progressBarLoading2.UseWaitCursor = true;
                btUnlock.Text = "Loading...";
                checkMaxTimer1();
                progressBarLoading1.PerformStep();
                lbValuex1.Text = x1.ToString() + " %";
                lbProgress1.Text = "Loading...[116]";
                //maximunForN();
                //tickTest();
                checkMaxProgress1();
            }
            catch(Exception ) { }
        }
        //Timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
            n2++;
            checkMaxTimer2();
            progressBarLoading2.PerformStep();
            lbValuex2.Text = x2.ToString() + " %";
            lbProgress2.Text = "Loading...[117]";
            checkMaxProgress2();
        }
        //UnlockAccount
        void testProces()
        {
            progressBarLoading1.Value = 100;
        }
        private void btUnlock_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Start();
        }
        //Random
        void randString()
        {
            Random rand = new Random();
            int hello = rand.Next(1, 51);
            switch (hello)
            {
                case 1:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Pubgmobile\\script\\on...";
                        break;
                    }
                case 2:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Pubgmobile\\Unlock\\ID...";
                        break;
                    }
                case 3:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Pubgmobile\\Skin\\Outfit...";
                        break;
                    }
                case 4:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Pubgmobile\\Rank...";
                        break;
                    }
                case 5:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Pubgmobile\\Unlock\\...";
                        break;
                    }
                case 6:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Open\\84811618\\account...";
                        break;
                    }
                case 7:
                    {
                        lbData.Text = "C:\\Users\\Desktop\\System\\script...";
                        break;
                    }
                case 8:
                    {
                        lbData.Text = "C:\\Windows\\System\\471410970...";
                        break;
                    }
                case 9:
                    {
                        lbData.Text = "C:\\Pubgmobile\\Unlock\\on\\script...";
                        break;
                    }
                case 10:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Unlock\\847wed770\\time\\...";
                        break;
                    }
                case 11:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Skin\\royalepass...";
                        break;
                    }
                case 12:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Account\\Royalepass...";
                        break;
                    }
                case 13:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Pubgmobile\\Royalepass...";
                        break;
                    }
                case 14:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Unlock\\Rank...";
                        break;
                    }
                case 15:
                    {
                        lbData.Text = "C:\\Users\\Admin\\PubgMobile\\...";
                        break;
                    }
                case 16:
                    {
                        lbData.Text = "C:\\Users\\Admin\\81tg2828\\location\\file...";
                        break;
                    }
                case 17:
                    {
                        lbData.Text = "C:\\Users\\Desktop\\System\\script...";
                        break;
                    }
                case 18:
                    {
                        lbData.Text = "C:\\Windows\\System\\10year\\ID...";
                        break;
                    }
                case 19:
                    {
                        lbData.Text = "C:\\System\\Pubgmobile\\Account\\Skin...";
                        break;
                    }
                case 20:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Script\\Message...";
                        break;
                    }
                case 21:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Facebook\\Friend\\ID...";
                        break;
                    }
                case 22:
                    {
                        lbData.Text = "C:\\Users\\Admin\\PubgMobile\\Account...";
                        break;
                    }
                case 23:
                    {
                        lbData.Text = "C:\\Users\\Admin\\BlueStack\\Account...";
                        break;
                    }
                case 24:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Sever\\Debug\\Log...";
                        break;
                    }
                case 25:
                    {
                        lbData.Text = "C:\\Users\\Admin\\ID=~811794526...";
                        break;
                    }
                case 26:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Perfoment\\Setting...";
                        break;
                    }
                case 27:
                    {
                        lbData.Text = "C:\\Users\\BlueStack\\PubgMobile\\Controller...";
                        break;
                    }
                case 28:
                    {
                        lbData.Text = "C:\\Windows\\System\\Account\\Unlock\\Script...";
                        break;
                    }
                case 29:
                    {
                        lbData.Text = "C:\\Pubgmobile\\Unlock\\BlueStack\\Outfit...";
                        break;
                    }
                case 30:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Unlock\\Skin...";
                        break;
                    }
                case 31:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Rank\\PubgMobile...";
                        break;
                    }
                case 32:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Royalepass\\CheckLog...";
                        break;
                    }
                case 33:
                    {
                        lbData.Text = "C:\\Users\\Admin\\CheckBug\\Unlock...";
                        break;
                    }
                case 34:
                    {
                        lbData.Text = "C:\\Users\\Admin\\84948159\\Setup...";
                        break;
                    }
                case 35:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Cell\\Script\\run\\object...";
                        break;
                    }
                case 36:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Open\\find\\ID\\8171519464...";
                        break;
                    }
                case 37:
                    {
                        lbData.Text = "C:\\Users\\Over\\Stack\\Log\\Unlock\\PubgMobile...";
                        break;
                    }
                case 38:
                    {
                        lbData.Text = "C:\\Windows\\System\\Tencent\\Sever\\PubgVNG...";
                        break;
                    }
                case 39:
                    {
                        lbData.Text = "C:\\Pubgmobile\\Global\\sevice\\feedback";
                        break;
                    }
                case 40:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Feedback\\unlock...";
                        break;
                    }
                case 41:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Support\\VPN...";
                        break;
                    }
                case 42:
                    {
                        lbData.Text = "C:\\Users\\Admin\\VPN\\on\\FeedBack...";
                        break;
                    }
                case 43:
                    {
                        lbData.Text = "C:\\Users\\Admin\\PubgMobile\\Korean\\Account...";
                        break;
                    }
                case 44:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Bluehouse\\PubgMobile...";
                        break;
                    }
                case 45:
                    {
                        lbData.Text = "C:\\Users\\Admin\\BlueStack\\PubgMobile\\Global...";
                        break;
                    }
                case 46:
                    {
                        lbData.Text = "C:\\Users\\Admin\\Open\\VPN\\on...";
                        break;
                    }
                case 47:
                    {
                        lbData.Text = "C:\\Users\\Desktop\\System\\Script\\off\\unlock...";
                        break;
                    }
                case 48:
                    {
                        lbData.Text = "C:\\Windows\\System\\FeedBack\\Skin...";
                        break;
                    }
                case 49:
                    {
                        lbData.Text = "C:\\Game\\Pubgmobile\\Unlock\\Royalepass...";
                        break;
                    }
                case 50:
                    {
                        lbData.Text = "C:\\User\\Admin\\Unlock\\Succesful\\...";
                        break;
                    }

            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            randString();
        }
        //LockAppSuccessforModePrice
        void lockAppSuccessforModePrice()
        {
            btUnlock.Enabled = false;
            btCheck.Enabled = false;
            comboBoxLogin.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            textBoxAccount.ReadOnly = true;
            textBoxPasswork.ReadOnly = true;
            textBoxID.ReadOnly = true;
            textBox5.ReadOnly = true;
            checkBoxID.Enabled = false;
            lbCheckInfo.Text = "";
            //lbSuccesful.Text = "";
        }
        //CheckIDforModePrice
        void checkIDofModePrice()
        {
            int Value = 0;
            if (Int32.TryParse(textBoxID.Text, out Value))
            {
                if (999999999 < Convert.ToInt32(textBoxID.Text) && Convert.ToInt32(textBoxID.Text) < 9999999999)
                {
                    lockAppSuccessforModePrice();
                    calculatorPrice();
                }
                else
                {
                    MessageBox.Show("ID không phù hợp, vui lòng nhập lại [118]", "Notification");
                }
            }
            else
            {
                if (textBoxID.Enabled == false)
                { }
                else
                {
                    MessageBox.Show("ID không phù hợp, vui lòng nhập lại [119]", "Notification");
                }
            }

        }
        //CheckCombobox for Mode Price
        void checkComboboxForModePrice1()
        {
            if (comboBoxTimeLock.Text == "Khóa 10 năm" || comboBoxTimeLock.Text == "Khóa vĩnh viễn")
            {
                checkIDofModePrice();
            }
            else
            {
                MessageBox.Show("Hạn khóa không hợp lệ, Vui lòng chọn lại [119]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkInfoError();
            }
        }
        //checkPrice
        void checkPrice()
        {
            if (textBoxID.Text == "" || checkBoxYes.Enabled == true || checkBoxNo.Enabled == true)
            {
                if (textBoxID.Text == "" && textBoxID.Enabled == true)
                {
                    MessageBox.Show("Chưa nhập 'ID' [121]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else
                {
                    calculatorPrice();
                }
                //checkID();
                if (checkBoxYes.Enabled == true || checkBoxNo.Enabled == true)
                {
                    MessageBox.Show("Vui lòng chọn sử dụng Script hay không ? [122]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkInfoError();
                }
                else { }
            }
            else
            {
                if (textBoxID.Text != "")
                {

                    if (checkBoxYes.Checked == true || checkBoxNo.Checked == true)
                    {
                         checkComboboxForModePrice1();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn sử dụng Script hay không ? [119]", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkInfoError();
                    }
                }
                else { checkPrice(); }
            }
        }
        //Price
        int code = 200000;
        int temp = 0;
        int id = 50000;
        int script = 100000;
        int tenyear = 150000;
        int neverUnlock = 500000;
        void calculatorPrice()
        {
            //259201
            try
            {
                if (comboBoxTimeLock.Text == "Khóa 10 năm" || comboBoxTimeLock.Text == "Khóa vĩnh viễn")
                {
                    //case1:
                    if (comboBoxTimeLock.Text == "Khóa 10 năm")
                    {
                        //Yes ID/use
                        if (checkBoxID.Checked == false && checkBoxYes.Checked == true && checkBoxNo.Checked == false)
                        {
                            temp = tenyear + code + script;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                        //No ID/Use
                        if (checkBoxID.Checked == true && checkBoxYes.Checked == true && checkBoxNo.Checked == false)
                        {
                            temp = tenyear + code + id + script;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                        //Yes ID /Not Use
                        if (checkBoxID.Checked == false && checkBoxYes.Checked == false && checkBoxNo.Checked == true)
                        {
                            temp = tenyear + code;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                        //No/Not use
                        if (checkBoxID.Checked == true && checkBoxYes.Checked == false && checkBoxNo.Checked == true)
                        {
                            temp = tenyear + code + id;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                    }
                    else { }
                    //case2:
                    if (comboBoxTimeLock.Text == "Khóa vĩnh viễn")
                    {
                        //Yes ID/use
                        if (checkBoxID.Checked == false && checkBoxYes.Checked == true && checkBoxNo.Checked == false)
                        {
                            temp = neverUnlock + code + script;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                        //No ID/Use
                        if (checkBoxID.Checked == true && checkBoxYes.Checked == true && checkBoxNo.Checked == false)
                        {
                            temp = neverUnlock + code + id + script;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                        //Yes ID /Not Use
                        if (checkBoxID.Checked == false && checkBoxYes.Checked == false && checkBoxNo.Checked == true)
                        {
                            temp = neverUnlock + code;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                        //No/Not use
                        if (checkBoxID.Checked == true && checkBoxYes.Checked == false && checkBoxNo.Checked == true)
                        {
                            temp = neverUnlock + code + id;
                            tbPrice.Text = temp.ToString();
                        }
                        else { }
                    }
                    else { }
                }
                else
                {
                    checkInfoError();
                }
            }
            catch (Exception)
            { }
        }
        //Button Check  Price
        private void btCheckPrice_Click(object sender, EventArgs e)
        {
            checkPrice();
        }
        //Mode price
        private void lockAppforModePrice()
        {
            comboBoxLogin.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            comboBoxTimeLock.Enabled = false;
            textBoxAccount.Enabled = false;
            textBoxPasswork.Enabled = false;
            textBoxID.ReadOnly = true;
            checkBoxID.Enabled = false;
            checkBoxYes.Enabled = false;
            checkBoxNo.Enabled = false;
            btPass.Enabled = false;
            btCheck.Enabled = false;
            lbCheckCodeFail.Enabled = false;
            lbCheckCodeSuccess.Enabled = false;
            lbCheckInfo.Enabled = false;
            btUnlock.Enabled = false;
            progressBarLoading1.UseWaitCursor = false;
            progressBarLoading2.UseWaitCursor = false;
            lbSuccesful.Text = "";
            lbData.Text = "";
        }
        private void unlockAppforModePrice()
        {
            lbCheckInfo.Text = "";
            comboBoxTimeLock.Text = "Vui lòng lựa chọn";
            textBox5.Text = "";
            textBoxID.Text = "";
            checkBoxID.Checked = false;
            checkBoxYes.Checked = false;
            checkBoxNo.Checked = false;
            comboBoxTimeLock.Enabled = true;
            comboBoxTimeLock.Enabled = true;
            textBoxID.ReadOnly = false;
            textBoxID.Enabled = true;
            checkBoxID.Enabled = true;
            checkBoxYes.Enabled = true;
            checkBoxNo.Enabled = true;
            btPass.Enabled = true;
            btCheck.Enabled = false;
            btPass.Enabled = false;
            btUnlock.Enabled = false;
            btCheckPrice.Enabled = true;
            tbPrice.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            unlockAppforModePrice();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true; //Hàm Hủy Even
            }
            else
            {
                MessageBox.Show("💓Thanks for Anything !💓", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btPriceList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Mã khóa:\t+200.000 VND\n2.Quên ID:\t+50.000   VND\n3.Sử dụng Script:\t+100.000 VND\n4.Hạn khóa:\n*10 Năm\t\t+150.000 VND\n*Vĩnh viễn\t+500.000 VND\n\nHƯỚNG DẪN KIỂM TRA GIÁ\n1.Ấn vào 'More'\n2.Chọn hạn khóa\n3.Chọn ID\n4.Chọn Script\n5.Chọn 'Check Price'\n6.Xem giá tại 'Price'", "Notification Price List-[132]");
        }
        //Reset Now
        private void label5_Click(object sender, EventArgs e)
        {
           // Reset();
        }
        void Reset1() 
        {
            textBox4.ReadOnly = false;
            textBox4.Text = "";
            btCheckCode.Enabled = true;
        }
        private void label9_Click(object sender, EventArgs e)
        {
           // Reset1();
        }
    }
}
