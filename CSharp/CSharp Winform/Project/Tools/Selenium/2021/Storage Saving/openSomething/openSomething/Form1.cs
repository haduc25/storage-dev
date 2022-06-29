using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        Thread thr;

        private void textChangeBoth(object sender, EventArgs e)
        {
            //txtBoth(url + tk)
            if (txtUrl.Text.Trim() != "")
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Cursor == Cursors.Hand)
            {
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
            btnStart.Text = "Send";
            btnStart.Focus();
        }

        private void letStart()
        {
            btnStart.ForeColor = Color.Gold;
            btnStart.UseWaitCursor = true;
            btnStart.Text = "Starting...";
            opSelenium(); // chay browser
            Thread.Sleep(1000);

            //reset
            currentSettingReady();
            Thread.Sleep(1500);
        }

        private void opSelenium()
        {
            try
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                var checkConsole = service.HideCommandPromptWindow = false; //hide console

                driver = new ChromeDriver(service);
                openIncognito();

                driver.Navigate().GoToUrl(txtUrl.Text.Trim());
                Thread.Sleep(1000);
                //driver.FindElement(By.XPath("//button[@class='ytp-large-play-button ytp-button']")).Click();

                Thread.Sleep(2000);
                //Maximize Browser  
                //driver.Manage().Window.Maximize();
                driver.Manage().Window.Minimize();
                Thread.Sleep(10000);
                driver.Navigate().GoToUrl("https://clubloli.com/v/20675/");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void clSelenium()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver.Quit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            clSelenium();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clSelenium();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clSelenium();
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
    }
}
