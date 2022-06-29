using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Nhap ma tran: ");
            n = int.Parse(Console.ReadLine());

            int[,] a = new int[10, 10];
            int[] hang = new int[10];
            int[] cot = new int[10];
            int[,] mtCV = new int[10, 10];


            Nhap(n, a);
            Console.WriteLine("\nMa tran vua nhap: ");
            Xuat(n, a);

            Console.WriteLine("\nTong cac pt cua Hang: ");
            kqHang(n, a, hang);
            Console.WriteLine("\nTong cac pt cua Cot: ");
            kqCot(n, a, cot);
            kqCheoChinh(n, a);
            Console.Write("\n\nMa tran chuyen vi: ");
            mtChuyenVi(n, a, mtCV);
            sxTang(n, a);
            sxGiam(n, a);
            Console.ReadKey();
        }

        //nhap
        static void Nhap(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //xuat
        static void Xuat(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}   ", a[i, j]);
                }
                Console.WriteLine();
            }
        }

        //tong so hang
        static void kqHang(int n, int[,] a, int[] hang)
        {
            for (int i = 0; i < n; i++)
            {
                hang[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    hang[i] = hang[i] + a[i, j];
                }
                Console.WriteLine("+Hang[{0}] la: {1}", i + 1, hang[i]);
            }
        }

        //tong so cot
        static void kqCot(int n, int[,] a, int[] cot)
        {
            for (int i = 0; i < n; i++)
            {
                cot[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    cot[i] = cot[i] + a[j, i];
                }
                Console.WriteLine("+Cot[{0}] la: {1}", i + 1, cot[i]);
            }
        }

        static void kqCheoChinh(int n, int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum = sum + a[i, j];
                    }
                }
            }
            Console.Write("\nTong pt tren duong cheo chinh: " + sum);
        }

        static void mtChuyenVi(int n, int[,] a, int[,] mtCV)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mtCV[j, i] = a[i, j];
                }
            }

            //xuat ma tran
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}   ", mtCV[i, j]);
                }
            }
        }

        //min - max
        static void sxTang(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {

                    for (int k = 0; k < j; k++)
                    {
                        if (a[i, k] > a[i, k + 1])
                        {
                            int temp = a[i, k];
                            a[i, k] = a[i, k + 1];
                            a[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("SX theo chieu tang dan:");
            Xuat(n, a);

        }

        //max - min
        static void sxGiam(int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {

                    for (int k = 0; k < j; k++)
                    {
                        if (a[i, k] < a[i, k + 1])
                        {
                            int temp = a[i, k];
                            a[i, k] = a[i, k + 1];
                            a[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("SX theo chieu giam dan: ");
            Xuat(n, a);
        }
    }
}
