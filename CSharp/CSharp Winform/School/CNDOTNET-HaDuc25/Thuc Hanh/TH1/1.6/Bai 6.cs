using System;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 6");
            int n, i, oke = 0;
            Console.Write("Nhap 1 so bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    oke++;
                }    
            }
            if (oke == 2)
            {
                Console.WriteLine("{0} la so nguyen to.", n);
            }
            else
            {
                Console.WriteLine("{0} Khong phai so nguyen to.", n);
            }

            Console.ReadKey();
        }
    }
}
