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
using OpenQA.Selenium.Interactions;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Facebook_auto_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //txtUser.Text = "mduck.tools";
            //txtPass.Text = "#haduc25fb";
        }

        #region Nugget need install
        /*
            Nugget need install
            
            +Selenium.WebDriver
            +Selenium.Chrome.WebDriver (trong NuGet tim va cai dat phien ban = voi phien ban cua chrome dang dung)
         */
        #endregion


        ChromeDriver chrDriver;
        Thread thr;

        //javascript
        //IJavaScriptExecutor js;

        //text change both (txtUser and txtPass)
        private void txtChanged(object sender, EventArgs e)
        {
            if(txtUser.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                btnSend.ForeColor = Color.Lime;
                btnSend.Cursor = Cursors.Hand;
            }
            else
            {
                btnSend.ForeColor = Color.Red;
                btnSend.Cursor = Cursors.No;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(btnSend.Cursor == Cursors.Hand)
            {
                // MessageBox.Show("Hand cont...");
                //openSelenium();

                thr = new Thread(browserRunning);
                thr.Start();
            }
        }

        private void openSelenium()
        {
            try
            {
                ChromeDriverService chrService = ChromeDriverService.CreateDefaultService();
                chrService.HideCommandPromptWindow = false; //hide console

                chrDriver = new ChromeDriver(chrService);
                //chrDriver.Navigate().GoToUrl("https://www.google.com");
                chrDriver.Navigate().GoToUrl("https://www.facebook.com/login");
                //chrDriver.Navigate().GoToUrl("https://www.facebook.com/mduck.tools/");

                //Maximize Browser  
                chrDriver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void browserRunning()
        {
            btnSend.ForeColor = Color.Gold;
            btnSend.UseWaitCursor = true;
            btnSend.Text = "Sending...";
            openSelenium(); // chay browser
            Thread.Sleep(1000); //current 3s
            loginFB(txtUser.Text.Trim(), txtPass.Text.Trim());

            if (checkLogin())
            {
                //MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something wrong !", "Warring!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //closeSelenium();

            //reset
            btnSend.ForeColor = Color.Lime;
            btnSend.UseWaitCursor = false;
            btnSend.Text = "Send";
            btnSend.Focus();

            Thread.Sleep(1500);
            //sendKeysEnter();

            //openYoutube();
            addFriend();
            //scrollWebsiteHtml();
            //findInBrowser();


            //openLoli();
        }

        private void loginFB(string username, string password)
        {
            try
            {
                chrDriver.FindElements(By.XPath("//input[@class='inputtext _55r1 inputtext _1kbt inputtext _1kbt']"))[0].SendKeys(username);
                Thread.Sleep(2000);
                chrDriver.FindElements(By.XPath("//input[@class='inputtext _55r1 inputtext _9npi inputtext _9npi']"))[0].SendKeys(password);
                Thread.Sleep(2000);
                chrDriver.FindElement(By.XPath("//button[@class='_42ft _4jy0 _52e0 _4jy6 _4jy1 selected _51sy']")).Click();
                Thread.Sleep(3000);
                //inputtext _55r1 inputtext _1kbt inputtext _1kbt
                //inputtext _55r1 inputtext _9npi inputtext _9npi


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private bool checkLogin() 
        {
            if (chrDriver.Url == "https://www.facebook.com/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Class from Facebook/login
        /*
           User:         inputtext _55r1 inputtext _1kbt inputtext 
           Password:     inputtext _55r1 inputtext _9npi inputtext 
           btnSubmit:    _42ft _4jy0 _52e0 _4jy6 _4jy1 selected _51sy
         */
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeSelenium();
        }

        private void closeSelenium()
        {
            if(btnSend.Cursor == Cursors.Hand)
            {
                chrDriver.Quit();
            }
        }


        private void addFriend()
        {
            try
            {
                //go to url
                chrDriver.Navigate().GoToUrl("https://www.facebook.com/huyen.lengoc.982845");
                Thread.Sleep(3000);
                //add
                chrDriver.FindElement(By.XPath("//span[text()='Thêm bạn bè']")).Click();
                Thread.Sleep(3000);
                //a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5




                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeSelenium();
            Application.Exit();
        }

        private void scrollWebsite()
        {
            // scroll by Element
            var element = chrDriver.FindElement(By.Id("hblp_0_1_V4"));
            Actions actions = new Actions(chrDriver);
            actions.MoveToElement(element);
            actions.Perform();

        }

        private void scrollWebsiteHtml()
        {
            try
            {
                /*
                 * Nuget 
                 * using HtmlAgilityPack;
                 * using HtmlDocument = HtmlAgilityPack.HtmlDocument;
                 */
                Thread.Sleep(3000);
                chrDriver.ExecuteScript("scroll(0,900)");
                HtmlDocument countriesDocument = new HtmlDocument();
                countriesDocument.LoadHtml(chrDriver.PageSource);

                Thread.Sleep(3000);
                MessageBox.Show("Success Scroll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sendKeysEnter()
        {
            //Actions actions = new Actions(chrDriver);
            //actions.SendKeys(""+System.Windows.Forms.Keys.Enter);
            //Thread.Sleep(500);
            //actions.Build();
            //actions.Perform();

            ////Refresh
            //Thread.Sleep(3000);
            //chrDriver.Navigate().Refresh();

            //Thread.Sleep(3000);
            chrDriver.Navigate().GoToUrl("https://google.com/");
            Thread.Sleep(500);
            SendKeys.SendWait("^{f}"); // CTRL + F
            Thread.Sleep(3000);

            //
            SendKeys.SendWait("loli");
           // System.Windows.Forms.Keys l = System.Windows.Forms.Keys.L;

            //Actions actions = new Actions(chrDriver);
            ////actions.SendKeys("" + System.Windows.Forms.Keys.L);
            //Thread.Sleep(500);
            //actions.Build();
            //actions.Perform();

            /*
             //SendKeys.Send(String) Method
                https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-6.0
             */
            MessageBox.Show("Success !");
        }


        private void openYoutube()
        {
            try
            {
                chrDriver.Navigate().GoToUrl("https://youtube.com/");
                Thread.Sleep(2500);

                chrDriver.FindElement(By.XPath("//div[@class='ytd-searchbox-spt']")).Click();
                Thread.Sleep(3000);

                SendKeys.SendWait("Enemy Arcane"); // CTRL + F
                Thread.Sleep(2000);
                //SendKeys.SendWait("{ENTER}");
                chrDriver.FindElement(By.XPath("//button[@class='style-scope ytd-searchbox']")).Click();

                Thread.Sleep(5000);
                MessageBox.Show("Success !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openLoli()
        {
            try
            {
                openIncognito();
                Thread.Sleep(1000);
                //chrDriver.Navigate().GoToUrl("https://clubloli.com/a/f/");
                chrDriver.Navigate().GoToUrl("https://clubloli.com/v/20675/");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openIncognito() 
        {
            SendKeys.SendWait("^+{n}");
            chrDriver.Close(); //close tab hien tai
            chrDriver.SwitchTo().Window(chrDriver.WindowHandles[chrDriver.WindowHandles.Count - 1]); //chuyen chrDrive sang tab Incognito
        }


        private void findInBrowser()
        {

            /*
             stefcarol90    khoa
             eliztlie_0     k khoa
             */
            string user = "stefcarol90";
            try
            {
                openIncognito();
                Thread.Sleep(1000);
                chrDriver.Navigate().GoToUrl("https://www.ebay.com/usr/" + user);
                Thread.Sleep(2000);
                //SendKeys.SendWait("^{f}");
                //SendKeys.SendWait("unregstd");


                var check = chrDriver.FindElements(By.XPath("//span[@class='unregstd']"));
                //chrDriver.FindElements(By.XPath("//span[text()='No longer a registered user']")); //FindElements
                Thread.Sleep(2000);
                if (check.Count > 0)
                {
                    MessageBox.Show(user + " is Locked", "Noti");
                }
                else
                {
                    MessageBox.Show(user + " is Alive","Noti");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
