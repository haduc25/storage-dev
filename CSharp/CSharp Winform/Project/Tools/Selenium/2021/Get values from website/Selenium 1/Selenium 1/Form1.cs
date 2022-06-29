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

namespace Selenium_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromeDriver chromeDriver;
        ChromeOptions chromeOptions;
        IWebDriver webDriver;


        private void button1_Click(object sender, EventArgs e)
        {
            /*              
             chromeDriver = new ChromeDriver();
             chromeDriver.Navigate().GoToUrl("https://360boutique.vn/");
            */

            //chromeDriver.PageSource();

            #region find element by id
            /*           //find element by id (web: https://360boutique.vn/) 
                        var textEditer = chromeDriver.FindElement(By.Id("inputSearchAuto-mb"));

                        Thread.Sleep(3000);

                        //send keys
                        textEditer.SendKeys("Hello my name is fking u !");*/
            #endregion

            #region use javascript, IJavaScriptExecutor
            //use javascript (web: https://360boutique.vn/) 
            /*Script
             *  var content = document.getElementsByClassName('site-animation')[0].children[0].innerHTML;
                alert(content); 
             */
            /* //javaScript
             chromeDriver.ExecuteScript("var content = document.getElementsByClassName('site-animation')[0].children[0].innerHTML;alert(content);");*/

            /*//IJavaScriptExecutor
              IJavaScriptExecutor js = chromeDriver as IJavaScriptExecutor;

              //return value
              var dataFromJS = (string)js.ExecuteScript("var content = document.getElementsByClassName('site-animation')[0].children[0].innerHTML;return content;");
              MessageBox.Show(dataFromJS);*/
            #endregion

            #region find element by xPath
            /*            //xPath (web: https://360boutique.vn/) 
                        *//*
                         * o trinh duyet chon phan tu -> f11 - > chuot phat -> copy -> chon xpath
                         * thêm '\' để idea nhận dạng dấu '""', o vd duoi them 2 dau '\'
                         * vd: //*[@id="search-header-btn-mb"]    --->     //*[@id=\"search-header-btn-mb\"]
                         *//*

                        var button = chromeDriver.FindElement(By.XPath("//*[@id=\"search-header-btn-mb\"]"));
                        button.Click();*/



            /*            //CssSelector (web: https://360boutique.vn/)
                        *//*
                         * o trinh duyet chon phan tu -> f11 - > chuot phat -> copy -> chon cssSelector
                         * thêm '\' để idea nhận dạng dấu '""'
                         * vd: //*[@id="search-header-btn-mb"]    --->     //*[@id=\"search-header-btn-mb\"]
                        *//*

                        var button = chromeDriver.FindElement(By.CssSelector("#search-header-btn-mb"));
                        button.Click();*/
            #endregion

            #region Profile
            /*
             FireFox: %APPDATA% -> \Mozilla\Firefox\Profiles\   
             Chrome: %APPDATA% -> \Local\Google\Chrome\User Data\


            //firefox
            FirefoxProfile firefoxProfile = new FirefoxProfile("profile path");

            // khởi tạo WebDriver

            FirefoxDriver firefoxDriver = new FirefoxDriver(firefoxProfile);
             */
            //Chrome
            /*
                  //chromeOptions.AddArgument(@"profile-directory=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data"); //chose user profile
                  //chromeOptions.AddArgument(@"profile-directory=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data\Profile 1"); //chose profile   
            
                *change profile
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument(@"user-data-dir=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data");

                    chromeOptions.AddArgument(@"profile-directory=Profile 1"); //chose profile

                    //chromeDriver = new ChromeDriver(chromeOptions); (cai nay cung dung dc)

                    IWebDriver driver = new ChromeDriver(chromeOptions);
             */

            /*              ChromeOptions chromeOptions = new ChromeOptions();
                            chromeOptions.AddArgument(@"user-data-dir=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data");

                            chromeOptions.AddArgument(@"profile-directory=Profile 1"); //chose profile

                            //chromeDriver = new ChromeDriver(chromeOptions);

                            webDriver = new ChromeDriver(chromeOptions); //same chromeDriver*/
            #endregion

            #region Some ChromeOptions AddArgument tool
            /*
                        https://peter.sh/experiments/chromium-command-line-switches/
                        http://www.assertselenium.com/java/list-of-chrome-driver-command-line-arguments/
                        check proxy: https://api.ipify.org/



                        chromeOptions.AddArgument(@"user-data-dir=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data");
                        chromeOptions.AddArgument(@"profile-directory=Profile 1"); //chose profile
                        //chromeOptions.AddArgument("window-size=400, 600"); //size window
                        //chromeOptions.AddArgument("mute-audio"); //mute
                        //chromeOptions.AddArgument("incognito"); //tap an danh
                        //chromeOptions.AddArgument("test-type=browser");
                        //chromeOptions.AddArgument("start-maximized");
                        //chromeOptions.AddArgument("window-size=1920,1080");
                        //chromeOptions.AddArgument("ignore-certificate-errors");
                        //chromeOptions.AddArgument("disable-popup-blocking");
                        //chromeOptions.AddArgument("enable-precise-memory-info");
                        //chromeOptions.AddArgument("disable-default-apps");
                        //chromeOptions.AddArgument("headless"); //hide chrome   -> can see in taskmanager


                        //example
                        var options = new ChromeOptions();
                        options.AddArgument("--proxy-server=" + string_proxy);
                        options.AddArgument("--silent");
                        options.AddArgument("--log-level=3");
                        options.AddArgument("--lang=en");
                        options.AddArgument("--disable-logging");
                        options.AddArgument("--no-sandbox");
                        options.AddArgument("--disable-infobars");
                        options.AddArgument("--ignore-certificate-errors");
                        options.AddArgument("--disable-dev-shm-usage");
                        options.AddUserProfilePreference("profile.default_content_setting_values.images", 2);
                
                           //
                        start-maximized: Opens Chrome in maximize mode
                        incognito: Opens Chrome in incognito mode
                        headless: Opens Chrome in headless mode
                        disable-extensions: Disables existing extensions on Chrome browser
                        disable-popup-blocking: Disables pop-ups displayed on Chrome browser
                        make-default-browser: Makes Chrome default browser
                        version: Prints chrome browser version
                        disable-infobars: Prevents Chrome from displaying the notification ‘Chrome is being controlled by automated software
            */

            #endregion

            #region Change IP & Proxy, webRTC
            /*
             check proxy: https://api.ipify.org/
             proxy free: https://free-proxy-list.net/ (select https: yes)
             toturial webRTC: https://whoer.net/blog/how-to-disable-webrtc-in-various-browsers/

             webRTC Chrome: https://stackoverflow.com/questions/44599265/how-do-i-disable-webrtc-in-chrome-driver

             //FireFox
                https://www.howkteam.vn/course/profile-voi-selenium-trong-wpf/change-proxy-voi-selenium-trong-wpf-2588
             */

            //Chrome (not work)

            //chromeOptions = new ChromeOptions();
            ////chromeOptions.AddArgument("window-size=400,600"); //size window
            //chromeOptions.AddArgument("start-maximized");
            ////chromeOptions.AddArgument("incognito"); //an danh
            //chromeOptions.AddArgument("proxy-server=103.124.2.229:3128"); //change proxy chrome
            ////chromeOptions.AddArgument("disable-webrtc-multiple-routes");
            ////chromeOptions.AddArgument("disable-webrtc-hw-encoding");
            ////chromeOptions.AddArgument("disable-webrtc-hw-decoding");
            ////chromeOptions.AddArgument("disable-webrtc-encryption");



            //chromeDriver = new ChromeDriver(chromeOptions);
            //chromeDriver.Navigate().GoToUrl("https://api.ipify.org/");
            //Thread.Sleep(5000);

            //chromeDriver.Navigate().GoToUrl("https://whoer.net/");



            #endregion

            #region Change Frame

            /*            chromeDriver = new ChromeDriver();
                        chromeDriver.Navigate().GoToUrl("https://www.howkteam.vn/course/turn-off-webrtc-voi-selenium-trong-wpf/change-frame-voi-selenium-trong-wpf-2590");

                        //find element
                        //var btn = chromeDriver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[4]/div"));
                        var btn = chromeDriver.FindElement(By.Id("ytplayer"));
                        btn.Click();
                        Thread.Sleep(2000);

                        //Change Frame
                        chromeDriver.SwitchTo().Frame(btn); //chuyen Frame

                        //click to youtube
                        var btn2 = chromeDriver.FindElement(By.CssSelector("#movie_player > div.ytp-chrome-bottom > div.ytp-chrome-controls > div.ytp-right-controls > a"));
                        btn2.Click();*/

            #endregion




            Thread.Sleep(3000);
            MessageBox.Show("Done !");

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeSelenium();
        }

        private void closeSelenium()
        {
            if(chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver.Quit();
            }

            if(webDriver != null)
            {
                webDriver.Dispose();
                webDriver.Quit();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            closeSelenium();
            Application.Exit();
        }
    }
}
