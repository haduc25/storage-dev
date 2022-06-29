using System;
using System.IO;

namespace ViDu2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VD2 - Lấy phần mở rộng tệp
            string filePath = @"C:\Users\Administrator\Desktop\Example\ViDu1.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("K ton tai");
            }
            else
            {
                string ext = Path.GetExtension(filePath);
                Console.WriteLine("Phan mo rong tep: " + ext);
            }
           
            #endregion

            Console.ReadKey();
        }
    }
}
