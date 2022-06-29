using System;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input Cols: ");
				int m = int.Parse(Console.ReadLine());
			Console.Write("Input Rows: ");
				int n = int.Parse(Console.ReadLine());

			//declare array 2 chieu
				int[,] IntArr = new int[m, n];
			for(int i =0; i<IntArr.GetLength(0);i++)
			{
				for(int j = 0; j<IntArr.GetLength(1); j++)
				{
					Console.Write("A[{0},{1} = ]", i, j);
					IntArr[i,j] = int.Parse(Console.ReadLine());
				}
			}

			//Output
			Console.WriteLine("Array: ");
			for(int i=0; i<IntArr.GetLength(0); i++)
			{
				for(int j=0; j<IntArr.GetLength(1); j++)
				{
					Console.Write(IntArr(i,j));
				}
			}
			Console.ReadKey();
		}
	}
}