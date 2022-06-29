using System;

namespace BTNC_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.Write("Nhap so pt mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Nhap(arr, n);
            Console.WriteLine("\nCac phan tu trong mang vua nhap la: ");
            Xuat(arr, n);
            Console.ReadKey();
        }

        //nhap
        static void Nhap(int []arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}]= ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //xuat
        static void Xuat(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arr[{0}]= {1}", i + 1, arr[i]);
            }
        }
    }
}
