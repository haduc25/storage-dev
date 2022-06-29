using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading.Tasks;

namespace getUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region get info
        string pcName = System.Environment.MachineName;
        string user = System.Environment.UserName;

        string path = @"C:\Users\" + System.Environment.UserName + @"\AppData\Local\Google\Chrome\User Data";

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllDiskDrives();

            /*          //MessageBox.Show("PC: " + pcName + "\nUser: " + user);
                      MessageBox.Show("PC: " + pcName + "\nUser: " + user + "\nSource: " + path);

                      if (Directory.Exists(path))
                      {
                          MessageBox.Show("ok!");
                      }
                      else { MessageBox.Show("ok!"); }*/


        }

        private void GetAllDiskDrives()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString();//get the serailNumber of diskdrive

                MessageBox.Show("Model: " + hd.Model.ToString() + "\nSerialNo: " + hd.SerialNo.ToString());

                //wmic diskdrive Model, SerialNumber
            }



        }


        public class HardDrive
        {
            public string Model { get; set; }
            public string SerialNo { get; set; }
        }

        #endregion

        #region Zip Folder (System.IO.Compression)
        /*
         *install nugget (System.IO.Compression)
         *
         *Fix if error
         *
            https://www.youtube.com/watch?v=PPOC2o5xAUU
            C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\
            https://openplanning.net/10451/csharp-compression-decompression
        */
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //string zipPath = @"F:\Test"; //folder
            //string archiveFileName = "fb";
            //string DirectoryToBeArchive = zipPath + "\\" + archiveFileName;
            //string pathName = "fb";
            //string DirectoryToBeArchive = @"F:\Test\";            

            string pathName = "UserData";
            string DirectoryToBeArchive = @"F:\Test\";
            string saveFkingFile = @"F:\Test1\" + pathName + ".rar";

            try
            {
                /* Fix some error about Path, Source File
                 * 
                 * https://stackoverflow.com/questions/19395128/c-sharp-zipfile-createfromdirectory-the-process-cannot-access-the-file-path-t
                 * 
                    //WRONG
                    ZipFile.CreateFromDirectory("C:\somefolder", "C:\somefolder\somefile.zip");
                    //RIGHT     
                    ZipFile.CreateFromDirectory("C:\somefolder", "C:\someotherfolder\somefile.zip");


                    //plant check folder save
                    check file save if exist -> Zip 
                    else create folder -> Zip

                    //check file rar save
                    if(exist) -> delete file -> create
                    else -> create

                 */
                //System.IO.Compression
                MessageBox.Show("Im here 1");
                ZipFile.CreateFromDirectory(DirectoryToBeArchive, saveFkingFile);
                //ZipFile.CreateFromDirectory(DirectoryToBeArchive, DirectoryToBeArchive + ".rar");
                MessageBox.Show("Im here 2");

                //if (File.Exists(DirectoryToBeArchive + ".rar"))
                //{
                //    File.Delete(DirectoryToBeArchive + ".rar");
                //    ZipFile.CreateFromDirectory(DirectoryToBeArchive, DirectoryToBeArchive + ".rar", CompressionLevel.Fastest, false);
                //}
                //else 
                //{
                //    ZipFile.CreateFromDirectory(DirectoryToBeArchive, DirectoryToBeArchive + ".rar", CompressionLevel.Fastest, false);
                //}


                //Directory.Delete(DirectoryToBeArchive, true);

                #region IoniZipFile (only file & file < 3Gb)
                /*su dung IoniZipFile
                  *install nugget IoniZipFile
                  *
                  *Youtube: Programming With Musavi - Extract the simple zip file in C# (https://www.youtube.com/watch?v=bi7hZLb7qLI)
                  *
                  *Code Example:
                   
                        //using (IoniZipFile z = new Ionic.Zip.ZipFile())
                        //{
                        //    z.Password = "123";
                        //    z.AlternateEncodingUsage = Ionic.Zip.ZipOption.AsNecessary;
                        //    z.AlternateEncoding = System.Text.Encoding.UTF8;
                        //    z.AddFile(pathFile); //source file @"F:\Test";



                        //    z.Save(pathSave); //save file @"F:\Test\img_fb.zip";
                        //}
                  

                    //advanced
                    https://stackoverflow.com/questions/56444207/compress-file-using-ionic-zip-with-progress-bar-windows-forms
                    https://foxlearn.com/articles/zip-file-folder-in-csharp-198.html

                    https://stackoverflow.com/questions/11008152/what-is-an-alternate-of-ionic-zip-in-c
                    https://stackoverflow.com/questions/13129141/add-folders-to-root-of-zip-using-ionic-zip-library/13129238
                */
                #endregion


                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hello and fk u");
                MessageBox.Show(ex.Message);
            }



        }

        private void btnCheckZip_Click(object sender, EventArgs e)
        {
            checkFolder();
        }


        private void checkFolder()
        {
            //file
            string tenZip = "Loli";
            string tenFileZip = @"F:\Hello_Bro\" + tenZip + ".rar";
            string DirectoryToBeArchive = @"F:\Test\";

            //folder
            //string currentFolder = "";
            string saveFolder = @"F:\Hello_Bro";


            #region Folder, File
            if (!Directory.Exists(saveFolder))
            {
                Directory.CreateDirectory(saveFolder); //neu chua co thi tao
                MessageBox.Show("Folder k ton tai - > Da tao folder thanh cong");
            }

            if (Directory.Exists(saveFolder))
            {
                //file
                if (File.Exists(tenFileZip))
                {
                    File.Delete(tenFileZip);
                    Thread.Sleep(500);
                    ZipFile.CreateFromDirectory(DirectoryToBeArchive, tenFileZip, CompressionLevel.Fastest, false);
                    MessageBox.Show("File da ton tai -> xoa file -> tao file moi: " + tenFileZip);
                }
                else
                {

                    ZipFile.CreateFromDirectory(DirectoryToBeArchive, tenFileZip, CompressionLevel.Fastest, false);
                    MessageBox.Show("da tao file moi: " + tenFileZip);
                }

            }

            #endregion
        }
    }
}
