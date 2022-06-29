using System;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so: ");
            double n = int.Parse(Console.ReadLine());
            double gt, i;
            gt = 1;
            i = 1;
            do
            {
                gt = gt * i;
                i = i + 1;
            }
            while (i <= n);

            Console.WriteLine("{0}!= {1}", n, gt);
        }
    }
}