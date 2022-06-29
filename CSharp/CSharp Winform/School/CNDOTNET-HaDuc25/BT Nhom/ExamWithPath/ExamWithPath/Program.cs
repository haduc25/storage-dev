using System;
using System.IO;

namespace ExamWithPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Administrator\Desktop\BT Nhóm\Exam\Ex1.txt";
            string directoryName;
            //int i = 0;
            #region VD1 - GetDirectoryName 


            while (filePath != null)
            {
                directoryName = Path.GetDirectoryName(filePath);
                Console.WriteLine("GetDirectoryName('{0}') returns '{1}'", filePath, directoryName);
                filePath = directoryName;
                if (i == 1)
                {
                    filePath = directoryName + @"\";  // the previous path
                }
            }

            #endregion
            #region VD2 - GetExtension 
            string ext = Path.GetExtension(filePath);
            Console.WriteLine("GetExtension: " + ext);
            #endregion

            #region VD3 - GetFileName 
            string nameFile = Path.GetFileName(filePath);
            Console.WriteLine("Filename = " + nameFile);
            #endregion

            #region VD4 - GetFileNameWithoutExtension
            string nameFile2 = Path.GetFileNameWithoutExtension(filePath);
            Console.WriteLine("Filename khong co extention = " + nameFile2);
            #endregion

            #region VD - GetFullPath
            string nameFile3 = Path.GetFullPath(filePath);
            Console.WriteLine("Filename khong co extention = " + nameFile3);
            #endregion
            Console.ReadKey();
        }
    }
}
