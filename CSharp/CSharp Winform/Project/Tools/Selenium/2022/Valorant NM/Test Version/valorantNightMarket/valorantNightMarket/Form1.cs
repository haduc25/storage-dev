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
using OpenQA.Selenium.Support.UI;


namespace valorantNightMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromeDriver driver;
        ChromeOptions options;

        //Path
        string ProfileFolderPath = Application.StartupPath;

        Thread thr;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Cursor == Cursors.Hand)
            {
                //MessageBox.Show("Hand cont...");
                //openSelenium();

                thr = new Thread(browserRunning);
                thr.Start();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" && txtPwd.Text.Trim() != "")
            {
                btnStart.ForeColor = Color.Lime;
                btnStart.Cursor = Cursors.Hand;
            }
            else
            {
                btnStart.ForeColor = Color.Red;
                btnStart.Cursor = Cursors.No;
            }
        }


        //
        private void browserRunning()
        {
            btnStart.ForeColor = Color.Gold;
            btnStart.UseWaitCursor = true;
            //btnStart.Text = "Sending...";
            openSelenium(); // chay browser
            //Thread.Sleep(1000); //current 3s
            //gotoLoginDiscord();
            //Thread.Sleep(5000); //current 3s
            //if (checker1())
            //{
            //    //neu dang o trang discord login -> login
            //    //MessageBox.Show("true");
            //    loginDiscord(txtUser.Text.Trim(), txtPwd.Text.Trim());
            //    //waiting khoang 3-5s de load trang (https://valorant-tracker.com/auth)
            //    Thread.Sleep(3000);

            //}

            ////trang rito account
            //if (checker2())
            //{
            //    Thread.Sleep(3000);
            //    //loginRiotAccount();
            //    //MessageBox.Show("true");
            //}
            //else { MessageBox.Show("fasle2"); }




            //loginFB(txtUser.Text.Trim(), txtPass.Text.Trim());

            //if (checkLogin())
            //{
            //    //MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Something wrong !", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //closeSelenium();

            //reset
            //btnStart.ForeColor = Color.Lime;
            //btnStart.UseWaitCursor = false;
            //btnStart.Text = "Send";
            //btnStart.Focus();

            //Thread.Sleep(1500);
            //sendKeysEnter();

            //openYoutube();
            //addFriend();
            //scrollWebsiteHtml();
            //findInBrowser();

        }

        //
        private void openSelenium()
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
                    options.AddArgument("headless");
                }

                //driver.HideCommandPromptWindow = false;
                //driver = new ChromeDriver(@"D:\Code Developer\CSharp\Winforms\Project 2022\ChromeDriver", options);
                driver = new ChromeDriver(options);
                //driver.HideCommandPromptWindow = false; //hide console

                driver.Navigate().GoToUrl("https://vn.ku6110.net/Home/Index");



                //ChromeDriverService chrService = ChromeDriverService.CreateDefaultService();
                //chrService.HideCommandPromptWindow = false; //hide console

                ////driver = new ChromeDriver("E:/test", options);
                //options.AddArguments("start-maximized");
                ////IWebDriver driver = new ChromeDriver("E:/test", options);
                //driver = new ChromeDriver(@"D:\Code Developer\CSharp\Winforms\Project 2022\ChromeDriver", options);
                ////go valorant store
                //driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth");




                //chrDriver.Navigate().GoToUrl("https://www.google.com");
                //driver.Navigate().GoToUrl("https://www.facebook.com/login");

                //Maximize Browser  
                //driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //discord
        void gotoLoginDiscord()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[3]/button")).Click();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //check weblogin discord
        private bool checker1()
        {
            //if (driver.Url == "https://discord.com/login?redirect_to=%2Foauth2%2Fauthorize%3Fresponse_type%3Dcode%26prompt%3Dnone%26scope%3Didentify%2520guilds%26state%3D7a8f806b06630862925bbc4e7e39972e4248f4a26420f6f9fec07fe324ef43b8%26redirect_uri%3Dhttps%253A%252F%252Fvalorant-tracker.com%252Fapi%252Fauth%252Fcallback%252Fdiscord%26client_id%3D907587023672586251")
            //    return true;
            //else
            //    return false;
            //string text = "ahihi";
            //List<WebElement> list = driver.FindElements(By.XPath("//*[contains(text(),'" + text + "')]"));
            //Assert.assertTrue("Text not found!", list.size() > 0);

            //kt trong url co text = "https://discord.com/login"
            if (driver.Url.Contains("https://discord.com/login"))
                return true;
            return false;
        }

        //check weblogin rito
        private bool checker2()
        {
            if (driver.Url.Contains("https://valorant-tracker.com/auth"))
                return true;
            return false;
        }


        //login
        void loginDiscord(string username, string password)
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id=\"app-mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[1]/div/div[2]/input")).SendKeys(username);
                //pass: //*[@id="app-mount"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[1]/div/div[2]/input

                //nhan tab de doi form
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(2000);

                string txt = string.Empty;

                string answer = password;
                char[] charArray = answer.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    //phim ')'
                    if(charArray[i].ToString() == ")")
                    {
                        txt = "+{0}"; //bat phim (shift + number 0)
                    }                    
                    
                    //phim '('
                    if(charArray[i].ToString() == "(")
                    {
                        txt = "+{9}"; //bat phim (shift + number 9)
                    }


                    //check empty
                    if(String.IsNullOrEmpty(txt))
                    {
                        //neu rong -> k co ky tu dac biet -> press keys binh thuong
                        SendKeys.SendWait(charArray[i].ToString());
                    }
                    else
                    {
                        //neu co kt tu dac biet
                        SendKeys.SendWait(txt);
                    }
                   
                    Thread.Sleep(1000);
                }

                //kiem tra ki tu '(' va  ')'


                //SendKeys.SendWait("{" + password + "}");



                //btn submit: //*[@id="app-mount"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/button[2]
                //driver.FindElement(By.XPath("//*[@id=\"app-mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/button[2]")).Click();


                //user.SendKeys(username);
                //var pass = driver.FindElements(By.XPath("//*[@id=\"app-mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[2]/div/input"));
                //pass.Se

                //driver.FindElements(By.XPath("//*[@id=\"app - mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[1]/div/div[2]/input"))[1].SendKeys(username);
                //driver.FindElements(By.XPath("//*[@id=\"app - mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[1]/div/div[2]/input"))[2].SendKeys(username);
                //driver.FindElements(By.XPath("//*[@id=\"app - mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[2]/div/input"))[3].SendKeys(pass);


                //var zipcodeInput = new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(driver.FindElements(By.XPath("//*[@id=\"app - mount\"]/div[2]/div/div/div/div/form/div/div/div[1]/div[2]/div[1]/div/div[2]/input")));
                //zipcodeInput.Click();
                //zipcodeInput.Clear();
                //zipcodeInput.SendKeys(username);
                //driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[3]/button")).Click();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //login rito

        string user_rito = string.Empty; //ElizabethPeralta19
        string pass_riot = string.Empty;  //MSe47vyxO4

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
                            Thread.Sleep(5000); //current 3s

                            //trang rito account 
                            if (checker2())
                            {
                                Thread.Sleep(3000);

                                user_rito = textUser[i];
                                pass_riot = textPwd[i];
                                //MessageBox.Show(user_rito);

                                //user //*[@id="__next"]/div[2]/section/div[2]/div[1]/div[1]/input
                                driver.FindElements(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[1]/div[1]/input"))[0].SendKeys(user_rito);
                                driver.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass_riot); //chay vao password

                                //SendKeys.SendWait("{TAB}");
                                //SendKeys.SendWait(pass_riot);
                                Thread.Sleep(2000);
                                //an btn: //*[@id="__next"]/div[2]/section/div[2]/div[4]/button
                                driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/section/div[2]/div[4]/button")).Click();



                                //nhan tab de doi form
                                Thread.Sleep(8000);


                                //check dang nhap
                                if (driver.Url == "https://valorant-tracker.com/")
                                {
                                    //dang nhap thanh cong
                                    //MessageBox.Show("dang nhap dc");

                                    ////dong cai quang cao: //*[@id="__next"]/div[2]/div[1]/div[1]/div/div[1]/div/button
                                    //driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div[1]/div[1]/div/div[1]/div/button")).Click();

                                    //vao trang nuon cho no gat
                                    driver.Navigate().GoToUrl("https://valorant-tracker.com/store/night-market"); //vao luon night market

                                    //kiem tra xem vao dc k
                                    if (driver.Url == "https://valorant-tracker.com/store/night-market")
                                    {
                                        Thread.Sleep(2000);

                                        //lay du lieu trong url
                                        getDataFromUrl(user_rito);

                                        //MessageBox.Show("xong ac thu " + i);  
                                        //cho no ra ngoai de vao acc tiep theo
                                        driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth"); //vao luon night market
                                        i++;


                                    }



                                }
                                else
                                {
                                    MessageBox.Show("dang nhap sai");

                                }


                                //MessageBox.Show("true");
                            }
                            else { MessageBox.Show("k phai trang sign in rito"); }




                        }
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        //write to file
        private static string path_passw = Application.StartupPath + "\\Valorant_Account_NM.txt";
        //private static string content = string.Empty;
        
        void write_file_Account(string info_Acc)
        {
            try
            {
                //DirectoryInfo dir_Info = new DirectoryInfo(Application.StartupPath);
                //foreach (FileInfo file_Info in dir_Info.GetFiles("*.txt"))
                //{
                //    file_Info.Delete();
                //}
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



        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnRiot_Click(object sender, EventArgs e)
        {
            thr = new Thread(browserRunning2);
            thr.Start();
        }

        private void browserRunning2()
        {
            openSelenium2(); // chay browser
            loginRiotAccount();

            ////neu dang o trang nm 
            //if (checker3())
            //{
            //    MessageBox.Show("vao check 3");
            //    Thread.Sleep(2000);
            //    try
            //    {
            //        if (count != 0)
            //        {
            //            for (int i = 0; i < count;)
            //            {
            //                user_rito = textUser[i];
            //                //MessageBox.Show(user_rito);
            //                MessageBox.Show("count !=0: " + user_rito + "\ncount: " +count);

            //                //lay du lieu trong url
            //                getDataFromUrl(user_rito);

            //                //xong acc 1 -> chay ra cho dang nhap
            //                i++;
            //                //bat dau ac2
            //                //neu chua dang nhap riot

            //                //vao trang dang nhap
            //                driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth");
            //                Thread.Sleep(1000); //current 3s

            //            }
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }


            //    //MessageBox.Show("Maybe done!");


            //}
            //else
            //{
            //    Thread.Sleep(1000); //current 3s
            //    //neu chua dang nhap riot (hay dung)
            //    if (driver.Url == "https://valorant-tracker.com/discord/auth") //dang o trang dang nhap dis cord co btn
            //    {
            //        //vao trang dang nhap
            //        //driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth");
            //        Thread.Sleep(1000); //current 3s

            //        //an nut
            //        gotoLoginDiscord();
            //        Thread.Sleep(5000); //current 3s

            //        //trang rito account
            //        if (checker2())
            //        {
            //            Thread.Sleep(3000);
            //            if (textUser.Length != 0 || textUser != null)
            //            {
            //                loginRiotAccount();
            //            }
            //            MessageBox.Show("true");
            //        }
            //        else { MessageBox.Show("fasle2"); }
            //    }
            //    else
            //    {
            //        //vao trang dang nhap
            //        driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth");
            //        MessageBox.Show("else chua o trang login, dang o trang dang nhap co 1 button");
            //        Thread.Sleep(1000); //current 3s
            //                            //an nut
            //        gotoLoginDiscord();
            //        Thread.Sleep(5000); //current 3s

            //        //trang rito account
            //        if (checker2())
            //        {
            //            Thread.Sleep(3000);
            //            if (textUser.Length != 0 || textUser != null)
            //            {
            //                loginRiotAccount();
            //            }
            //            MessageBox.Show("true");
            //        }
            //        else { MessageBox.Show("fasle2"); }
            //    }

            //}


        }

            //
            void openSelenium2()
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

                    driver = new ChromeDriver(@"D:\Code Developer\CSharp\Winforms\Project 2022\ChromeDriver", options);
                    //driver.Navigate().GoToUrl("https://valorant-tracker.com/discord/auth");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }


        //check trang nm
        private bool checker3()
        {
            if (driver.Url == "https://valorant-tracker.com/store/night-market")
                return true;
            return false;
        }



        //lay dl trong url // night martket
        private void getDataFromUrl(string user_rito)
        {
            //javaScript
            //driver.ExecuteScript("var content = document.getElementsByClassName('font-georama ml-2 text-white')[0].innerHTML;alert(content);");
            string[] percent = new string[10];
            string[] cost = new string[10];
            string[] name = new string[10];

            string info_account = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                //IJavaScriptExecutor
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;

                //return value (phan tram sale)
                var dataFromJS_Percent = (string)js.ExecuteScript("var sale = document.getElementsByClassName('font-georama ml-2 text-white')[" + i + "].innerHTML;return sale;");
                percent[i] = dataFromJS_Percent;


                //return value (cost)
                //cost:  var content = document.getElementsByClassName('text-white font-georama p-2')[1].children[0].innerHTML; alert(content);
                var dataFromJS_Cost = (string)js.ExecuteScript("var cost = document.getElementsByClassName('text-white font-georama p-2')[" + i + "].children[0].innerHTML; return cost;");
                cost[i] = dataFromJS_Cost;



                //return value (name)
                //name:  var content = document.getElementsByClassName('font-inter uppercase font-bold text-xs text-white')[0].innerHTML; alert(content);
                var dataFromJS_Name = (string)js.ExecuteScript("var name = document.getElementsByClassName('font-inter uppercase font-bold text-xs text-white')[" + i + "].innerHTML; return name;");
                name[i] = dataFromJS_Name;

                info_account = user_rito + "[" + i + "]" + "\tGiảm[" + i + "]: " + percent[i] + " Giá[" + i + "]: " + cost[i] + " Name[" + i + "]: " + name[i];
                write_file_Account(info_account);
            }
        }



        //tao mang
        string[] textUser = new string[200]; //toi da 200
        string[] textPwd = new string[200]; //toi da 200
        int count = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            //string AccountPath = Application.StartupPath + "\\Account";

            ////create folder
            //if (!Directory.Exists(AccountPath))
            //{
            //    //tao folder moi
            //    Directory.CreateDirectory(AccountPath);

            //}

            //if (Directory.Exists(AccountPath))
            //{
            //    MessageBox.Show("co roi");
            //}

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string filePath = string.Empty;
            string fileExt = string.Empty;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //string fileName;

                //fileName = dlg.FileName;
                //MessageBox.Show(fileName);

                filePath = dlg.FileName;
                fileExt = Path.GetExtension(filePath);

                if(fileExt.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filePath);
                        StringBuilder builder = new StringBuilder();
                        string line = string.Empty;
                        string text = string.Empty;


                        int i = 0;
                        while((line = reader.ReadLine()) != null)
                        {
                            //textUser[i] = builder.ToString().Trim();

                            //print
                            builder.AppendLine(line);
                            textUser[i] = builder.ToString().Trim();
                            //MessageBox.Show("textUser thu [" + i + "] = " + textUser[i]);
                            builder.Clear(); //clear text da 
                            count++;
                            i++;

                            //builder.Clear(); //clear text da 
                            //doc dong 1 -> xong dang nhap -> xuat file -> tiep tuc den het

                            //thr = new Thread(browserRunning2);
                            //thr.Start();

                        }

                        //xuat dl...
                        //for (int j = 0; j < i; j++)
                        //{
                        //    MessageBox.Show("Value of txtUser: " + textUser[j]);
                        //}

                        //
                        thr = new Thread(browserRunning2);
                        thr.Start();

                        //MessageBox.Show(builder.ToString());
                        reader.Close();
                        lbFileAccount.Text = "File Password: " + Path.GetFileName(filePath);



                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                            textPwd[i] = builder.ToString().Trim();
                            builder.Clear(); //clear text da 
                            count++;
                            i++;
                        }
                        reader.Close();
                        lbFilePass.Text = "File Password: " + Path.GetFileName(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
        }
    }

}
