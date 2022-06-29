using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conllection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList Arr1 = new ArrayList(); //Create 1 Arraylist rỗng

            //Add value in Arraylist

            Arr1.Add(new Empty("Hello A", 10)); //Empty is Class
            Arr1.Add(new Empty("Hello B", 14)); //Empty is Class
            Arr1.Add(new Empty("Hello C", 17)); //Empty is Class
            Arr1.Add(new Empty("Hello D", 112)); //Empty is Class
            Arr1.Add(new Empty("Hello E", 14)); //Empty is Class
            Console.WriteLine("Danh sach vua nhap la: \n");
            foreach (Empty item in Arr1)
            {
                Console.WriteLine(item.ToString()); //In DS
            }
            //Sort List
            Arr1.Sort(new SortList());
            //In ra List sau khi xắp sếp
            Console.WriteLine("\nSortList theo Age tang dan: \n");
            foreach (Empty item in Arr1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
        public class SortList : IComparer
        {
            public int Compare(object x, object y)
            {
                //Ép kiểu object về kiểu Empty
                Empty emt1 = x as Empty;
                Empty emt2 = y as Empty;

                //Check DK
                if (emt1 == null || emt2 == null)
                {
                    throw new InvalidCastException();
                }
                else
                { //Dữ liệu trả về (1,0,-1) tương ứng (lớn hơn,bằng,bé hơn)
                    if (emt1.Age < emt2.Age)
                    {
                        return 1;
                    }
                    else if (emt1.Age == emt2.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}