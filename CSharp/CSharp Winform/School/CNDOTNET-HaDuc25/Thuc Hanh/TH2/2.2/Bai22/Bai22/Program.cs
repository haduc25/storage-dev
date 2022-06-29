using System;

namespace Bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Nhap kich co cua ma tran: ");
            n = int.Parse(Console.ReadLine());

            //Tao mang
            int[,] arr = new int[20, 20];
            int[] totalRow = new int[20]; 
            int[] totalCol = new int[20];
            int[,] tranS = new int[20, 20];


            Nhap(n, arr);
            Console.WriteLine("\n-----------------------------------------------------------------");
            Console.WriteLine("\n*Ma tran ban dau: ");
            Xuat(n, arr);

            Console.WriteLine("\n*Tong cac pt cua Hang: ");
            resultRow(n, arr, totalRow);
            Console.WriteLine("\n*Tong cac pt cua Cot: ");
            resultCol(n, arr, totalCol);
            resultDiag(n, arr);
            Console.Write("\n\n*Ma tran chuyen vi: ");
            resultTrans(n, arr, tranS);
            sortMin(n, arr);
            sortMax(n, arr);
            Console.ReadKey(); 
        }

        //nhap
        static void Nhap(int length, int[,] arr)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("a[{0},{1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //xuat
        static void Xuat(int length, int [,] arr)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("{0}   ", arr[i, j]);
                }Console.WriteLine();
            }
        }

        //tong hang
        static void resultRow(int length, int [,] arr, int [] totalRow)
        {
            for (int i = 0; i < length; i++)
            {
                totalRow[i] = 0;
                for (int j = 0; j < length; j++)
                {
                    totalRow[i] = totalRow[i] + arr[i, j];
                }
                Console.WriteLine("-Hang[{0}] la: {1}", i+1, totalRow[i]);
            }
        }

        //tong cot
        static void resultCol(int length, int [,] arr, int [] totalCol)
        {
            for (int i = 0; i < length; i++)
            {
                totalCol[i] = 0;
                for (int j = 0; j < length; j++)
                {
                    totalCol[i] = totalCol[i] + arr[j, i];
                }
                Console.WriteLine("-Cot[{0}] la: {1}", i + 1, totalCol[i]);
            }
        }

        //tong duong cheo chinh (diagonal)
        static void resultDiag(int length, int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if(i == j)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            Console.Write("\n*Tong cac pt tren duong cheo chinh: " + sum);
        }

        //tim ma tran chuyen vi (tham khao code tai: www.w3resource.com) - Transpose of a specified Matrix
        static void resultTrans(int length, int[,] arr, int [,] tranS)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    tranS[j, i] = arr[i, j];
                }
            }

            //xuat ma tran
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < length; j++)
                {
                    Console.Write("{0}   ", tranS[i, j]);
                }
            }
        }

        //sap xep min - max
        static void sortMin(int length, int [,] arr)
        {
            for (int i = 0; i < length; i++) // Array Sorting
            {
                for (int j = length - 1; j > 0; j--)
                {

                    for (int k = 0; k < j; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1])
                        {
                            int temp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }

            //xuat sort by min
            Console.WriteLine("*Sap xep cac pt theo chieu tang dan (min - max): ");
            Xuat(length, arr);

        }

        //sap xep max - min
        static void sortMax(int length, int[,] arr)
        {
            for (int i = 0; i < length; i++) // Array Sorting
            {
                for (int j = length - 1; j > 0; j--)
                {

                    for (int k = 0; k < j; k++)
                    {
                        if (arr[i, k] < arr[i, k + 1])
                        {
                            int temp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }

            //xuat sort by max
            Console.WriteLine("*Sap xep cac pt theo chieu giam dan (max - min): ");
            Xuat(length, arr);
        }
    }
}
