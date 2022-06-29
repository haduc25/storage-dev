using System;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai Tap 3");

            double r, chuVi, dienTich;
            double pi = 3.14;

            Console.Write("Nhap ban kinh hinh tron: ");
            r = Convert.ToDouble(Console.ReadLine());

            //tinh chu vi, dien tich
            chuVi = 2 * pi * r;
            dienTich = pi * r * r;
            //Result
            Console.WriteLine("\nChu vi hinh tron: " + chuVi);
            Console.WriteLine("Dien tich hinh tron: " + dienTich);

            Console.ReadKey();
        }
    }
}