using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tong_Hop
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region Hằng số, Ép Kiểu
            Console.WriteLine("/============> Hang so, Ep kieu <============/");

            //Hằng số:
            const int a = 10; //là hằng số k thể thay đổi
            Console.WriteLine("/> Hang so a: " + a);

            // Ép kiểu
            // 1.Ngầm định:
            int a1 = 1;
            float b1 = 1.5f;
            long c1 = a1; //vì "long" > "int" nên có thể chuyển
            double d1 = b1; //tuong tu long 
            Console.WriteLine("\n/> Ep kieu ngam dinh a1: " + a1);
            Console.WriteLine("a1={0}\tb2={1}\tc1={2}\td1={3}", a1, b1, c1, d1);

            //2.Tường minh:
            int a2 = 300;
            byte b2 = (byte)a2; //Vi "byte" gioi han 255 ma "a" = 300 nen se cat ngi phan (8 bit)
            Console.WriteLine("\n/> Ep kieu tuong minh");
            Console.WriteLine("a2 = " + a2);
            Console.WriteLine("b2 = " + b2);
            double c2 = 2 / 3;// = 0 vi chua ep kieu so nguyen 2,3
            double d2 = (double)2 / 3;//ra kq da ep
            double e2 = 1.0 * 2 / 3;
            Console.WriteLine("\nc2 = " + c2);
            Console.WriteLine("d2 = " + d2);
            Console.WriteLine("e2 = " + e2);

            //3 sử dụng phương thức, lớp hỗ trợ sẵn
            //3.1 Parse() : để chuyển từ chuỗi "string" sang số
            string a3 = "10";
            int b3 = int.Parse(a3);
            double c3 = double.Parse("10.9");
            Console.WriteLine("\n/> Ep kieu Parse()");
            Console.WriteLine("a3 = " + a3);
            Console.WriteLine("b3 = " + b3);
            Console.WriteLine("c3 = " + c3);

            //3.2 TryParse() : kiểm tra ép kiểu thành công hay k
            int Result; //chứa giá trị kết quả khi ép kiểu thành công
            bool isSuccess;//kiểm tra thành công hay k
            string a4 = "10";// dữ liệu 
            isSuccess = int.TryParse(a4, out Result);
            Console.WriteLine("\n/> Ep kieu TryParse()");
            Console.WriteLine(isSuccess == true ? "Success !" : "False ! ");
            Console.WriteLine("Result = " + Result);

            //3.3 Convert
            //int val = Convert.ToInt32()

            //4.Người dùng tự định nghĩa
            //Class

            /* Ép kiểu
             1.chuyển đổi ngầm định:
             2.chuyển dổi tường minh:
             3.sử dụng phương thức, lớp hỗ trợ sẵn =>Parse(),TryParse(),Convert
             4.người dùng tự định nghĩa chuyển dổi
            */

            #endregion

            /*=================================================================================================*/

            #region If Else, Boxing, Unboxing, Var, Object, Dynamic, Goto, For
            Console.WriteLine("\n/============> If Else, Boxing, Unboxing, Var, Object, Dynamic, Goto, For <============/");
            /*Boxing,Unboxing,Var,Object,Dynamic,Goto*/

            //If,else
            Console.WriteLine("\n/> IF, ELSE");
            string a5 = "Ha Minh Duc";
            bool b5 = a5 == "Ha Minh Duc" ? true : false;
            // Case 1:
            if (b5) Console.WriteLine("b5 = true: " + b5);
            //Case 2:
            if (a5 == "Ha Minh Duc" ? true : false)
                Console.WriteLine("Hello Ha Minh Duc");
            else
                Console.WriteLine("Oh No !!! ");

            //object
            /*boxing: chuyển từ kiểu dự liệu giá trị sang kiểu sữ liệu tham chiếu
            unboxing: ngược lại boxing
            */
            Console.WriteLine("\n/> Object, Boxing, Unboxing");
            object obj = "Ha Minh Duc";
            int value = 10;
            object objectValue = value;
            int newValue = (int)objectValue;
            Console.WriteLine(obj);
            Console.WriteLine(value);
            Console.WriteLine(objectValue);
            Console.WriteLine(newValue);


            //Var
            Console.WriteLine("\n/> Var");
            var a6 = 10;
            Console.WriteLine("value of a6: " + a6);

            //dynamic
            Console.WriteLine("\n/> Dynamic");
            string HoTen7 = "Ha Minh Duc";
            string Tuoi7 = "18";

            // gán 1 string cho dynamic ép kiểu (imlicit)
            dynamic DynamicHoTen = HoTen7;

            //Cộng chuỗi
            Console.WriteLine("Ten Toi La: " + DynamicHoTen + "\nTuoi: " + Tuoi7);//end


            // Vòng lặp
            //Ex1: Goto
            Console.WriteLine("\n/> Loop (Goto)");
            goto Step;

            Console.WriteLine("Here's Step 1");
        Step:
            Console.WriteLine("Here's Step 2");

            //Ex2: bước nhảy của goto
            Console.WriteLine("\n/> Loop (Goto) buoc nhay");
            string HoTen8 = "Ha Minh Duc";
            int count8 = 0;

        //bước nhảy của goto
        loop:
            Console.WriteLine(HoTen8);
            count8++;
            if (count8 < 10)
            {
                goto loop;
            }
            Console.WriteLine("End Loop");


            //Ex1: for
            Console.WriteLine("\n/> Loop (for)");
            int i;
            int j = 0;
            for (i = 0; i < 10; i++, j += 5, Console.WriteLine("Rise Now !"))
                Console.WriteLine("{0} | {1} ", i, j);

            #endregion

            /*=================================================================================================*/

            #region Ve hinh vuong, Random number
            Console.WriteLine("\n /============> Ve hinh vuong <============/ \n");

            //Vẽ Hình
            //Ex2:Vẽ hình vuong
            Console.WriteLine("/> Ve hinh vuong");
            int a9 = 10;
            int b9 = 20;
            char draw9 = '#';
            char inside9 = ' ';
            for (int i9 = 0; i9 < a9; i9++)
            {
                for (int j9 = 0; j9 < b9; j9++)
                {
                    if (i9 % (a9 - 1) == 0 || ((i9 % (a9 - 1) != 0) && (j9 % (b9 - 1) == 0)))
                    {
                        Console.Write(draw9);
                    }
                    else
                    {
                        Console.Write(inside9);
                    }
                }
                Console.WriteLine();
            }


            //Random
            Console.WriteLine("\n/> Random Number\n");
            int CountLoop = 0;
            int CountTime = 0;
            int Value = 10;
            int LoopTime = 50;
            int MinRandomValue = 1;
            int MaxRandomValue = 6;
            Random rand = new Random();
            //Vẽ từ trên xuống LoopTime lần 
            do
            {
                //Reset lại biến CountLoop=0 Viết lại từ đầu
                CountLoop = 0;
                //Vẽ từ trái qua Value Lần
                do
                {
                    //giá trị ngậu nhiêu từ [Min-Max]
                    int ShowValue = rand.Next(MinRandomValue, MaxRandomValue);
                    //in ra giá trị của Showvalue trong 8 vị trí
                    Console.Write("{0,8}", ShowValue);
                    // Tăng giá trị của biến CountLoop Lên 1 đơn vị
                    CountLoop++;
                } while (CountLoop < Value);
                //Hoàn thành 1 vòng lặp nhỏ xuống dòng chuaaen vị vẽ dòng cont
                Console.WriteLine();
                //Tăng giá trị của CountLoopTime lên 1 đơn vị
                CountTime++;
            } while (CountTime < LoopTime);

            #endregion

            /*=================================================================================================*/

            #region Biến Toàn cục và biến cục bộ
            Console.WriteLine("\n /============> Bien toan cu & bien cuc bo <============/ \n");
            Console.WriteLine(a10);
            a10 = "Ahihi"; //Biến cục bộ
            Demo10();

            #endregion

            /*=================================================================================================*/

            #region Ref & Out
            Console.WriteLine("\n /============> Ref & Out <============/ \n");
            //ref: Tham Chiếu
            //lưu ý : phải khai báo giá trị trước ref
            //VD:
            int value11 = 10; // bắt buộc pải khai báo giá trị
            Console.WriteLine("Value First {0} ", value11);
            Ham1_11(ref value11);
            Console.WriteLine("Value Last {0}", value11);

            //out:
            //-khai báo giá trị sau
            //VD:
            int value12; // k cần khai báo giá trị trước
                       // Console.WriteLine("Value First {0} ", value);
            Ham2_11(out value12);
            Console.WriteLine("Value Last {0}", value12);
            #endregion

            Console.ReadKey();
        }

        #region Biến Toàn cục và biến cục bộ
        //
        static string a10 = "18"; //Biến toàn cục

        //
        static void Demo10()
        {
            string a10 = "25/09/2001"; //Biến cục bộ
            Console.WriteLine("Ha Minh Duc");
            Console.WriteLine(a10);
        }
        #endregion

        #region Ref & Out
        //ref
        static void Ham1_11(ref int value)
        {
            value++;
        }

        //out
        static void Ham2_11(out int value)
        {
            value = 50;
            value++;
        }
        #endregion

    }
}
