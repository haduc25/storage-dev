using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectinonCSharp
{
    class Program
    {
        #region Ex 1: IConlection
        //Create 
        public class MyIC : ICollection // Create Ham ke thua IConllection ngang hang voi cac ham trong (using System.Collections;)
        {
            private object[] av; //Array Value
            private int count;//amount(Số lượng)
            private const int max = 100; //Max

            public int Count { get => count; set => count = value; }

            public object SyncRoot => throw new NotImplementedException(); //Defaul Chua dinh nghia

            public bool IsSynchronized => throw new NotImplementedException(); //Defaul Chua dinh nghia

            //Create Contructer
            public MyIC() 
            {
                Count = -1;
                av = new object[max];
            }
            public MyIC(int count) 
            {
                this.Count = count;
                av = new object[count];
            }
            public MyIC(Array array) //Same Generic here "Array" is Types Data,"array" is name
            {
                array.CopyTo(av, 0); //Copy
                Count = array.Length;
            }
            public void CopyTo(Array array,int index) 
            {
                av.CopyTo(array, index);//Copy form av -->index
            }

            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //IConlection: Same Same Interface, Use Create Hàm User tu dinh nghia va ke tu tu IConlection
            #region Ex 1: IConlection
            MyIC a = new MyIC();
            Console.WriteLine("Value is: " + a.Count); //Test 
            #endregion
            Console.ReadKey();
        }
    }
}
