using System;

namespace Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 7");

            int gt, i, n;
            do
            {
                Console.Write("Nhap 1 so bat ky > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0 || n == 0);

            gt = 1;
            if (n > 0)
            {
                for (i = 1; i <= n; i++)

                {
                    gt = gt * i;
                }

            }
            Console.WriteLine("{0}!= {1}", n, gt);

            Console.ReadKey();
        }
    }
}