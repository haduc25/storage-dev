using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList stl = new SortedList(new SortList()); //Add Sort By Age
            stl.Add(new Empty("Ha Duc", 18), 25);
            stl.Add(new Empty("HMD is me", 81), 52);
            stl.Add(new Empty("Minh Duc", 20), 250);
            foreach (DictionaryEntry item in stl)
            {
                Console.WriteLine("Key: "+item.Key+"\tValue: "+item.Value);
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
