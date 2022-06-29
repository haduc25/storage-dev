using System;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Caculater Sum numberic in array below!");
			int[] IntArray = {1, 3 ,5 , 7 ,9};
			int Sum = 0;
			foreach (int item in IntArray)
			{
				Console.Write("\t " + item);
				Sum += item;
			}
			Console.WriteLine("\nTong= " + Sum);
			Console.ReadKey();
		}
	}
}