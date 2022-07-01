using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;

namespace NightMarketVal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromeDriver driver;
        ChromeOptions options;
        Thread thr;




        //Path
        string ProfileFolderPath = Application.StartupPath;

        //browserRunning
        private void browserRunning()
        {
            openSelenium(); // chay browser
            //loginRiotAccount();
        }

        //openSelenium

        void openSelenium()
        {
            try
            {
                options = new ChromeOptions();

                //create folder
                if (!Directory.Exists(ProfileFolderPath))
                {
                    //tao folder moi
                    Directory.CreateDirectory(ProfileFolderPath);
                }

                if (Directory.Exists(ProfileFolderPath))
                {
                    int count = 1;
                    options.AddArgument("user-data-dir=" + ProfileFolderPath + "\\User_" + count);
                    options.AddArgument(@"profile-directory=" + "User_" + count); //chose profile

                }

                //hide console
                //old path
                //ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"D:\Code Developer\CSharp\Winforms\Project 2022\ChromeDriver\102.0.5005.63");

                //D:\Code Developer\CSharp\Remake\CSharp Winform\Project\Tools\Selenium\ChromeDriver

                //new path
                ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"D:\Code Developer\CSharp\Remake\CSharp Winform\Project\Tools\Selenium\ChromeDriver\102.0.5005.63");
                service.HideCommandPromptWindow = true;


                //


                //options.AddArgument("headless"); //hide browser

                //driver = new ChromeDriver(@"D:\Code Developer\CSharp\Winforms\Project 2022\ChromeDriver", options);
                //driver = new ChromeDriver(@"D:\Code Developer\CSharp\Winforms\Project 2022\ChromeDriver\102.0.5005.63", options);
                //driver.Manage().Window.Position = new Point(3000, 3000);
                //driver = new ChromeDriver(options);

                //options.AddArgument("--window-position=-32000, -32000");

                //driver = new ChromeDriver(service, options);
                driver = new ChromeDriver(service);

               

                driver.Url = "https://vn.ku6110.net/Home/Index";







                //ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                //var checkConsole = service.HideCommandPromptWindow = false; //hide console

                //driver = new ChromeDriver(service);
                //openIncognito();

                //driver.Navigate().GoToUrl(txtUrl.Text.Trim());
                //driver.FindElement(By.XPath("//button[@class='ytp-large-play-button ytp-button']")).Click();

                //Maximize Browser  
                //driver.Manage().Window.Maximize();
                //driver.Manage().Window.Minimize();
                //Thread.Sleep(10000);
                //driver.Navigate().GoToUrl("https://clubloli.com/v/20675/");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //loginRiotAccount
        string user_rito = string.Empty;
        string pass_riot = string.Empty;

        void loginRiotAccount()
        {
            try
            {
                if (textUser.Length != 0 && textPwd.Length != 0 && count != 0 || textUser != null && textPwd != null && count != 0)
                {
                    for (int i = 0; i < count;)
                    {
                        Thread.Sleep(1000); //current 3s
                        //dang o trang co 1 btn dang nhap -> truy cap trang sign in
                        if (driver.Url == "https://valorant-tracker.com/discord/auth") //dang o trang dang nhap dis cord co btn
                        {
                            Thread.Sleep(1000); //current 3s

                            //an nut
                            gotoLoginDiscord();
                            Thread.Sleep(7000); //current 3s

                            //trang rito account 
                            if (checker2())
                            {
                                Thread.Sleep(3000);

                                user_rito = textUser[i];
                                pass_riot = textPwd[i];
                                driver.FindElements(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[1]/div[1]/input"))[0].SendKeys(user_rito);
                                driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass_riot); //chay vao password
                                Thread.Sleep(2000);
                                driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[4]/button")).Click();
                                Thread.Sleep(8000);

                                //check dang nhap
                                if (driver.Url == "https://valorant-tracker.com/")
                                {

                                    //vao trang nuon cho no gat
                                    driver.Navigate().GoToUrl("https://valorant-tracker.com/store/night-market"); //vao luon night market

                                    //kiem tra xem vao dc k
                                    if (driver.Url == "https://valorant-tracker.com/store/night-market")
                                    {
                                        Thread.Sleep(2000);

                                        //lay du lieu trong url
                                        getDataFromUrl(user_rito);

                                        //cho no ra ngoai de vao acc tiep theo
                                        driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth"); //vao luon night market
                                        i++;
                                    }
                                }
                                else{ MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác, vui lòng kiểm tra lại.", "Thông báo");}
                            }
                            else { MessageBox.Show("Lỗi không phải trang đăng nhập... vui lòng  thử lại", "Thông báo"); }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //gotoLoginDiscord
        void gotoLoginDiscord()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[3]/button")).Click();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //getDataFromUrl

        private void getDataFromUrl(string user_rito)
        {
            string[] percent = new string[10];
            int[] percentInt = new int[10]; //su dung de check > 35%
            string[] cost = new string[10];
            string[] name = new string[10];

            //lay acc tren n %
            //int valuePercent = 35; //35%
            int valuePercent = int.Parse(txtPercent.Text.Trim());

            string info_account = string.Empty;
            string info_account2 = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;

                var dataFromJS_Percent = (string)js.ExecuteScript("var sale = document.getElementsByClassName('font-georama ml-2 text-white')[" + i + "].innerHTML;return sale;");

                //xoa dau -, %
                String strClean = dataFromJS_Percent;
                percent[i] = strClean.Replace("-", "").Replace("%", "");

                var dataFromJS_Cost = (string)js.ExecuteScript("var cost = document.getElementsByClassName('text-white font-georama p-2')[" + i + "].children[0].innerHTML; return cost;");
                cost[i] = dataFromJS_Cost;

                var dataFromJS_Name = (string)js.ExecuteScript("var name = document.getElementsByClassName('font-inter uppercase font-bold text-xs text-white')[" + i + "].innerHTML; return name;");
                name[i] = dataFromJS_Name;

                //MessageBox.Show(percent[i]);

                info_account = user_rito + "[" + i + "]" + "\tGiảm[" + i + "]: " + percent[i] + " Giá[" + i + "]: " + cost[i] + " Name[" + i + "]: " + name[i];

                //ep kieu % so sanh
                //int isPercent = int.Parse(percent[i]);
                if (int.Parse(percent[i]) >= valuePercent)
                {
                    info_account2 = user_rito + "\t" + percent[i] + "\t[" + cost[i] + "] => " + name[i];
                    write_file_Account(info_account2, "Valorant_Filter");
                }

                write_file_Account(info_account, "Valorant_Account_NM");
            }
        }

    


        //write_file_Account
        void write_file_Account(string info_Acc, string path)
        {
            //write to file
            string path_passw = Application.StartupPath + "\\" + path + ".txt";
            //MessageBox.Show(path_passw);
            try
            {
                StreamWriter sw = new StreamWriter(path_passw, true);
                if (!String.IsNullOrEmpty(info_Acc))
                {
                    sw.WriteLine(info_Acc);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //checker2
        private bool checker2()
        {
            if (driver.Url.Contains("https://valorant-tracker.com/auth"))
                return true;
            return false;
        }

        //tao mang
        string[] textUser = new string[200]; //toi da 200
        string[] textPwd = new string[200]; //toi da 200
        int count = 0;

        private void btnAcc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string filePath = string.Empty;
            string fileExt = string.Empty;
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                filePath = dlg.FileName;
                fileExt = Path.GetExtension(filePath);

                if (fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filePath);
                        StringBuilder builder = new StringBuilder();
                        string line = string.Empty;
                        string text = string.Empty;

                        int i = 0;
                        while ((line = reader.ReadLine()) != null)
                        {
                            builder.AppendLine(line);
                            textUser[i] = builder.ToString().Trim();
                            builder.Clear(); //clear text da 
                            count++;
                            i++;
                        }
                        //thr = new Thread(browserRunning);
                        //thr.Start();

                        //MessageBox.Show(builder.ToString());
                        reader.Close();
                        lbAcc.Text = Path.GetFileName(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xu ly phan %
            txtPercent.ReadOnly = true;
            if(int.Parse(txtPercent.Text.Trim()) > 34 && int.Parse(txtPercent.Text.Trim()) < 51)
            {
                //phan xu ly file
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                string filePath = string.Empty;
                string fileExt = string.Empty;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.FileName;
                    fileExt = Path.GetExtension(filePath);

                    if (fileExt.CompareTo(".txt") == 0)
                    {
                        try
                        {
                            StreamReader reader = new StreamReader(filePath);
                            StringBuilder builder = new StringBuilder();
                            string line = string.Empty;
                            string text = string.Empty;
                            int i = 0;
                            while ((line = reader.ReadLine()) != null)
                            {
                                builder.AppendLine(line);
                                textPwd[i] = builder.ToString().Trim();
                                builder.Clear(); //clear text da 
                                count++;
                                i++;
                            }
                            thr = new Thread(browserRunning);
                            thr.Start();

                            reader.Close();
                            lbPass.Text = Path.GetFileName(filePath);
                            txtPercent.ReadOnly = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            else {
                MessageBox.Show("Lỗi (Giá trị % >= 35% &  Giá trị % <= 50%) => Vui lòng nhập lại!", "Thông báo");
                txtPercent.ReadOnly = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //String newStr = "haduc123-%";
            //String newStr2 = newStr.Replace("-%", "");
            //MessageBox.Show(newStr2);


            //String newStr2 = "123";
            //int a = int.Parse(newStr2);
            //MessageBox.Show((a + 5).ToString());

            //write_file_Account("abc", "Valorant_Filter");
            //write_file_Account("abc", "Valorant_Account_NM");


            thr = new Thread(browserRunning);
            thr.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPercent.Text = "35";
        }

        private void txtPercent_Click(object sender, EventArgs e)
        {
            txtPercent.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //neu co driver -> thoat driver
            if (driver != null)
            {
                try
                {
                    driver.Dispose();
                    driver.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
            {
                try
                {
                    driver.Dispose();
                    driver.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
