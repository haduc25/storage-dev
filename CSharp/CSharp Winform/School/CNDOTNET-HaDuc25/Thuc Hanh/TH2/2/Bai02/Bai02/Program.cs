using System;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Bài 2: Viết chương trình C# cho phép nhập một mảng một chiều, thực hiện chèn thêm phần tử mới vào trong mảng sau đó in mảng trên màn hình.             
            */
            int n, x, y;
            int[] a = new int[100];
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            Nhap(a, n);

            Console.Write("Nhap pt chen: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Nhap vi tri pt: ");
            y = int.Parse(Console.ReadLine());
            
            Xuat(a, n);
            chenPT(a, n, x, y);

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
            Console.WriteLine("\nMang ban dau la: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }

        //Chen pt
        static void chenPT(int[] a, int length, int x, int y)
        {       
            //du chuyen du lieu cua mang
            for (int i = length; i >= y; i--)
            {
                a[i] = a[i - 1];
            }
            //chen phan tu
            a[y - 1] = x;

            //in ra man hinh
            Console.WriteLine("\nMang sau khi chen {0} vao vi tri {1} la: ", x, y);
            for (int i  = 0; i <= length; i++)
            {
                Console.Write("{0} \t", a[i]);
            }
        }
    }
}
