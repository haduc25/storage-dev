using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace testing
{
    class Program
    {
        public static void Main()
        {
            int canha, canhb, canhc;
            Console.Write("\n");
            Console.Write("Kiem tra tam giac deu, can, thuong trong C#:\n");
            Console.Write("Nhap canh a: ");
            canha = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap canh b: ");
            canhb = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap canh c: ");
            canhc = Convert.ToInt32(Console.ReadLine());
            if (canha + canhb <= canhc || canha + canhc <= canhb || canhb + canhc <=
            canha)
            {
                Console.WriteLine("Khong phai tam giac");
            }
            else
            {
                if (canha == canhb && canhb == canhc)
                {
                    Console.Write("Day la tam giac deu.\n");
                }
                else if (canha == canhb || canha == canhc || canhb == canhc)
                {
                    Console.Write("Day la tam giac can.\n");
                }
                else
                {
                    Console.Write("Day la tam giac thuong.\n");
                }
                {
                    int chuvi = (canha + canhb + canhc);
                    int p = chuvi / 2;
                    int dientich = (p * (p - canha) * (p - canhb) * (p - canhc));
                    Console.WriteLine("chu vi tam giac la:" + chuvi);
                    Console.WriteLine("dien tich tam giac la:" + dientich);
                    Console.WriteLine("nửa chu vi tam giac la:" + p);
                }

                Console.ReadKey();
            }
        }
    }
}