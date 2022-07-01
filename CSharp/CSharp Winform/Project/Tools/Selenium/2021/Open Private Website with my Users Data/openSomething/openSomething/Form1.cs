using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace openSomething
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            currentSetting();
        }

        ChromeDriver driver;
        ChromeOptions options;
        Thread thr;
        Thread thr1;

        //Path
        string ProfileFolderPath = Application.StartupPath + "Profile";


        private void textChangeBoth(object sender, EventArgs e)
        {
            //txtBoth(url + tk)
            if (txtUrl.Text.Trim() != "")
            {
                btnStart.ForeColor = Color.Lime;
                btnStart.Cursor = Cursors.Hand;

                btnURL.ForeColor = Color.Lime;
                btnURL.Cursor = Cursors.Hand;

            }
            else
            {
                btnStart.ForeColor = Color.Red;
                btnStart.Cursor = Cursors.No;

                btnURL.ForeColor = Color.Red;
                btnURL.Cursor = Cursors.No;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Cursor == Cursors.Hand)
            {
                clSelenium();
                thr = new Thread(letStart);
                thr.Start();
            }
        }

        private void currentSetting()
        {
            btnStart.ForeColor = Color.Red;
            btnStart.Cursor = Cursors.No;
        }

        private void currentSettingReady()
        {
            btnStart.ForeColor = Color.Lime;
            btnStart.UseWaitCursor = false;
            btnStart.Text = "Start Cont...";
            btnStart.Focus();
        }

        private void letStart()
        {
            btnStart.ForeColor = Color.Gold;
            btnStart.UseWaitCursor = true;
            btnStart.Text = "Starting...";
            btnStart.Enabled = false;
            strartProfile(); // chay browser
            Thread.Sleep(1000);
            btnStart.Enabled = true;


            //reset
            currentSettingReady();
            Thread.Sleep(1500);
        }


        #region opSelenium()
        private void opSelenium()
        {
            try
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                var checkConsole = service.HideCommandPromptWindow = false; //hide console

                driver = new ChromeDriver(service);
                openIncognito();

                driver.Navigate().GoToUrl(txtUrl.Text.Trim());
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
        #endregion

        private void clSelenium()
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thr1 = new Thread(clSelenium);
            thr1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clSelenium();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thr1 = new Thread(clSelenium);
            thr1.Start();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "https://youtube.com/";
        }

        private void btnFacebok_Click(object sender, EventArgs e)
        {
            txtUrl.Text = "https://www.facebook.com/";
        }

        private void openIncognito()
        {
            SendKeys.SendWait("^+{n}");
            driver.Close(); //close tab hien tai
            driver.SwitchTo().Window(driver.WindowHandles[driver.WindowHandles.Count - 1]); //chuyen chrDrive sang tab Incognito
        }


        private void strartProfile()
        {
            //create ChromeOptions options;
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

            driver = new ChromeDriver(options);
            Thread.Sleep(3000);
            SendKeys.SendWait(" ");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnURL.Cursor == Cursors.Hand)
            {
                clSelenium();
                thr = new Thread(runn);
                thr.Start();
            }









        }

        private void runn()
        {
            btnURL.ForeColor = Color.Gold;
            btnURL.UseWaitCursor = true;
            btnURL.Text = "Starting...";
            btnURL.Enabled = false;


            //reset
            currentSettingReady();
            Thread.Sleep(1500);



            //create ChromeOptions options;
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

            driver = new ChromeDriver(options);
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl(txtUrl.Text.Trim());

            Thread.Sleep(3000);
            SendKeys.SendWait(" ");
        }



    }
}
