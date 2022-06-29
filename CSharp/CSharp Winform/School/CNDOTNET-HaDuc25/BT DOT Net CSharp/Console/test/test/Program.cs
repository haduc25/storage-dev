using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TamGiac> dsTG = new List<TamGiac>();
            int n = 0;
            Console.Write("Nhap so luong tam giac: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("So luong tam giac phai > 0, vui long nhap lai !");
                }
                else
                {
                    //nhap
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("\nTam Giac[{0}]", i + 1);
                        TamGiac tg = new TamGiac();
                        tg.Nhap();
                        dsTG.Add(tg);
                    }
                    Console.Clear();
                    Console.WriteLine("=====Result=====");
                    //xuat
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("\nTam Giac[{0}]", i + 1);
                        dsTG[i].Xuat();
                        //Checking is Triangle
                        dsTG[i].isTriangle();
                    }
                }
            } while (n > 0);
            Console.ReadKey();
        }

    }
}
