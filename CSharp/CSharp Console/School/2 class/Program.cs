using System;
using System.Collections.Generic;

namespace use_Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime.Now.ToString("dd/MM/yy");
            //DateTime date = new DateTime(2020, 12, 30);
            //string s = date.ToString("dd/MM/yyyy");
            //Console.WriteLine(s);            

            List<SinhVien> dssv = new List<SinhVien>();
            SinhVien sv;

            int n = 0;
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
                        sv = new SinhVien();
                        sv.nhap();
                        dssv.Add(sv);
                    }

                    //Console.Clear();

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("\nSinh Vien [{0}]", i + 1);
                        //Sv co diem tb > 5.0
                        if (dssv[i].getDTB() > 5)
                        {
                            Console.WriteLine("\nSinh Vien co DTB > 5");
                            dssv[i].xuat();
                        }
                    }
                }
            } while (n > 0);
            Console.ReadKey();
        }
    }
}
