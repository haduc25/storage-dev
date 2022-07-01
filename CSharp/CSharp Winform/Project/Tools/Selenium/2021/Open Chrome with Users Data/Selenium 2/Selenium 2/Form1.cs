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
using System.IO;

namespace Selenium_2
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
       // string ProfileFolderPath = Application.StartupPath + "Profile";


        private void btnStop_Click(object sender, EventArgs e)
        {
            closeDriver();
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //closeDriver();
            thr = new Thread(strartProfile);
            thr.Start();
            
        }

        private void closeDriver()
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
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeDriver();
        }
    }
}
