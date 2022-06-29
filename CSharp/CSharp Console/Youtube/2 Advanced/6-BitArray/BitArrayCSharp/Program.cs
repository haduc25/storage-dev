using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayCSharp
{
    class Program
    {
        #region Ex1:
        public static void PrintBits(int v)
		{
			Console.WriteLine(Convert.ToString(v, 2).PadLeft(3, '0'));
		}
        #endregion
        #region Ex 2:
        public static void PrintBits(BitArray ba,int Width) 
        {
            int i = Width;
            foreach (bool item in ba)
            {
                if (i < 1) 
                {
                    i = Width;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode()); //in ra 0    1  thay true false
            }
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Ex1:
            //int[] a = { 1, 3, 4, 6, 1, 4 };

            //int xor = 0;
            //Console.WriteLine("-----");
            //for (int i = 0; i < a.Length; i++)
            //{
            //	xor ^= a[i];
            //	PrintBits(xor);
            //}

            //	int y = xor;
            //	int shift = 0;
            //	while (y % 2 == 0)
            //	{
            //		y <<= 1;
            //		shift++;
            //	}

            //	Console.WriteLine("shift = {0}", shift);

            //	int xor2 = 0;
            //	Console.WriteLine("-----");
            //	for (int i = 0; i < a.Length; i++)
            //	{
            //		// 001 <-> 101
            //		// 011 <-> 101
            //		// 100 <-> 101
            //		// 110 <-> 101
            //		// 001 <-> 101
            //		// 100 <-> 101
            //		if ((a[i] << shift) % 2 == 0)
            //		{
            //			xor2 = xor2 ^ a[i];
            //			PrintBits(xor2);
            //		}
            //	}

            //	Console.WriteLine("-----");
            //	Console.Write("XOR = ");
            //	PrintBits(xor);

            //	Console.Write("1st = ");
            //	PrintBits(xor2);
            //	Console.Write("1st = ");
            //	PrintBits(xor2 ^ xor);

            //// 3 = 011
            //// 6 = 110
            //// 3^6 = 101
            #endregion
            #region Ex2:
            //Create 2 Bitarray form bool
            //1
            bool[] Mybool = new bool[5] { true, false, true, true, false };
            BitArray ba1 = new BitArray(Mybool);
            Console.WriteLine("Gia tri cua ba1: ");
            PrintBits(ba1, 5); //in bit
            //2
            bool[] Mybool1 = new bool[5] { false, true, false, false, true };
            BitArray ba2 = new BitArray(Mybool1);
            Console.WriteLine("Gia tri cua ba2: ");
            PrintBits(ba2, 10); //in bit
            //Create 1 Bitarray from byte
            byte[] Mybyte = new byte[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            BitArray ba3 = new BitArray(Mybyte);
            //1byte = 8bit => auto bien dich byte sang 8 bit VD: 10*8 =80bit
            Console.WriteLine("Gia tri cua ba3: ");
            PrintBits(ba3, 10);
            //AND
            Console.WriteLine("\nUse phep toan AND,OR,NOT,XOR"); //Did change value of BitArray
            BitArray AndBit = ba1.Clone() as BitArray; //Copy ba1 not change it
            AndBit.And(ba2);
            Console.WriteLine("\nResult of AND:");
            PrintBits(AndBit, 5);
            //OR
            BitArray OrBit = ba1.Clone() as BitArray; //Copy ba1 not change it
            OrBit.Or(ba2);
            Console.WriteLine("\nResult of OR:");
            PrintBits(OrBit, 5);
            //NOT
            BitArray NotBit = ba1.Clone() as BitArray; //Copy ba1 not change it
            NotBit.Not();
            Console.WriteLine("\nResult of NOT:");
            PrintBits(NotBit,5);
            //XOR
            BitArray XorBit = ba1.Clone() as BitArray; //Copy ba1 not change it
            XorBit.Xor(ba2);
            Console.WriteLine("\nResult of Xor");
            PrintBits(XorBit,5);
            #endregion
            Console.ReadKey();
		}
	}
}
