using System;
using System.IO;

namespace ViDu3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Administrator\Desktop\Example\ViDu3.txt";

            #region VD3 - Lấy tên tệp
            string nameFile = Path.GetFileName(filePath);
            Console.WriteLine("Ten tep= " + nameFile);
            #endregion

            Console.ReadKey();
        }
    }
}






















