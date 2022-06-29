using System;

namespace Bai_Tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1: ");

            float a, b, x;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("a phai khac 0");
            else 
            {
                Console.Write("Nhap b: ");
                b = float.Parse(Console.ReadLine());

                x = -b / a;
                Console.WriteLine("{0}x + {1} = 0", a, b);
                x = (float)System.Math.Round(x, 2);
                Console.WriteLine("x={0}", x);
            }
            Console.ReadKey();
        }
    }
}
