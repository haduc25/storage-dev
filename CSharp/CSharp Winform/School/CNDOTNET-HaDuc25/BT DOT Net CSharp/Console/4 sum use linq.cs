using System;
using System.Linq;

namespace MyApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Caculater Sum numberic in array below!");
			int[] arr = {5,10,100,99,1000};
			int sum1 = arr.Sum();
			Console.WriteLine("Sum= " + sum1);
			Console.ReadKey();
		}
	}
}