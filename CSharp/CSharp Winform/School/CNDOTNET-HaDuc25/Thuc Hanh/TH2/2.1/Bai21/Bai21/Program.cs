using System;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            int[] a = new int[100];
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());

            Nhap(a, n);
            Xuat(a, n);
            isDuong(a, n);
            pt_Le_vt_Chan(a, n);
            xuatSNT(a, n);

            Console.Write("\nNhap pt can xoa: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("\nNhap vi tri pt can xoa: ");
            y = int.Parse(Console.ReadLine());

            //xuatSCP(a);
            //isSoChinhPhuong();

            xoaPT(a, n, x, y);
            Console.ReadKey();
        }

        //nhap
        static void Nhap(int[] a, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        //xuat
        static void Xuat(int[] a, int length)
        {
            Console.Write("\nMang vua nhap la: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("\t" + a[i]);
            }
        }

        //pt duong
        static void isDuong(int[] a, int length)
        {
            Console.Write("\nPt duong la: ");
            for (int i = 0; i < length; i++)
            {
                if (a[i] >= 0)
                {
                    Console.Write("\t" + a[i]);
                }
            }
        }

        //pt le o vi tri chan
        static void pt_Le_vt_Chan(int[] a, int length)
        {
            Console.Write("\nCac phan tu le o vi tri chan la: ");
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 == 1 || a[i] % 2 == -1 && i % 2 == 0)
                {
                    Console.Write("\t" + a[i]);
                }
            }
        }

        //so nguyen to
        static Boolean isSoNguyenTo(int length)
        {
            bool check = true;
            for (int i = 2; i < length; i++)
                if (length % i == 0) check = false;
            if (check) return true;
            else return false;
        }

        //XuatSnt
        static void xuatSNT(int[] a, int length)
        {
            Console.Write("\nSo nguyen to trong mang la: ");
            for (int i = 1; i < length; i++)
            {
                if (isSoNguyenTo(a[i]))
                {
                    Console.Write("\t" + a[i]);
                }
            }
        }

        //xoa pt
        static void xoaPT(int[] a, int length, int x, int y)
        {
            if (y == -1)
            {
                Console.Write("\nKhong tim thay phan tu {0} muon xoa.", y);
            }
            else
            {
                for (int i = y; i <= length - 2; i++)
                {
                    a[i] = a[i + 1];
                }
                length--;
            }


            //in ra man hinh
            Console.WriteLine("\nMang sau khi xoa {0} vi tri {1} la: ", x, y);
            for (int i = 0; i <= length; i++)
            {
                Console.Write("{0} \t", a[i]);
            }
        }



    }
}

