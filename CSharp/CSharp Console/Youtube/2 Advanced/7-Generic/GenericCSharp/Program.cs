using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCSharp
{
    class Program
    {
        #region Ex 1:
        public static void Swap<TempN>(ref TempN a, ref TempN b) //<Tempotary Name> 
        {
            TempN temp = a;
            a = b;
            b = temp;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Ex: 1.Generic of Phuong Thuc
            //int a, b;
            //Console.Write("Nhap a= ");
            //a = Convert.ToInt32(Console.ReadLine()); //Ep Kieu string -> int
            //Console.Write("Nhap b= ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("First:\nValue a = " + a + "\tValue b= " + b);
            //Swap<int>(ref a, ref b);//<Types Date>: int/double/bool/char/string/float... <Types Date> --> <Tempotary>
            //Console.WriteLine("Last:\nValue a = " + a + "\tValue b= " + b);
            #endregion
            #region Ex: 2.Generic of Class
            MyGeneric<int> mg = new MyGeneric<int>(5);
            int a,b;
            a = 0;
            b = 10;
            mg.SetItemValue(a, b);
            Console.WriteLine("Value a: "+a+" Value b: "+b);
            #endregion
            Console.ReadKey();
        }
    }
}
