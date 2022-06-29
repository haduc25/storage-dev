using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            ////Create 1 List
            //List<int>CreL = new List<int>();            //Create List Empty
            //List<int>CreL1 = new List<int>(5);          //Create List voi Capacty Start vs 5
            //List<int> CreL2 = new List<int>(CreL1);     //Create gan CreL2 = CreL1 
            #endregion
            #region Ex 1: List
            //Create List
            List<string> CreL3 = new List<string>();
            CreL3.Add("Name's Stephen"); //Add Value
            CreL3.Add("King");
            Console.WriteLine("1.First List\nValue First List is: {0}",CreL3.Count);
            //List vua nhap
            foreach (string item in CreL3)
            {
                Console.WriteLine(""+item);
            }
            Console.WriteLine();
            //Chèn PT in First
            CreL3.Insert(0,"Wow, Hello"); //Insert(): Để chèn PT
            Console.WriteLine("\n2.Last List after add insert\nValue last list is: {0}",CreL3.Count);
            //List After add insert
            foreach (string item in CreL3)
            {
                Console.WriteLine("" + item);
            }
            Console.WriteLine();
            #endregion
            Console.ReadKey();
        }
    }
}
