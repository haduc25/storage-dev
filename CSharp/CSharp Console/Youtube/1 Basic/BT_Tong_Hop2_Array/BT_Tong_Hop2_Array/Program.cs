using System;

namespace BT_Tong_Hop2_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nhập,Xuất Mảng 1 Chiều,Length
            
            //Nhập,Xuất Mảng 1 Chiều,Length
            Console.WriteLine("/============> Nhap, xuat mang 1 chieu, length <============/");
            //Arr1: Có 3 kiểu Khai Báo
            //Ex1:
            Console.WriteLine("/> Ex1: \n");
            int[] Count = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Arr = [{0}]", i, Count);

            }

            //Ex2:
            Console.WriteLine("\n/> Ex2: \n");
            string[] Count2 = new string[] { "Hello World", "Welcome" };
            Console.WriteLine(Count2[0]);

            //Ex3:
            Console.WriteLine("\n/> Ex3: \n");
            int[] CountArr = { 1, 3, 8, 25 };
            Console.WriteLine(CountArr[0]);
            Console.WriteLine(CountArr[1]);
            Console.WriteLine(CountArr[2]);
            Console.WriteLine(CountArr[3]);

            //Length : Hàm lấy giá trị của Arr
            Console.WriteLine("\n/> Length: \n");
            string[] Count3 = new string[5];
            for (int i3 = 0; i3 < Count3.Length; i3++)//Length lấy giá trị của "new string []"
            {
                Console.Write("Nhap ARR[{0}]= ", i3);
                Count3[i3] = Console.ReadLine(); //Nhập
            }
            Console.WriteLine(); // Xuống dòng
            Console.WriteLine("Xuat mang");
            for (int i3 = 0; i3 < Count3.Length; i3++)//Length lấy giá trị của "new string []"
            {
                Console.Write("[{0}]= ", i3);
                Console.WriteLine(Count3[i3]);//Xuất
            }

            #endregion

            /*=================================================================================================*/

            #region Nhap, xuat mang 2 chieu, GetLength

            
            Console.WriteLine("/============> Nhap, xuat mang 2 chieu, GetLength <============/");
            //Nhập, Xuất Mảng 2 Chiều, GetLength

            //Arr2: Có 3 kiểu khai báo
            //Ex1:
            Console.WriteLine("\n/> Ex1: \n");
            int[,] Arr4 = new int[9, 10];
            for (int i = 0; i < Arr4.GetLength(0); i++)
            {
                for (int j = 0; j < Arr4.GetLength(1); j++)
                {
                    Console.Write("{0,5}", Arr4[i, j]);
                }
                Console.WriteLine();
            }

            //Ex2:
            /*
            string[,] Value4 = new string[,];
            {
                 { 0,1,2,3},
                 { 4,5,6,7 },
                 { 8,9,10,11 }
            };
            */
            
            //Ex3:
            Console.WriteLine("\n/> Ex3: \n");
            int[,] Arr5 =
             {
               {0,1 ,2},
               {3,4,5 },
               { 6,7,8}
             };

            //GetLength(0); độ dài chiều 1,Ex: GetLength(0): Lấy "Hàng"
            //GetLength(1); độ dài chiều 2,Ex: GetLength(0): Lấy "Cột"
            //Rank: copy vùng nhớ ra 1 vùng nhớ mới

            for (int i = 0; i < Arr5.GetLength(0); i++)
            {
                for (int j = 0; j < Arr5.GetLength(1); j++)
                {
                    Console.Write("{0,5}", Arr5[i, j]);

                }
                Console.WriteLine();
            }


            //Ex4
            Console.WriteLine("\n/> Ex4: \n");
            int[,] Arr6 = new int[5, 10];

            //Duyệt mảng (dòng)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write("{0,10}", Arr6[i, j]);
                Console.WriteLine();
            }

            //Duyệt mảng (cột)
            //for (int j = 0; j < 10; j++)
            //{
            //    for (int i = 0; i < 5; i++)
            //        //Console.Write("{0,5}", Arr6[j, i]);
            //    Console.WriteLine();
            //}


            //Arr 2 Chiều:
            Console.WriteLine("\n/> Array 2 chieu \n");
            Console.Write("Nhap So Hang Cua Mang: ");
            int Hang7 = int.Parse(Console.ReadLine()); // Ép kiểu
            Console.Write("Nhap So Cot cua Mang: ");
            int Cot7 = int.Parse(Console.ReadLine()); // Ép kiểu

            //Create 1 Arr 2 chiều
            int[,] Arr7 = new int[Hang7, Cot7];
            //Nhập
            for (int i = 0; i < Arr7.GetLength(0); i++)
            {
                for (int j = 0; j < Arr7.GetLength(1); j++)
                {
                    Console.Write("Nhap Arr7[{0},{1}]= ", i, j);
                    Arr7[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Xuất
            int Sum7 = 0;
            Console.WriteLine("\n/===>Mang vua nhap la <===/\n");
            for (int i = 0; i < Arr7.GetLength(0); i++)
            {
                for (int j = 0; j < Arr7.GetLength(1); j++)
                {
                    Console.Write(Arr7[i, j] + " ");
                    Sum7 = Sum7 + Arr7[i, j];

                }
                Console.WriteLine();
            }

            Console.WriteLine("\n/> Tong Value trong Mang la: {0}", Sum7);

            #endregion

            /*=================================================================================================*/

            #region Nhap, xuat mang 3 chieu, Da chieu, ZicZac, Lop Array


            Console.WriteLine("/============> Nhap, xuat mang 3 chieu, Da chieu, ZicZac <============/");
            //Nhập,Xuât Mảng 3 Chiều, Đa Chiều, ZicZac 

            //Mảng 3 Chiều, Đa Chiều Có 3 Kiểu Khai Báo Như Mảng 1 và 2 chiều
            Console.WriteLine("\n/> Ex1: mang 3 chieu\n");
            //Ex1: Arr 3 Chiều
            int[,,] Arr8 =
                {{
                   {0,1,2,3},
                   {4,5,6,7},
                   {8,9,10,11},
                },

                {
                   {0,1,2,3},
                   {4,5,6,7},
                   {8,9,10,11},
                },};

            //xuat
            for (int i = 0; i < Arr8.GetLength(0); i++)
                for (int j = 0; j < Arr8.GetLength(1); j++)
                    for (int k = 0; k < Arr8.GetLength(2); k++)
                        Console.Write("\t" + Arr8[i, j, k]);


            //Mảng ZicZac
            //Ex1
            int[][] ArrZZ = new int[3][]; // Chỉ đc khai báo 1 pt
            ArrZZ[0] = new int[1];
            ArrZZ[1] = new int[2];
            ArrZZ[2] = new int[3];//End

            Console.WriteLine("\n/> Ex2: mang ZicZac\n");

            //Ex2: 
            int[][] ArrZZ9 =
            {
                new int[]{1,2,3},
                new int[]{4,5,6,7,8},
            };

            //xuat
            for (int i = 0; i < ArrZZ9.Length; i++)
                for (int j = 0; j < ArrZZ9[i].Length; j++)//Thêm Phần tủ thứ [i]
                    Console.WriteLine(ArrZZ9[i][j]);
                Console.WriteLine();


            Console.WriteLine("\n/> Ex: Lop Array\n");
            //Lớp Array
            int[] Arr10 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < Arr10.Length; i++)
            {
                Console.WriteLine(Arr10[i]);
                // Array.Reverse(Arr); Đảo ngược chuôi các phần tử  trong mảng 1 chiều
                //Array.IndexOf(Arr, 5); Tìm kiếm đối tượng đã chỉ định và trả về chỉ
                //mục xuất hiện đầu tiên của nó trong mảng một chiều.
                Array.Reverse(Arr10);
                Console.WriteLine();
                Console.WriteLine(Arr10[i]);
                Console.WriteLine(Array.IndexOf(Arr10, 5));
            }
            #endregion

            Console.ReadKey();
        }
    }
}
