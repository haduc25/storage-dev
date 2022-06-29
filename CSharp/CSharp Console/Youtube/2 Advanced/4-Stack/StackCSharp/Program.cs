using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack Ex1:
            /*Stack:
             * Peek() :return last value (value add first) but not remove value
             * Pop()  :return last value (value add first)  but remove value
             * Push(object Value) : Add Value
             */
            //Create Stack
            Stack st = new Stack();
            Stack st1 = new Stack(10); //Create Stack 10 sức chứa
            //Create Stack vs ArrayList
            ArrayList arrl = new ArrayList();
            arrl.Add(1);
            arrl.Add(3);
            arrl.Add(5);
            //Create stack and copy value form "arrl" to "Stack"(st2)
            Stack st2 = new Stack(arrl);
            #endregion
            #region Ex2:
            Stack st3 = new Stack();
            //Add Stack
            st3.Push("Here is Value : 0");
            st3.Push("Here is Value : 1");
            st3.Push("Here is Value : 2");
            st3.Push("Here is Value : 3");
            Console.WriteLine("Value Now: "+st3.Count);
            Console.WriteLine("Value First Stack (Peek): " + st3.Peek());
            Console.WriteLine("Value After call (Peek): " + st3.Count);
            Console.WriteLine("\tUse Pop...");
            int length = st3.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Value First Stack (Pop): " + st3.Pop());
            }
            Console.WriteLine();
            Console.WriteLine("Value After call (Pop): " + st3.Count);
            #endregion
            Console.ReadKey();
        }
    }
}
