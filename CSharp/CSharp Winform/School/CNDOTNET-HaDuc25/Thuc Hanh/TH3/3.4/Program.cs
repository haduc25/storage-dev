using System;
using System.Collections.Generic;

namespace Bai_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            List<SinhVien> dsSV = new List<SinhVien>();
            Console.Write("Nhap so luong sinh vien: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("So sinh vien phai > 0, vui long nhap lai !");
                }
                else
                {
                    //nhap
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("\nSV[{0}]", i + 1);
                        SinhVien sv = new SinhVien();
                        sv.Nhap();
                        dsSV.Add(sv);
                    }

                    //xuat
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("\nSinh Vien [{0}]", i + 1);
                        dsSV[i].Xuat();
                        //Sv co diem tb > 5.0
                        if (dsSV[i].getDTB() > 5) 
                        {
                            Console.WriteLine("\nSinh Vien co DTB > 5");
                            dsSV[i].Xuat();
                        }
                    }
                }
            } while (n > 0);
            Console.ReadKey();
        }
    }
}
