using System;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a = new int[100];
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());

            Nhap(a, n);
            Xuat(a, n);
            Console.Write("\nTong cua mang vua nhap la: " + Total(a, n));

            Console.ReadKey();
        }

        //nhap
        static void Nhap(int [] a, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        //xuat
        static void Xuat(int [] a, int length)
        {
            Console.Write("\nMang vua nhap la: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }

        //tinh tong
        static int Total(int[] a, int length)
        {
            int temp = 0;
            for (int i = 0; i<length; i++)
			{
                temp += a[i];
			}
            return temp;
        }
    }
}
