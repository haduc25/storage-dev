using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKTTH2Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SV> DSSV = new List<SV>();
            int n = 0;
            Console.Write("Nhap so luong sinh vien: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("nhap loi: ");
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap thong tin nhan vien thu: {0} ", i + 1);
                    SV sV = new SV();
                    sV.Nhap();
                    DSSV.Add(sV);

                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Thong tin sinh vien thu {0} ", i + 1);
                    DSSV[i].xuat();
                }
                for (int i = 0; i < n; i++)
                {
                    if (DSSV[i].GetDTB > 5.0)
                    {
                        Console.WriteLine("Thong tin sinh vien co diem trung binh tren 5.0 la: ");
                        DSSV[i].xuat();
                    }

                }
            } while (n > 0);
        }
    }
}
