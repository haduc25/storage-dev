using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface IList được kế thừa từ hai interface khác là ICollection và IEnumerable
            IList<string> ils = new List<string>() {"Here's 1","Here's 2","Here's 3"};
            string st = string.Join("\tHey\t", ils); //Chen Pt
            Console.WriteLine(st);
            Console.ReadKey();
            //Some Ham khac IsFixedSize,IsReadOnly,Item[Int32],Add(Object),Clear(),
            //Contains(Object),IndexOf(Object),Insert(Int32,Object),Remove(Object),RemoveAt(Int32).
            //More Howktem
        }
    }
}
