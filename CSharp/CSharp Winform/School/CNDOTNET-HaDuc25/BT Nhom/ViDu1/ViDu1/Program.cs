using System;
using System.IO;

namespace ViDu1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Administrator\Desktop\Example\ViDu1.txt";
            string directoryName;
            int i = 0;
            #region VD1 - Lấy tên thư mục

            while (filePath != null)
            {
                directoryName = Path.GetDirectoryName(filePath);
                Console.WriteLine("Ten thu muc('{0}') returns '{1}'", filePath, directoryName);
                filePath = directoryName;
                if (i == 1)
                {
                    filePath = directoryName + @"\";
                }
            }
            #endregion
            Console.ReadKey();
        }
    }
}





