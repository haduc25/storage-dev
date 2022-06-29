using System;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;

            Console.Write("Nhap so hang: ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot: ");
            col = int.Parse(Console.ReadLine());

            //create array
            int[,] arr = new int[row, col];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Nhap gia tri vao pt [{0}, {1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadKey();
        }
    }
}
