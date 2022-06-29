using System;

namespace Bai_Tap_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai Tap 2");

            int a, b, chuVi, dienTich;

            Console.Write("Nhap chieu dai HCN: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu rong HCN: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Tinh chu vi, dien tich
            if (a > 0 && b > 0)
            {
                chuVi = 2 * (a + b);
                dienTich = a * b;
                //Kq
                Console.WriteLine("\nChu vi cua HCN: " + chuVi);
                Console.WriteLine("Dien tich cua HCN: " + dienTich);
            }
            else
                Console.WriteLine("HCN phai co canh lon hon 0");

            Console.ReadKey();
        }
    }
}
