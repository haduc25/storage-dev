using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Queue:
            /*Queue:
             * Giống Stack
             * Dequeue() : Return first value (value add first) but remove value
             * Enqueue(object value) : Add first value
             */
            #endregion
            #region Ex1:
            //Create Queue
            Queue qe = new Queue();
            qe.Enqueue("Hello I'm Value 0");
            qe.Enqueue("Hello I'm Value 1");
            qe.Enqueue("Hello I'm Value 2");
            qe.Enqueue("Hello I'm Value 3");
            Console.WriteLine("Value Now:"+qe.Count);
            Console.WriteLine("Value First Queue (Peek): " + qe.Peek());
            Console.WriteLine("Value After call (Peek): " + qe.Count);
            Console.WriteLine("\tUse Dequeue...");
            int length = qe.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Value First Queue (Dequeue): " + qe.Dequeue());
            }
            Console.WriteLine();
            Console.WriteLine("Value After call (Dequeue): " + qe.Count);
            #endregion
            Console.ReadKey();
        }
    }
}
