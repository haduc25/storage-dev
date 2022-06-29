using System;
using System.IO;

namespace ViDu5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Administrator\Desktop\Example\ViDu5.txt";

            #region VD - Lấy đường dẫn đầy đủ của tệp
            string nameFile = Path.GetFullPath(filePath);
            Console.WriteLine("Duong dan cua tep= " + nameFile);
            #endregion

            Console.ReadKey();
        }
    }
}






















