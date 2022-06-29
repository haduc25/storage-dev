using System;

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 7");

            int gt = 1, i = 1, n;
            do
            {
                Console.Write("Nhap 1 so bat ky > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
                gt = gt * i;
                i = i + 1;
            } while (i <= n);

            Console.WriteLine("{0}!= {1}", n, gt);

            Console.ReadKey();
        }
    }
}