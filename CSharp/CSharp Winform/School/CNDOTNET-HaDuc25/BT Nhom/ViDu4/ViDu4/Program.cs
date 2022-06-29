using System;
using System.IO;

namespace ViDu4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Administrator\Desktop\Example\ViDu4.txt";

            #region VD4 - Lấy tên tệp không có phần mở rộng tệp
            string nameFile = Path.GetFileNameWithoutExtension(filePath);
            Console.WriteLine("Ten tep khong co phan mo rong= " + nameFile);
            #endregion

            Console.ReadKey();
        }
    }
}






















